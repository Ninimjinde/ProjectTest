﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALE.TimeRegistration.Mob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        /*        protected async override void OnAppearing()
                {
                    base.OnAppearing();
                }*/
        private async void btnProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage());
        }
        /*        private async void btnAddUser_Clicked(object sender, EventArgs e)
                {
                    throw new NotImplementedException();
                }
                private async void btnAddProject_Clicked(object sender, EventArgs e)
                {
                    throw new NotImplementedException();
                }
                private async void btnDeleteUser_Clicked(object sender, EventArgs e)
                {
                    throw new NotImplementedException();
                }
                private async void btnSendMessage_Clicked(object sender, EventArgs e)
                {
                    throw new NotImplementedException();
                }*/
    }
}