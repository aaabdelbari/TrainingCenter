using System;
using AutoMapper;
using TrainingCenter.Application.ViewModels;
using TrainingCenter.Domain.Models;

namespace TrainingCenter.Application.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Course, CourseViewModel>();
		}
	}
}

