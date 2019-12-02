using SQLite;
using System.Collections.Generic;

namespace SaiGAC.DAL.Entities
{
    [Table("UserPaths")]
    public class UserPath
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }
    }
}
