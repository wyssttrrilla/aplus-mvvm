using SQLite;


namespace AplusXamarinApp.Models
{
    [Table("Project")]
    public class Project
    {
            [PrimaryKey, AutoIncrement, Column("_id")]
            [Unique]
            public int Id { get; set; }
            public string ProjectName { get; set; }
            public string ProjectTitle { get; set; }
            public string ProjectPicture { get; set; }
            public string ProjectEmail { get; set; }
            public string ProjectAddress { get; set; }
            public string ProjectPhone { get; set; }
              
    }
}
