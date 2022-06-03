using System;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class StudentRepository : BaseRepository<Student, int>, IStudentRepository
	{

        public StudentRepository(TrainingCenterDbContext context)
            : base(context)
		{

        }
    }
}

