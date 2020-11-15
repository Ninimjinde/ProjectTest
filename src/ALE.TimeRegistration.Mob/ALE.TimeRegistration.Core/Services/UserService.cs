using ALE.TimeRegistration.Core.Dtos;
using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<User> _userRepo;
        public UserService(IMapper mapper, IRepository<User> userRepo)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public async Task<IEnumerable<UserResponsDto>> ListAllUsersAsync()
        {
            var result = await _userRepo.GetAllAsync()
                .Include(u => u.UserTasks)
                    .ThenInclude(ut => ut.Task)
                .Include(u => u.ReceivedMessages)
                .Include(u => u.SendMessages)
                .ToListAsync();
            var dto = _mapper.Map<IEnumerable<UserResponsDto>>(result);
            return dto;
        }
        public async Task<UserResponsDto> GetByIdAsync(Guid id)
        {
            var result = await _userRepo.GetAllAsync()
                .Include(u => u.UserTasks)
                    .ThenInclude(ut => ut.Task)
                .Include(u => u.ReceivedMessages)
                .Include(u => u.SendMessages)
                .SingleOrDefaultAsync(t => t.Id.Equals(id));
            var dto = _mapper.Map<UserResponsDto>(result);
            return dto;
        }

        public async Task<IEnumerable<TaskResponseDto>> ListAllTasksAsync(Guid userId)
        {
            var result = await _userRepo.GetAllAsync()
                .Where(u => u.Id.Equals(userId))
                .Include(u => u.UserTasks)
                    .ThenInclude(ut => ut.Task)
                    .ToListAsync();
            var dto = _mapper.Map<IEnumerable<TaskResponseDto>>(result);
            return dto;
        }

        public async Task<UserResponsDto> AddAsync(UserRequestDto userRequestDto)
        {
            var user = _mapper.Map<User>(userRequestDto);
            var result = await _userRepo.AddAsync(user);
            var dto = _mapper.Map<UserResponsDto>(result);
            return dto;

        }
    }
}
