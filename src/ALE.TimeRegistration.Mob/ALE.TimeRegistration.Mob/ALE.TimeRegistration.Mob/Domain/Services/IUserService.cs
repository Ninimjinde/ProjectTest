using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IUserService
    {
        Task<bool> Login(string email, string password);
        Task<bool> IsAdmin(string email, string password);
    }
}
