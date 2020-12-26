using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace ALE.TimeRegistration.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppTask, UserResponsDto>()
                .ForMember(dest => dest.TimeWorked,
                            opt => opt.MapFrom(src => src.WorkTime.TotalMinutes));

            CreateMap<AppTask, AppTaskResponseDto>()
               .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Project.Name));
            CreateMap<AppTaskRequestDto, AppTask>()
                .ForPath(dest => dest.Project.Name, opt => opt.MapFrom(src => src.ProjectName));

            CreateMap<User, UserResponsDto>();
            CreateMap<UserRequestDto, User>();

            CreateMap<Project, ProjectResponseDto>();
            CreateMap<ProjectRequestDto, Project>();

            CreateMap<UserTask, UserTaskResponseDto>();
            CreateMap<UserTaskRequestDto, UserTask>();


            CreateMap<IdentityUser, UserResponsDto>();
        }
    }
}