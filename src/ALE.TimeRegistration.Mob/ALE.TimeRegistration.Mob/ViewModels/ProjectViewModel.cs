
using ALE.TimeRegistration.Mob.Domain;
using ALE.TimeRegistration.Mob.Domain.Mocking;
using ALE.TimeRegistration.Mob.Domain.Services;
using FreshMvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob.ViewModels
{
    public class ProjectViewModel : FreshBasePageModel
    {
        private readonly IMobProjectService projectService;
        private readonly IMobTaskService taskService;
        public ProjectViewModel()
        {
            projectService = new MockProjectsService();
            taskService = new MockTasksService();

            this.DateToday = DateTime.UtcNow.ToShortDateString();
        }

        #region properties


        private string dateToday;

        public string DateToday
        {
            get { return dateToday; }
            set
            {
                dateToday = value;
                RaisePropertyChanged(nameof(DateToday));
            }
        }

        private ProjectResponseDto selectedProject;

        public ProjectResponseDto SelectedProject
        {
            get { return selectedProject; }
            set
            {
                selectedProject = value;
                RaisePropertyChanged(nameof(SelectedProject));
                //refresh list of tasks
            }
        }

        private AppTaskResponseDto selectedTask;

        public AppTaskResponseDto SelectedTask
        {
            get { return selectedTask; }
            set
            {
                selectedTask = value;
                RaisePropertyChanged(nameof(SelectedTask));
            }
        }

        private ObservableCollection<ProjectResponseDto> projects;

        public ObservableCollection<ProjectResponseDto> Projects
        {
            get { return projects; }
            set
            {
                projects = value;
                RaisePropertyChanged(nameof(Projects));

            }
        }

        private ObservableCollection<AppTaskResponseDto> tasks;

        public ObservableCollection<AppTaskResponseDto> Tasks
        {
            get { return tasks; }
            set
            {
                tasks = value;
                RaisePropertyChanged(nameof(Tasks));
            }
        }


        #endregion

        protected async override void ViewIsAppearing(object sender, EventArgs e) // altijd oprgeroepen
        {
            base.ViewIsAppearing(sender, e);

            LoadProjectList();

            //await EnsureUserAndSettings();

            //await RefreshBucketLists();
        }

        public override void Init(object initData) // enkel in voorwaartse beweging
        {
            base.Init(initData);
            
        }

        public ICommand OpenConfigPageCommand => new Command(
        async () =>
        {
            await CoreMethods.PushPageModel<ConfigViewModel>();
        });


        public ICommand GetInfoTaskCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<InfoViewModel>(SelectedTask, false, true);
            });

        public ICommand LoadTaskListCommand => new Command(
            async () =>
            {
                try
                {
                    Tasks = new ObservableCollection<AppTaskResponseDto>(await taskService.ListAllTasksFromProject(SelectedProject));
                }
                catch (Exception)
                {
                    //Errormessage choose Project
                }

            });

        private async void LoadProjectList()
        {
            Projects = new ObservableCollection<ProjectResponseDto>(await projectService.ListAll());
        }

        //If taskListviewObject = null => button info = disabled
    }
}

