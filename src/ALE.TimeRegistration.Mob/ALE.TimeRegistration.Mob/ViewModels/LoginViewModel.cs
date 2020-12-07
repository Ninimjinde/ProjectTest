using ALE.TimeRegistration.Mob.Domain.Mocking;
using ALE.TimeRegistration.Mob.Domain.Services;
using FreshMvvm;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class LoginViewModel : FreshBasePageModel
    {
        private readonly IMobUserService userService;
        public LoginViewModel()
        {
            userService = new MockUsersService();
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        private bool userIsNotOK;

        public bool UserIsNotOk
        {
            get { return userIsNotOK; }
            set
            {
                userIsNotOK = value;
                RaisePropertyChanged(nameof(UserIsNotOk));
            }
        }



        public ICommand LoginPasswordCommand
        {
            get
            {
                var command = new Command(ExecuteLoginPasswordCommand);
                return command;
            }
        }

        private async void ExecuteLoginPasswordCommand()
        {
            try
            {
                if (await userService.Login(Email, Password))
                {
                    if (await userService.IsAdmin(Email, Password))
                    {
                        await CoreMethods.PushPageModel<AdminViewModel>();
                        userIsNotOK = false;
                    }
                    else
                    {
                        await CoreMethods.PushPageModel<ProjectViewModel>();
                        userIsNotOK = false;
                    }
                }

            }
            catch (Exception)
            {
                UserIsNotOk = true;
            }


        }

    }
}
