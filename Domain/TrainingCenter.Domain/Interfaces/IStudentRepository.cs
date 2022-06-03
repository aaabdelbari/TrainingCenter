using System;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Domain.Interfaces
{
	public interface IStudentRepository
	{
		Task<IEnumerable<Student>> GetStudentsAsync();
	}
}

