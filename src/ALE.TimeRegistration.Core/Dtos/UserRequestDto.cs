using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserRequestDto : DtoBase
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 7)]
        public string Password { get; set; }
    }
}
