using SaiGAC.DAL.Entities;
using SQLite;
using System;
using System.IO;
using System.Linq;

namespace SaiGAC.DAL
{
    public class SQLite
    {
        public void InitDatabase()
        {
            string databasePath = GetDatabasePath();

            using (SQLiteConnection db = new SQLiteConnection(databasePath))
            {
                db.CreateTable<UserPath>();
            }
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
