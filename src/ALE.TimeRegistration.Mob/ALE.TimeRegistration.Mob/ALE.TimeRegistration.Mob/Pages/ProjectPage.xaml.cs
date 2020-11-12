using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALE.TimeRegistration.Mob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await RefreshProjectLists();
            base.OnAppearing();
        }

        private async void BtnSettings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage());
        }

        private async void btnStart_Clicked(object sender, EventArgs e)
        {
            await StartTimer();
        }
        private async void btnInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
        private async void btnStop_Clicked(object sender, EventArgs e)
        {
            await StopTimer();
        }
        private async void btnPhoto_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //open native function camera
        }

/*        private async Task LvProjectLists_ItemTapped()
        {
            throw new NotImplementedException();
        }*/
        
        private async Task RefreshProjectLists()
        {
            throw new NotImplementedException();
        }
        private async Task StartTimer()
        {
            throw new NotImplementedException();
        }
        private async Task StopTimer()
        {
            throw new NotImplementedException();
        }
    }
}