using ALE.TimeRegistration.Mob.Domain.Mocking;
using ALE.TimeRegistration.Mob.Domain.Services;
using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class AdminViewModel : FreshBasePageModel
    {
        private readonly IMobUserService userService;
        public AdminViewModel()
        {
            userService = new MockUsersService();
        }

        public ICommand BackToProjectPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<ProjectViewModel>();
            });

        public ICommand AddUserCommand => new Command(
            async () =>
            {
                // Add user to userList
            });

        public ICommand DeleteUserCommand => new Command(
            async () =>
            {
                // Add user to userList
            });
    }
}
