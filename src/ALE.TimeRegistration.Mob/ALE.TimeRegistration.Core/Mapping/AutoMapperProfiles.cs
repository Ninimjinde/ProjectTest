﻿using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using AutoMapper;
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
/*            CreateMap<Task, UserTaskResponseDto>()
                .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Project.Name));*/
            CreateMap<AppTask, TaskResponseDto>()
               .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Project.Name))
               //.ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId))
               .ForMember(dest => dest.TaskUsers, opt => opt.MapFrom(src => src.TaskUsers.Select(tu => tu.User.Name)));
            CreateMap<TaskRequestDto, AppTask>()
                .ForPath(dest => dest.Project.Name, opt => opt.MapFrom(src => src.ProjectName));
                //.ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId));

            /*CreateMap<User, UserResponsDto>()
                .ForMember(dest => dest.Tasks,
                            opt => opt.MapFrom(src => src.UserTasks
                                                    .Select(ut => new UserTaskResponseDto
                                                    {
                                                        ProjectName = ut.Task.Project.Name,
                                                        TaskName = ut.Task.TaskName,
                                                        WorkTime = ut.Task.WorkTime
                                                    })));*/

            CreateMap<User, UserResponsDto>()
                .ForMember(dest => dest.Tasks,
                            opt => opt.MapFrom(src => src.UserTasks
                                                    .Select(ut => ut.Task.TaskName)));
            CreateMap<UserRequestDto, User>();

            CreateMap<Project, ProjectResponseDto>();
            CreateMap<ProjectRequestDto, Project>();
        }
    }
}