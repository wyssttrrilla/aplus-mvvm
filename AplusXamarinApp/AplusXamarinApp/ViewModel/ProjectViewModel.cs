using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using AplusXamarinApp.Models;
using AplusXamarinApp.ViewModel;

namespace AplusXamarinApp.ViewModel
{
    public class ProjectViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ProjectListViewModel lvm;
        public Project Project { get; private set; }
        public ProjectViewModel()
        {
            Project = new Project();
        }
        public ProjectListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Project.ProjectName; }
            set
            {
                if (Project.ProjectName != value)
                {
                    Project.ProjectName = value;
                    OnPropertyChanged("Name");
                }
            }


        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())));
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
