using System;
using TrainingCenter.Application.ViewModels;

namespace TrainingCenter.Application.Interfaces
{
	public interface IStudentService
	{
		Task<IEnumerable<StudentViewModel>> GetStudentsAsync();
	}
}

