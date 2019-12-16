using SaiGAC.DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SaiGAC.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void SetProjectBoxItems()
        {
            projectsBox.Items.Clear();
            string[] projects = new SQLiteManager().PathsRepository.GetAllTitles().ToArray();
            projectsBox.Items.AddRange(projects);
            if (projectsBox.Items.Count > 0)
                projectsBox.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetProjectBoxItems();
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
            using (ManagePathsForm form = new ManagePathsForm())
            {
                form.ShowDialog(this);
            }
        }

        private void СopyToGacBtn_Click(object sender, EventArgs e)
        {
            GACManager gacManager = new GACManager();
            dynamic selectedItem = gacPathsBox.SelectedItem;
            string output = gacManager.CopyToGAC(projectsBox.Text, selectedItem.Value);
            logBox.AppendText(output);
        }
    }
}
