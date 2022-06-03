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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
		{
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<StudentViewModel>> GetStudentsAsync()
        {
            var students = await _unitOfWork.StudentRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>(students);
        }
    }
}

