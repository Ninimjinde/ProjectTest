using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Core.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public class UserTaskService : IUserTaskService
    {
        private readonly IMapper _mapper;
        private readonly IUserTaskRepository _userTaskRepo;

        public UserTaskService(IMapper mapper, IUserTaskRepository userTaskRepository)
        {
            _mapper = mapper;
            _userTaskRepo = userTaskRepository;
        }

        public async Task<UserTaskResponseDto> AddAsync(UserTaskRequestDto userTaskRequestDto)
        {
            var userTask = _mapper.Map<UserTask>(userTaskRequestDto);
            userTask.WorkDateTime = DateTime.UtcNow;
            var result = await _userTaskRepo.AddAsync(userTask);
            var dto = _mapper.Map<UserTaskResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<UserTaskResponseDto>> GetUserTasks(string userId)
        {
            var result = await _userTaskRepo.GetUserTasks(userId);
            var dto = _mapper.Map<IEnumerable<UserTaskResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<UserTaskResponseDto>> ListAllTasksAsync()
        {
                var result = await _userTaskRepo.ListAllAsync();
                var dto = _mapper.Map<IEnumerable<UserTaskResponseDto>>(result);
                return dto;
        }

    }
}
