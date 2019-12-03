namespace SaiGAC.GUI
{
    partial class ManagePathsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openDllFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addPathBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pathsListBox = new System.Windows.Forms.ListBox();
            this.projectsComboBox = new System.Windows.Forms.ComboBox();
            this.projectLbl = new System.Windows.Forms.Label();
            this.pathsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openDllFileDialog
            // 
            this.openDllFileDialog.FileName = "openFileDialog1";
            // 
            // addPathBtn
            // 
            this.addPathBtn.Location = new System.Drawing.Point(109, 154);
            this.addPathBtn.Name = "addPathBtn";
            this.addPathBtn.Size = new System.Drawing.Size(200, 23);
            this.addPathBtn.TabIndex = 2;
            this.addPathBtn.Text = "Добавить";
            this.addPathBtn.UseVisualStyleBackColor = true;
            this.addPathBtn.Click += new System.EventHandler(this.AddPathBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(323, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // pathsListBox
            // 
            this.pathsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathsListBox.FormattingEnabled = true;
            this.pathsListBox.HorizontalScrollbar = true;
            this.pathsListBox.ItemHeight = 15;
            this.pathsListBox.Location = new System.Drawing.Point(109, 53);
            this.pathsListBox.Name = "pathsListBox";
            this.pathsListBox.Size = new System.Drawing.Size(414, 94);
            this.pathsListBox.TabIndex = 5;
            this.pathsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathsListBox_KeyDown);
            // 
            // projectsComboBox
            // 
            this.projectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectsComboBox.FormattingEnabled = true;
            this.projectsComboBox.Location = new System.Drawing.Point(109, 24);
            this.projectsComboBox.Name = "projectsComboBox";
            this.projectsComboBox.Size = new System.Drawing.Size(414, 23);
            this.projectsComboBox.TabIndex = 6;
            this.projectsComboBox.SelectedValueChanged += new System.EventHandler(this.ProjectsComboBox_SelectedValueChanged);
            this.projectsComboBox.TextChanged += new System.EventHandler(this.ProjectsComboBox_TextChanged);
            this.projectsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathsListBox_KeyDown);
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectLbl.Location = new System.Drawing.Point(43, 27);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(60, 15);
            this.projectLbl.TabIndex = 7;
            this.projectLbl.Text = "Проект:";
            // 
            // pathsLbl
            // 
            this.pathsLbl.AutoSize = true;
            this.pathsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathsLbl.Location = new System.Drawing.Point(12, 53);
            this.pathsLbl.Name = "pathsLbl";
            this.pathsLbl.Size = new System.Drawing.Size(91, 15);
            this.pathsLbl.TabIndex = 8;
            this.pathsLbl.Text = "Библиотеки:";
            // 
            // ManagePathsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 187);
            this.Controls.Add(this.pathsLbl);
            this.Controls.Add(this.projectLbl);
            this.Controls.Add(this.projectsComboBox);
            this.Controls.Add(this.pathsListBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addPathBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePathsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новых путей библиотек";
            this.Load += new System.EventHandler(this.ManagePathsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openDllFileDialog;
        private System.Windows.Forms.Button addPathBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox pathsListBox;
        private System.Windows.Forms.ComboBox projectsComboBox;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.Label pathsLbl;
    }
}