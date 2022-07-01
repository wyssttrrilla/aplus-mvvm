using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplusXamarinApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;
using AplusXamarinApp.transfer;
using AplusXamarinApp.Data;
using AplusXamarinApp.Models;


namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPeojectPage : ContentPage
    {
        public List<string> LVProjectsName { get; set; }
        public SelectPeojectPage()
        {
            InitializeComponent();
            
        } //TEXT = "&#X"
        private async void AddProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectAdd());
        }
        protected override void OnAppearing()
        {
            LVProject.ItemsSource = App.Db.GetItems();
            base.OnAppearing();
            BindingContext = new ProjectListViewModel() { Navigation = this.Navigation };
        }
        private void UpdateList()
        {
            LVProject.ItemsSource = App.Db.GetItems();
        }

        private async void LVProject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            SelectedProjectPage selectedProjectPage = new SelectedProjectPage();
            selectedProjectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(selectedProjectPage);
        }
    }
}