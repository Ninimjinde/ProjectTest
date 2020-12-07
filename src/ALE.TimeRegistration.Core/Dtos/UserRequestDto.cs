namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserRequestDto : DtoBase
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
