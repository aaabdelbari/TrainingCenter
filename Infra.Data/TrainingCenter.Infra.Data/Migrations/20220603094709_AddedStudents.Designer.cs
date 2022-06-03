﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingCenter.Infra.Data.Context;

#nullable disable

namespace TrainingCenter.Infra.Data.Migrations
{
    [DbContext(typeof(TrainingCenterDbContext))]
    [Migration("20220603094709_AddedStudents")]
    partial class AddedStudents
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TrainingCenter.Domain.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Course 1",
                            ImageUrl = "/images/course1.jpg",
                            Name = "Course 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Course 2",
                            ImageUrl = "/images/course2.jpg",
                            Name = "Course 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Course 3",
                            ImageUrl = "/images/course3.jpg",
                            Name = "Course 3"
                        });
                });

            modelBuilder.Entity("TrainingCenter.Domain.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "student1@mail.com",
                            FullName = "Student 1",
                            Mobile = "0551201651"
                        },
                        new
                        {
                            Id = 2,
                            Email = "student2@mail.com",
                            FullName = "Student 2",
                            Mobile = "0551201652"
                        },
                        new
                        {
                            Id = 3,
                            Email = "student3@mail.com",
                            FullName = "Student 3",
                            Mobile = "0551201653"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
