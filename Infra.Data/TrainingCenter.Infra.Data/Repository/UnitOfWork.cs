using System;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
        public ICourseRepository CourseRepository { get; private set; }

        public IStudentRepository StudentRepository { get; private set; }

        private readonly TrainingCenterDbContext _context;

        public UnitOfWork(TrainingCenterDbContext context)
		{
            this._context = context;
            CourseRepository = new CourseRepository(_context);
            StudentRepository = new StudentRepository(_context);
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

