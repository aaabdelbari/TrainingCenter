using System;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class CourseRepository : BaseRepository<Course, int>, ICourseRepository
	{
        public CourseRepository(TrainingCenterDbContext context)
            : base(context)
		{

        }
    }
}

