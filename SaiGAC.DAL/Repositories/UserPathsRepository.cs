using SaiGAC.DAL.Entities;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace SaiGAC.DAL.Repositories
{
    public class UserPathsRepository : BaseRepository<UserPath>
    {
        public UserPathsRepository(SQLiteConnection connection) : base(connection)
        {
        }

        public void AddPaths(string title, string[] paths)
        {
            IEnumerable<string> existedPaths = GetByTitle(title).Select((item) => item.Path);
            paths.Except(existedPaths).ToList().ForEach((item) => Add(new UserPath(title, item)));
        }        

        public IEnumerable<UserPath> GetByTitle(string title) => GetWhere((item) => item.Title == title);

        public IEnumerable<string> GetAllTitles() => 
            Connection.Table<UserPath>().GroupBy(e => e.Title).Select(g => g.Key);

        public void RemoveWithTitle(string title, string[] paths) =>
            GetByTitle(title).Where((item) => !paths.Contains(item.Path)).ToList()
            .ForEach((item) => Connection.Delete<UserPath>(item.Id));
    }
}
