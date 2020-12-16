using ALE.TimeRegistration.Mob.Domain.Mocking;
using ALE.TimeRegistration.Mob.Domain.Services;
using ALE.TimeRegistration.Mob.ViewModels;
using FreshMvvm;
using Xamarin.Forms;
using XrnCourse.BucketList.Domain.Services.Local;

namespace ALE.TimeRegistration.Mob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IAppSettingsService>(new JsonAppSettingsService());
            FreshIOC.Container.Register<IMobUserService>(new MockUsersService());

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
