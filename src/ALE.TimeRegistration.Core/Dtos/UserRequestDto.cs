using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserRequestDto : DtoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 7)]
        public string Password { get; set; }
    }
}
