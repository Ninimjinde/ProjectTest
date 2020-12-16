using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XrnCourse.BucketList.Domain.Services.Api;

namespace ALE.TimeRegistration.Mob.Domain.Services.Api
{
    public class ApiProjectService : IMobProjectService
    {
        private readonly string _baseUri;

        public ApiProjectService()
        {
            _baseUri = "https://localhost:5001/";
        }

        public Task<AppTaskResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ProjectResponseDto>> ListAll()
        {
            throw new NotImplementedException();
        }


        Task<ProjectResponseDto> IMobProjectService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
