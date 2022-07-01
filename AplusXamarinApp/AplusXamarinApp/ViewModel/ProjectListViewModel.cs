using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;
using AplusXamarinApp.Page;
using AplusXamarinApp.Page.SecondSprint;

namespace AplusXamarinApp.ViewModel
{
    public class ProjectListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ProjectViewModel> Projects { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CreateCommand { protected set; get; }
        public ICommand DeleteCommand { protected set; get; }
        public ICommand SaveCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        ProjectViewModel selectedProject;
        public INavigation Navigation { get; set; }
        public ProjectListViewModel()
        {
            Projects = new ObservableCollection<ProjectViewModel>();
            CreateCommand = new Command(CreateProject);
            DeleteCommand = new Command(DeleteProject);
            SaveCommand = new Command(SaveProject);
            BackCommand = new Command(Back);
        }

        public ProjectViewModel SelectedFriend
        {
            get { return selectedProject; }
            set
            {
                if (selectedProject != value)
                {
                    ProjectViewModel tempFriend = value;
                    selectedProject = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new ProjectAdd());
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateProject()
        {
            Navigation.PushAsync(new ProjectAdd());
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveProject(object friendObject)
        {
            ProjectViewModel friend = friendObject as ProjectViewModel;
            if (friend != null && friend.IsValid && !Projects.Contains(friend))
            {
                Projects.Add(friend);
            }
            Back();
        }
        private void DeleteProject(object friendObject)
        {
            ProjectViewModel friend = friendObject as ProjectViewModel;
            if (friend != null)
            {
                Projects.Remove(friend);
            }
            Back();
        }
    }
}
