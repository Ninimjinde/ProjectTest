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

        /*        public async Task<UserResponsDto> GetUser(Guid id)
                {
                    var users = await GetAllUsers();
                    return users.FirstOrDefault(e => e.Id == id);
                }*/

        /*  public async Task<UserResponsDto> UpdateUser(UserRequestDto user)
          {
              var users = await GetAllUsers();
              var userToUpdate = users.FirstOrDefault(e => e.Id == user.Id);
              users.Remove(userToUpdate);
              users.Add(user);
              SaveUsersToJsonFile(users);
              return users.FirstOrDefault(e => e.Id == user.Id);
          }

          public async Task<UserResponsDto> CreateUser(UserRequestDto user)
          {
              var users = await GetAllUsers();
              users.Add(user);
              SaveUsersToJsonFile(users);
              return await GetUser(user.Id);
          }

          protected async Task<IList<UserResponsDto>> GetAllUsers()
          {
              try
              {
                  string usersJson = File.ReadAllText(_filePath);
                  var users = JsonConvert.DeserializeObject<IList<UserRequestDto>>(usersJson);
                  return await Task.FromResult(users);  //using Task.FromResult to have atleast one await in this async method
              }
              catch  //return empty collection on file not found, deserialization error, ...
              {
                  return new List<UserResponsDto>();
              }
          }*/

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
