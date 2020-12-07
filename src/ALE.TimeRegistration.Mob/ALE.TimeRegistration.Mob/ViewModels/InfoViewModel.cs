using ALE.TimeRegistration.Mob.Domain;
using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class InfoViewModel : FreshBasePageModel
    {

        private AppTaskResponseDto currentTask;
        public InfoViewModel()
        {
            this.TaskName = currentTask.TaskName;
            this.TaskInfo = currentTask.Info;
        }

        #region properties

        private string taskName;

        public string TaskName
        {
            get { return taskName; }
            set
            {
                taskName = value;
                RaisePropertyChanged(nameof(TaskName));
            }
        }

        private string taskInfo;

        public string TaskInfo
        {
            get { return taskInfo; }
            set
            {
                taskInfo = value;
                RaisePropertyChanged(nameof(TaskInfo));
            }
        }

        #endregion

        public override void Init(object initData)
        {
            base.Init(initData);

            currentTask = initData as AppTaskResponseDto;
        }

        public ICommand BackToProjectPage => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<ProjectViewModel>();
            });

    }
}
