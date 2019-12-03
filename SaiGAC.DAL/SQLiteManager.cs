using SaiGAC.DAL.Entities;
using SaiGAC.DAL.Repositories;
using SQLite;
using System;
using System.IO;
using System.Linq;

namespace SaiGAC.DAL
{
    public class SQLiteManager
    {
        public readonly UserPathsRepository PathsRepository;
        public SQLiteManager()
        {
            string databasePath = GetDatabasePath();
            SQLiteConnection db = new SQLiteConnection(databasePath);
            db.CreateTable<UserPath>();
            PathsRepository = new UserPathsRepository(db);
        }

        public string GetDatabasePath()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').LastOrDefault();
            string path = Path.Combine(documentsPath, $"{userName}.db");

            return path;
        }
    }
}
