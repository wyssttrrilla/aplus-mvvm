using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AplusXamarinApp.Models;
using AplusXamarinApp.Data;
using AplusXamarinApp.transfer;

namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectEdit : ContentPage
    {
        public ProjectEdit()
        {
            InitializeComponent();
        }
        
        private async void BChange_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите изменить {project.ProjectName}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.ProjectName))
                {
                    App.Db.SaveItem(project);
                }
                await Navigation.PushAsync(new SelectPeojectPage());
            }
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();  
        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы точно хотите удалить {project.ProjectName}?", "Удалить", "Отмена"))
            {
                App.Db.DeleteItem(project.Id);
                await Navigation.PushAsync(new SelectPeojectPage());
            }
        }
    }
}