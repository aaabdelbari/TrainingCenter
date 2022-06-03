using System;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Infra.Data.Context
{
	public class TrainingCenterDbContext : DbContext
	{
		public DbSet<Course> Courses { get; set; }
		public DbSet<Student> Students { get; set; }

		public TrainingCenterDbContext(DbContextOptions<TrainingCenterDbContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Course>().HasData(new List<Course> {
				new Course { Id = 1, Name = "Course 1", Description = "Course 1", ImageUrl = "/images/course1.jpg" },
				new Course { Id = 2, Name = "Course 2", Description = "Course 2", ImageUrl = "/images/course2.jpg" },
				new Course { Id = 3, Name = "Course 3", Description = "Course 3", ImageUrl = "/images/course3.jpg" },
			});

			modelBuilder.Entity<Student>().HasData(new List<Student> {
				new Student { Id = 1, FullName = "Student 1", Email = "student1@mail.com", Mobile = "0551201651" },
				new Student { Id = 2, FullName = "Student 2", Email = "student2@mail.com", Mobile = "0551201652" },
				new Student { Id = 3, FullName = "Student 3", Email = "student3@mail.com", Mobile = "0551201653" },
			});
        }
    }
}

