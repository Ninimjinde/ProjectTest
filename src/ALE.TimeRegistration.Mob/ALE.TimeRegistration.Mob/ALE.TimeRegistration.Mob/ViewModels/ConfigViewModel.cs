using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class ConfigViewModel : FreshBasePageModel
    {
        public ConfigViewModel()
        {

        }

        private ObservableCollection<string> configLanguages;

        public ObservableCollection<string> ConfigLanguages
        {
            get { return configLanguages; }
            set
            {
                configLanguages = value;
                RaisePropertyChanged(nameof(ConfigLanguages));
            }
        }

        public ICommand OpenProjectPageCommand
        {
            get
            {
                return new Command(ExecuteOpenProjectPageCommand);
            }
        }
        private async void ExecuteOpenProjectPageCommand()
        {
            await CoreMethods.PushPageModel<ProjectViewModel>();
        }

    }
}
