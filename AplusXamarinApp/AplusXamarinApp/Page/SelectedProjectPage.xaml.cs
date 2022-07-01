using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;
using AplusXamarinApp.transfer;
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;


namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        public SelectedProjectPage()
        {
            InitializeComponent();
            
        }

        private async void TEditing_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            ProjectEdit projectPage = new ProjectEdit();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }
    }
    
}