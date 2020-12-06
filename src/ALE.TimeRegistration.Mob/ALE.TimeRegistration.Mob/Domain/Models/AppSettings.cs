using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain.Models
{
    public class AppSettings
    {
        public Guid UserId { get; set; }
        public UserResponsDto User { get; set; }
        public bool SetDynamicTimes { get; set; }
        public bool SetFixedTimes { get; set; }
        public Languages Language
        {
            get { return language; }
            set { language = value; }
        }
        public enum Languages { Nederlands = 0, Français = 1, English = 2 }
        private Languages language;
    }  
}
