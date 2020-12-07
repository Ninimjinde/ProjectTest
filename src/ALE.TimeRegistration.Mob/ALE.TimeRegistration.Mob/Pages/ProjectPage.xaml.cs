using ALE.TimeRegistration.Mob.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALE.TimeRegistration.Mob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectViewModel = BindingContext as ProjectViewModel;
            projectViewModel.LoadTaskListCommand.Execute(e);
        }
    }
}