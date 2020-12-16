﻿using ALE.TimeRegistration.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponsDto>> ListAllUsersAsync();
        Task<IEnumerable<AppTaskResponseDto>> ListAllTasksAsync(Guid userId);
        Task<UserResponsDto> GetByIdAsync(Guid id);
        Task<UserResponsDto> AddAsync(UserRequestDto userRequestDto);
        Task<UserResponsDto> UpdateAsync(UserRequestDto userRequestDto);
        Task DeleteAsync(Guid id);


    }
}
