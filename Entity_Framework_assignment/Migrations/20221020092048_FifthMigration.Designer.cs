﻿// <auto-generated />
using System;
using Entity_Framework_assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity_Framework_assignment.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    [Migration("20221020092048_FifthMigration")]
    partial class FifthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity_Framework_assignment.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Marks", b =>
                {
                    b.Property<int>("MarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarksId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("MarksId");

                    b.HasIndex("StudentId");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectsSubjectId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("SubjectTeacher");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Marks", b =>
                {
                    b.HasOne("Entity_Framework_assignment.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entity_Framework_assignment.Models.Student", b =>
                {
                    b.HasOne("Entity_Framework_assignment.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.HasOne("Entity_Framework_assignment.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity_Framework_assignment.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
