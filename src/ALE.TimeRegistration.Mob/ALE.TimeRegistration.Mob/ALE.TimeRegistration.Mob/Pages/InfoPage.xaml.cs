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
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void btnProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage());
        }
        private async void btnQuestion_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(); // send question 
        }
    }
}