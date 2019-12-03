using SaiGAC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaiGAC.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] projects = new SQLiteManager().PathsRepository.GetAllTitles().ToArray();
            projectsBox.Items.AddRange(projects);
            if (projectsBox.Items.Count > 0)
                projectsBox.SelectedIndex = 0;

            GACManager gacManager = new GACManager();
            string[] gacPaths = gacManager.GetGacUtilValidPaths();
            gacPathsBox.Items.AddRange(GetPathsItems(gacPaths));
            if (gacPathsBox.Items.Count > 0)
                gacPathsBox.SelectedIndex = 0;
        }

        private object[] GetPathsItems(string[] gacPaths)
        {
            return gacPaths.Select((i) => new { Display = i.Substring(46), Value = i }).ToArray();
        }

        private void СhangeConfBtn_Click(object sender, EventArgs e)
        {
            ManagePathsForm form = new ManagePathsForm();
            form.ShowDialog();
        }

        private void СopyToGacBtn_Click(object sender, EventArgs e)
        {
            List<string> paths = new SQLiteManager().PathsRepository.GetByTitle(projectsBox.Text)
                .Select((item) => item.Path).ToList();
            GACManager gacManager = new GACManager();
            dynamic selectedItem = gacPathsBox.SelectedItem;
            
            var dynOutput = paths.Select((path) => gacManager.RunProcess(selectedItem.Value, path));
            string output = string.Join("\n", dynOutput);
            logBox.AppendText(output);
        }
    }
}
