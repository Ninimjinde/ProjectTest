using ALE.TimeRegistration.Mob.Domain.Services;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class LoginViewModel : FreshBasePageModel
    {
        private readonly IUserService _userService;
        public LoginViewModel(IUserService userService)
        {
            _userService = userService;
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


        public ICommand LoginPasswordCommand
        {
            get {
                var command = new Command(ExecuteLoginPasswordCommand);
                return command;
            }
        }

        private async void ExecuteLoginPasswordCommand()
        {
            if (await _userService.Login(Email, Password))
            {
                 await CoreMethods.PushPageModel<ProjectViewModel>();
            }
            else
            {
                // Send message or show label that email or password is wrong
            }
        }

    }
}
