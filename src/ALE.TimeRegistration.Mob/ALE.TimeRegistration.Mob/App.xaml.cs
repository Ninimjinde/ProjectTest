using ALE.TimeRegistration.Mob.ViewModels;
using FreshMvvm;
using Xamarin.Forms;

namespace ALE.TimeRegistration.Mob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginViewModel>());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
