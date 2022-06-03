using System;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class CourseRepository : ICourseRepository
	{
        private readonly TrainingCenterDbContext _context;

        public CourseRepository(TrainingCenterDbContext context)
		{
            this._context = context;
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}

