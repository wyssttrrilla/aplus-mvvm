using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using AplusXamarinApp.Page;
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;

namespace AplusXamarinApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Project.db";
        internal static ProjectBD db;
        internal static ProjectBD Db
        {
            get
            {
                if (db == null)
                {
                    db = new ProjectBD(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
