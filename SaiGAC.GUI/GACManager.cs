using SaiGAC.DAL;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SaiGAC.GUI
{
    class GACManager
    {
        public string CopyToGAC(string project, string gacPath)
        {
            List<string> paths = new SQLiteManager().PathsRepository.GetByTitle(project)
                .Select((item) => item.Path).ToList();
            var gacManager = new GACManager();

            var dynOutput = paths.Select((path) => gacManager.RunProcess(gacPath, path));
            return string.Join("\n", dynOutput);
        }

        public string[] GetGacUtilValidPaths()
        {
            string gacFolder = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows";
            return SearchGacUtils(gacFolder).Distinct().ToArray();
        }

        public string RunProcess(string gacUtilPath, string dllPath)
        {
            string output = string.Empty;

            using (Process gacUtil = new Process())
            {
                gacUtil.StartInfo.FileName = gacUtilPath;
                gacUtil.StartInfo.UseShellExecute = false;
                gacUtil.StartInfo.RedirectStandardOutput = true;
                gacUtil.StartInfo.CreateNoWindow = false;
                gacUtil.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                gacUtil.StartInfo.Arguments = string.Format("-i \"{0}\"", dllPath);
                gacUtil.Start();

                StreamReader reader = gacUtil.StandardOutput;
                output = reader.ReadToEnd();

                gacUtil.WaitForExit();
            }

            return output;
        }

        private IEnumerable<string> SearchGacUtils(string root)
        {
            return Directory.GetFiles(root, "gacutil.exe", SearchOption.AllDirectories).ToArray();
        }
    }
}
