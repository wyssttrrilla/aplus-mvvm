using System;
using System.Text;
using System.Collections.Generic;
using SQLite;
using AplusXamarinApp.Models;
using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;
using AplusXamarinApp.Data;

namespace AplusXamarinApp.Data
{
    internal class ProjectBD
    {
        SQLiteConnection db;
        public ProjectBD(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Project>();
        }

        public IEnumerable<Project> GetItems()
        {
            return db.Table<Project>().ToList();
        }

        public Project GetItem(int id)
        {
            return db.Get<Project>(id);
        }

        public int DeleteItem(int id)
        {
            return db.Delete<Project>(id);
        }

        public int SaveItem(Project item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }
    }
}
