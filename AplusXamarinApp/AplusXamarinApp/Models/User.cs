using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AplusXamarinApp.Data;
namespace AplusXamarinApp.Models
{
    [Table("User")]
    internal class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        [Unique]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int IDProject { get; set; }

    }
}
