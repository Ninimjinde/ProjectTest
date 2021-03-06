﻿using ALE.TimeRegistration.Mob.Domain;
using ALE.TimeRegistration.Mob.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XrnCourse.BucketList.Domain.Services.Api
{
    public class ApiAppTaskService : IMobTaskService
    {
        private readonly string _baseUri;

        public ApiAppTaskService()
        {
            _baseUri = "https://localhost:5001/";
        }

        public Task<AppTaskResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<AppTaskResponseDto>> ListAllTasksFromProject(ProjectResponseDto project)
        {
            return await WebApiClient
                .GetApiResult<ICollection<AppTaskResponseDto>>($"{_baseUri}TasksController/GetTasks");
        }
    }
}
