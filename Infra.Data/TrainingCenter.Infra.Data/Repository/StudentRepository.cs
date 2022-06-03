using System;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class StudentRepository : IStudentRepository
	{
        private readonly TrainingCenterDbContext _context;

        public StudentRepository(TrainingCenterDbContext context)
		{
            this._context = context;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}

