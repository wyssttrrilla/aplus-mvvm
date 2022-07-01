using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AplusXamarinApp.Page;
using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Data;
using AplusXamarinApp.Models;

namespace AplusXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BLogin_Clicked(object sender, EventArgs e)
        {
           

            await Navigation.PushAsync(new SelectPeojectPage());
            

        }

        private async void BRegistration_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
            
        }
    }
}
