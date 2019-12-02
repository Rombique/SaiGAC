using SaiGAC.DAL.Entities;
using SQLite;

namespace SaiGAC.DAL.Repositories
{
    public class UserPathsRepository : BaseRepository<UserPath>
    {
        public UserPathsRepository(SQLiteConnection connection) : base(connection)
        {
        }
    }
}
