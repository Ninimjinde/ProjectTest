namespace ALE.TimeRegistration.Mob.Domain
{
    public class UserRequestDto : DtoBase
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
