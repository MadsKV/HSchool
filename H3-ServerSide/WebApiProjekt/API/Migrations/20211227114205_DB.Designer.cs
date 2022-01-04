﻿// <auto-generated />
using ClassLibary.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211227114205_DB")]
    partial class DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibary.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ClassLibary.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("ClassLibary.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("ClassLibary.Models.Employee", b =>
                {
                    b.HasBaseType("ClassLibary.Models.Person");

                    b.Property<int>("Sallery")
                        .HasColumnType("int");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ClassLibary.Models.Student", b =>
                {
                    b.HasBaseType("ClassLibary.Models.Person");

                    b.Property<int>("StartEducationYear")
                        .HasColumnType("int");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassLibary.Models.EUDStudent", b =>
                {
                    b.HasBaseType("ClassLibary.Models.Student");

                    b.Property<bool>("Contract")
                        .HasColumnType("bit");

                    b.ToTable("EUDStudents");
                });

            modelBuilder.Entity("ClassLibary.Models.HTXStudent", b =>
                {
                    b.HasBaseType("ClassLibary.Models.Student");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasIndex("CourseId");

                    b.ToTable("HTXStudents");
                });

            modelBuilder.Entity("ClassLibary.Models.Person", b =>
                {
                    b.HasOne("ClassLibary.Models.School", "School")
                        .WithMany("Persons")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("ClassLibary.Models.Employee", b =>
                {
                    b.HasOne("ClassLibary.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("ClassLibary.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibary.Models.Student", b =>
                {
                    b.HasOne("ClassLibary.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("ClassLibary.Models.Student", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibary.Models.EUDStudent", b =>
                {
                    b.HasOne("ClassLibary.Models.Student", null)
                        .WithOne()
                        .HasForeignKey("ClassLibary.Models.EUDStudent", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibary.Models.HTXStudent", b =>
                {
                    b.HasOne("ClassLibary.Models.Course", "Course")
                        .WithMany("HTXStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ClassLibary.Models.Student", null)
                        .WithOne()
                        .HasForeignKey("ClassLibary.Models.HTXStudent", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ClassLibary.Models.Course", b =>
                {
                    b.Navigation("HTXStudents");
                });

            modelBuilder.Entity("ClassLibary.Models.School", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
