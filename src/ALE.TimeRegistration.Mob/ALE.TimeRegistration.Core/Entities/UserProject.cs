using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class UserProject
    {
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
