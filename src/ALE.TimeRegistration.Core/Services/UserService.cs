using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;
        public UserService(IMapper mapper, IUserRepository userRepo)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public async Task<IEnumerable<UserResponsDto>> ListAllUsersAsync()
        {
            var result = await _userRepo.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<UserResponsDto>>(result);
            return dto;
        }
        public async Task<UserResponsDto> GetByIdAsync(Guid id)
        {
            var result = await _userRepo.GetByIdAsync(id);
            var dto = _mapper.Map<UserResponsDto>(result);
            return dto;
        }

        public async Task<IEnumerable<AppTaskResponseDto>> ListAllTasksAsync(Guid userId)
        {
            var result = await _userRepo.ListAllTasksAsync(userId);
            var dto = _mapper.Map<IEnumerable<AppTaskResponseDto>>(result);
            return dto;
        }

        public async Task<UserResponsDto> AddAsync(UserRequestDto userRequestDto)
        {
            var user = _mapper.Map<User>(userRequestDto);
            var result = await _userRepo.AddAsync(user);
            var dto = _mapper.Map<UserResponsDto>(result);
            return dto;

        }

        public async Task<UserResponsDto> UpdateAsync(UserRequestDto userRequestDto)
        {
            var user = _mapper.Map<User>(userRequestDto);
            var result = await _userRepo.UpdateAsync(user);
            var dto = _mapper.Map<UserResponsDto>(result);
            return dto;

        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepo.DeleteAsync(id);

        }
    }
}
