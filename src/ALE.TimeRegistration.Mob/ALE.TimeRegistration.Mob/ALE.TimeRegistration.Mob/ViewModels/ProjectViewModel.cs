
using ALE.TimeRegistration.Core.Entities;
using FreshMvvm;
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

        //If taskListviewObject = null => button info = disabled
    }
}
