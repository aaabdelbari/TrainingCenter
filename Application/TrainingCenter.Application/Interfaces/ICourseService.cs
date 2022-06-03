using System;
using TrainingCenter.Application.ViewModels;

namespace TrainingCenter.Application.Interfaces
{
	public interface ICourseService
	{
		Task<IEnumerable<CourseViewModel>> GetCoursesAsync();
	}
}

