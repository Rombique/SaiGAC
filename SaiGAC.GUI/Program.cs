using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaiGAC.GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //if (args.Length == 2)
            //{
            //    string project = args[0];
            //    int gacNum = Convert.ToInt32(args[1]);
            //    string gacPath = GetGacUtil(gacNum);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        static string GetGacUtil(int num)
        {
            GACManager manager = new GACManager();
            string[] paths = manager.GetGacUtilValidPaths();
            if (paths.Length < num) throw new Exception("Gacutil под таким номером не существует.");
            return paths[num];
        }
    }
}
