using System;
using AutoMapper;
using TrainingCenter.Application.Interfaces;
using TrainingCenter.Application.ViewModels;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Application.Services
{
	public class CourseService : ICourseService
	{
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
		{
            this.unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<CourseViewModel>> GetCoursesAsync()
        {
            var courses = await unitOfWork.CourseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(courses);
        }
    }
}

