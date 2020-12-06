using ALE.TimeRegistration.Mob.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain.Mocking
{
    public class MockAppSettingsService
    {
        private static List<AppSettings> appSettings = new List<AppSettings>
        {
            new AppSettings{ Language = AppSettings.Languages.Nederlands , SetDynamicTimes = true, 
                            SetFixedTimes = false, UserId = Guid.Parse("00000000-0000-0000-0000-000000000015")}
        };
    }
}
