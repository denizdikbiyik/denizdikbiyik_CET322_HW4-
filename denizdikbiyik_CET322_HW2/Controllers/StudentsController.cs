using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using denizdikbiyik_CET322_HW2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace denizdikbiyik_CET322_HW2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public StudentsController(StudentsContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var studentsContext = _context.Student.Include(s => s.Department);
            return View(await _context.Student.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.Include(s=>s.Department)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<Department> departmentlist = new List<Department>();
            departmentlist = (from Department in _context.Department select Department).ToList();
            Student student = new Student();
            student.departments = GetDepartments(departmentlist);
            return View(student);
        }
        private IEnumerable<SelectListItem> GetDepartments(IEnumerable<Department> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.DepartmentName
                });
            }

            return selectList;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, Student studentmodel, IFormFile FileUrl)
        {            
            if (ModelState.IsValid)
            {
                string dirPath = Path.Combine(_hostingEnvironment.WebRootPath, @"uploads\");
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + "_" + FileUrl.FileName;
                using (var fileStream = new FileStream(dirPath + fileName, FileMode.Create))
                {
                    await FileUrl.CopyToAsync(fileStream);
                }

                studentmodel.CreatedDate = DateTime.Now;

                Student student = new Student();
                student.StudentNo = studentmodel.StudentNo;
                student.StudentName = studentmodel.StudentName;
                student.StudentSurname = studentmodel.StudentSurname;
                student.StudentEmail = studentmodel.StudentEmail;
                student.StudentTelNo = studentmodel.StudentTelNo;               
                student.ImageUrl = fileName;
                student.Content = studentmodel.Content;
                student.CreatedDate = studentmodel.CreatedDate;
                student.DepartmentId = studentmodel.DepartmentId;

                _context.Student.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentmodel);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            List<Department> departmentlist = new List<Department>();
            departmentlist = _context.Department.ToList();
            student.departments = GetDepartments(departmentlist);
            

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentNo,StudentName,StudentSurname,StudentEmail,StudentTelNo,DepartmentId,ImageUrl,Content,CreatedDate")] Student student, IFormFile FileUrl)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingstundent = _context.Student.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
                    if (FileUrl != null)
                    {
                        string dirPath = Path.Combine(_hostingEnvironment.WebRootPath, @"uploads\");
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + "_" + FileUrl.FileName;
                        using (var fileStream = new FileStream(dirPath + fileName, FileMode.Create))
                        {
                            await FileUrl.CopyToAsync(fileStream);
                        }
                        existingstundent.ImageUrl = fileName;
                    }

                    existingstundent.CreatedDate = DateTime.Now;
                    _context.Student.Update(existingstundent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.StudentId == id);
        }
    }
}
