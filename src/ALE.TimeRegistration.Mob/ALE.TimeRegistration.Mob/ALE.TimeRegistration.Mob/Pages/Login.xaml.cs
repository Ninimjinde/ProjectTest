using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALE.TimeRegistration.Mob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void btnFingerprintLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage()); // native app fingerprint then navigate to Projectpage if ok
        }
        private async void btnUserLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage()); //check db for user and password then navigate to Projectpage if ok
        }
    }
}