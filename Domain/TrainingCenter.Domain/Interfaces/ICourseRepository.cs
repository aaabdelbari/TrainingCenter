using System;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Domain.Interfaces
{
	public interface ICourseRepository
	{
		Task<IEnumerable<Course>> GetCoursesAsync();
	}
}

