
using ALE.TimeRegistration.Core.Entities;
using FreshMvvm;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class ProjectViewModel : FreshBasePageModel
    {
        public ProjectViewModel()
        {
            
        }

        public ICommand OpenProjectCommand {
            get {
                return new Command<Project>(ExecuteOpenProjectCommand);
            }
        }

        private async void ExecuteOpenProjectCommand(Project project)
        {
            await CoreMethods.PushPageModel<InfoViewModel>(project, false, true);
        }

        private DateTime dateToday;

        public DateTime DateToday
        {
            get { return dateToday; }
            set { dateToday = DateTime.Today;
                RaisePropertyChanged(nameof(DateToday)); }
        }


        //If taskListviewObject = null => button info = disabled
    }
}
