using System;
using AutoMapper;
using TrainingCenter.Application.Interfaces;
using TrainingCenter.Application.ViewModels;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Application.Services
{
	public class StudentService : IStudentService
	{
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repository, IMapper mapper)
		{
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<StudentViewModel>> GetStudentsAsync()
        {
            var students = await _repository.GetStudentsAsync();
            return _mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>(students);
        }
    }
}

