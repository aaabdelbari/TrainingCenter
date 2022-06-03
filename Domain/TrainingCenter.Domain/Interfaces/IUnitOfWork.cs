using System;
namespace TrainingCenter.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		ICourseRepository CourseRepository { get; }
		IStudentRepository StudentRepository { get; }

		Task<int> Complete();
	}
}

