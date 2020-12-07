using ALE.TimeRegistration.Mob.Domain.Models;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Services
{
    public interface IAppSettingsService
    {
        Task<AppSettings> GetSettings();
        Task<bool> SaveSettings(AppSettings settings);
    }
}
