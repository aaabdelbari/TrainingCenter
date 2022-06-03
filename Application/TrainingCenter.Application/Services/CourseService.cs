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
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
		{
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<CourseViewModel>> GetCoursesAsync()
        {
            var courses = await _repository.GetCoursesAsync();
            return _mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(courses);
        }
    }
}

