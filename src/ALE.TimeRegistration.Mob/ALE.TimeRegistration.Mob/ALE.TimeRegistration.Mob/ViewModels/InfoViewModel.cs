using ALE.TimeRegistration.Core.Entities;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class InfoViewModel : FreshBasePageModel
    {

        private AppTask currentTask;
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

            currentTask = initData as AppTask;
        }

        public ICommand BackToProjectPage => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<ProjectViewModel>();
            });

    }
}
