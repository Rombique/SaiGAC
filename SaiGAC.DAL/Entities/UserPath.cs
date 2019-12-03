using SQLite;
using System.Collections.Generic;

namespace SaiGAC.DAL.Entities
{
    [Table("UserPaths")]
    public class UserPath
    {
        public UserPath()
        {
        }

        public UserPath(string title, string path)
        {
            Title = title;
            Path = path;
        }

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }
    }
}
