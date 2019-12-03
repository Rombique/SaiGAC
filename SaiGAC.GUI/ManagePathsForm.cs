using SaiGAC.DAL;
using SaiGAC.DAL.Entities;
using SaiGAC.DAL.Repositories;
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
    public partial class ManagePathsForm : Form
    {
        private readonly SQLiteManager sqliteManager;
        public ManagePathsForm()
        {
            InitializeComponent();
            sqliteManager = new SQLiteManager();
            openDllFileDialog.Filter = "Dll files(*.dll)|*.dll|All files(*.*)|*.*";
        }

        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            if (NoProjectNameCheckError() == 1)
                return;

            if (openDllFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openDllFileDialog.FileName;
            pathsListBox.Items.Add(filename);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NoProjectNameCheckError() == 1)
                return;

            if (pathsListBox.Items.Count == 0)
            {
                MessageBox.Show("Пожалуйста, заполните пути до библиотек", "Не заполнены пути до библиотек", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqliteManager.PathsRepository.RemoveWithTitle(projectsComboBox.Text, pathsListBox.Items.OfType<string>().ToArray());
            sqliteManager.PathsRepository.AddPaths(projectsComboBox.Text, pathsListBox.Items.OfType<string>().ToArray());
            this.Close();
        }

        private void ProjectsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdatePaths();
        }

        private void ManagePathsForm_Load(object sender, EventArgs e)
        {
            string[] projects = sqliteManager.PathsRepository.GetAllTitles().ToArray();
            projectsComboBox.Items.AddRange(projects);
        }

        private void ProjectsComboBox_TextChanged(object sender, EventArgs e)
        {
            pathsListBox.Items.Clear();
            if (projectsComboBox.Items.Contains(projectsComboBox.Text))
                UpdatePaths();   
        }

        private void UpdatePaths()
        {
            string[] paths = sqliteManager.PathsRepository.GetByTitle(projectsComboBox.Text)
                .Select((item) => item.Path).ToArray();
            pathsListBox.Items.Clear();
            pathsListBox.Items.AddRange(paths);
        }

        private void PathsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                pathsListBox.Items.RemoveAt(pathsListBox.SelectedIndex);
        }

        private int NoProjectNameCheckError()
        {
            if (projectsComboBox.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, заполните название проекта", "Не заполнено название проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            return 0;
        }
    }
}
