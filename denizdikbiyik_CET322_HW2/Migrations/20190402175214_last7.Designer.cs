﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using denizdikbiyik_CET322_HW2.Models;

namespace denizdikbiyik_CET322_HW2.Migrations
{
    [DbContext(typeof(StudentsContext))]
    [Migration("20190402175214_last7")]
    partial class last7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("denizdikbiyik_CET322_HW2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("denizdikbiyik_CET322_HW2.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("StudentEmail");

                    b.Property<string>("StudentName")
                        .IsRequired();

                    b.Property<int>("StudentNo");

                    b.Property<string>("StudentSurname")
                        .IsRequired();

                    b.Property<string>("StudentTelNo");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("denizdikbiyik_CET322_HW2.Models.Student", b =>
                {
                    b.HasOne("denizdikbiyik_CET322_HW2.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
