#pragma checksum "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9290e298acaab6eae56ae30b194a23b595c9eabc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2;

#line default
#line hidden
#line 2 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9290e298acaab6eae56ae30b194a23b595c9eabc", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a424e2aadde9a2992fa45b537eff4607f6189bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<denizdikbiyik_CET322_HW2.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eklenen dosya"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Detaylar";

#line default
#line hidden
            BeginContext(94, 422, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.css"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.js""></script>

<section class=""ab-info-main py-md-5"">
    <div class=""container py-md-3"">
        <h1>Detaylar</h1>
        <br />
        <div>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
            EndContext();
            BeginContext(516, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc5905", async() => {
                BeginContext(565, 16, true);
                WriteLiteral("Öğrenci Numarası");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 17 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentNo);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(589, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(675, 41, false);
#line 20 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.StudentNo));

#line default
#line hidden
            EndContext();
            BeginContext(716, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(800, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc8199", async() => {
                BeginContext(851, 11, true);
                WriteLiteral("Öğrenci Adı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 23 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(870, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(956, 43, false);
#line 26 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(999, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1083, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc10493", async() => {
                BeginContext(1137, 14, true);
                WriteLiteral("Öğrenci Soyadı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentSurname);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1159, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1245, 46, false);
#line 32 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.StudentSurname));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1375, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc12801", async() => {
                BeginContext(1427, 14, true);
                WriteLiteral("E-Posta Adresi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 35 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentEmail);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1449, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1535, 44, false);
#line 38 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.StudentEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1663, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc15105", async() => {
                BeginContext(1715, 16, true);
                WriteLiteral("Telefon Numarası");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 41 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentTelNo);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1739, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1825, 44, false);
#line 44 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.StudentTelNo));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 211, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    <label class=\"control-label\">Dosya</label>\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2080, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9290e298acaab6eae56ae30b194a23b595c9eabc17549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2090, "~/uploads/", 2090, 10, true);
#line 50 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
AddHtmlAttributeValue("", 2100, Model.ImageUrl, 2100, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2157, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2241, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc19394", async() => {
                BeginContext(2288, 8, true);
                WriteLiteral("Hakkında");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 53 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2304, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2390, 39, false);
#line 56 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2513, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc21681", async() => {
                BeginContext(2564, 13, true);
                WriteLiteral("Eklenen Tarih");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 59 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2585, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2671, 43, false);
#line 62 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 215, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    <label class=\"control-label\">Departman</label>\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2930, 57, false);
#line 68 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
               Write(Html.DisplayFor(model => model.Department.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(2987, 87, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3074, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc24600", async() => {
                BeginContext(3127, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
                                   WriteLiteral(Model.StudentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3138, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(3154, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290e298acaab6eae56ae30b194a23b595c9eabc26951", async() => {
                BeginContext(3176, 11, true);
                WriteLiteral("Listeye Dön");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3191, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3251, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 79 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Students\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3321, 74, true);
                WriteLiteral("    <script>\r\n        var editor = new Jodit(\'#Content\');\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<denizdikbiyik_CET322_HW2.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
