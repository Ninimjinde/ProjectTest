using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALE.TimeRegistration.Mob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
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