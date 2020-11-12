using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using AutoMapper;
using System.Linq;

namespace ALE.TimeRegistration.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Task, UserResponsDto>()
                .ForMember(dest => dest.TimeWorked,
                            opt => opt.MapFrom(src => src.WorkTime.TotalMinutes));

            CreateMap<User, UserResponsDto>()
                .ForMember(dest => dest.Tasks,
                            opt => opt.MapFrom(src => src.UserTasks
                                                    .Select(ag => new TaskResponseDto
                                                            {   Id = ag.TaskId,
                                                                TaskName = ag.Task.TaskName
                                                            })));
        }
    }
}