using ALE.TimeRegistration.Mob.Domain;
using ALE.TimeRegistration.Mob.Domain.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XrnCourse.BucketList.Domain.Services.Local
{
    public class JsonUsersService : IMobUserService
    {
        private readonly string _filePath;
        private readonly JsonSerializerSettings _serializerSettings;

        public JsonUsersService()
        {
            _filePath = Path.Combine(FileSystem.AppDataDirectory, "users.json");

            //prevent self-referencing loops when saving Json
            _serializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }

        protected void SaveUsersToJsonFile(IEnumerable<UserRequestDto> users)
        {
            string usersJson = JsonConvert.SerializeObject(users, Formatting.Indented, _serializerSettings);
            File.WriteAllText(_filePath, usersJson);
        }

        public Task<bool> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAdmin(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
