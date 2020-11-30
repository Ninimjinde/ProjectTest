using ALE.TimeRegistration.Mob.Domain;
using ALE.TimeRegistration.Mob.Domain.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XrnCourse.BucketList.Domain.Services.Api
{
    public class ApiAppTaskService : IMobTaskService
    {
        private readonly string _baseUri;

        public ApiAppTaskService()
        {
            _baseUri = "https://enter-your-lan-ip-here:5001/";
        }

        public Task<AppTaskResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<AppTaskResponseDto>> ListAllTasksFromProject(ProjectResponseDto project)
        {
            throw new NotImplementedException();
            /*return await WebApiClient
                .GetApiResult<AppTaskResponseDto>($"{_baseUri}TasksController/GetTasks");*/
        }
    }
}
