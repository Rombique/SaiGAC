namespace SaiGAC.GUI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gacPathsBox = new System.Windows.Forms.ComboBox();
            this.projectsBox = new System.Windows.Forms.ComboBox();
            this.gacutilLbl = new System.Windows.Forms.Label();
            this.projectLbl = new System.Windows.Forms.Label();
            this.changeConfBtn = new System.Windows.Forms.Button();
            this.copyToGacBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.logLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gacPathsBox
            // 
            this.gacPathsBox.DisplayMember = "Display";
            this.gacPathsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gacPathsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gacPathsBox.FormattingEnabled = true;
            this.gacPathsBox.Location = new System.Drawing.Point(74, 14);
            this.gacPathsBox.Name = "gacPathsBox";
            this.gacPathsBox.Size = new System.Drawing.Size(380, 24);
            this.gacPathsBox.TabIndex = 0;
            this.gacPathsBox.ValueMember = "Value";
            // 
            // projectsBox
            // 
            this.projectsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectsBox.FormattingEnabled = true;
            this.projectsBox.Location = new System.Drawing.Point(74, 44);
            this.projectsBox.Name = "projectsBox";
            this.projectsBox.Size = new System.Drawing.Size(380, 23);
            this.projectsBox.TabIndex = 1;
            // 
            // gacutilLbl
            // 
            this.gacutilLbl.AutoSize = true;
            this.gacutilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gacutilLbl.Location = new System.Drawing.Point(12, 17);
            this.gacutilLbl.Name = "gacutilLbl";
            this.gacutilLbl.Size = new System.Drawing.Size(56, 15);
            this.gacutilLbl.TabIndex = 2;
            this.gacutilLbl.Text = "Gacutil:";
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectLbl.Location = new System.Drawing.Point(8, 47);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(60, 15);
            this.projectLbl.TabIndex = 3;
            this.projectLbl.Text = "Проект:";
            // 
            // changeConfBtn
            // 
            this.changeConfBtn.Location = new System.Drawing.Point(74, 73);
            this.changeConfBtn.Name = "changeConfBtn";
            this.changeConfBtn.Size = new System.Drawing.Size(187, 23);
            this.changeConfBtn.TabIndex = 4;
            this.changeConfBtn.Text = "Редактировать конфигурацию";
            this.changeConfBtn.UseVisualStyleBackColor = true;
            this.changeConfBtn.Click += new System.EventHandler(this.СhangeConfBtn_Click);
            // 
            // copyToGacBtn
            // 
            this.copyToGacBtn.Location = new System.Drawing.Point(267, 73);
            this.copyToGacBtn.Name = "copyToGacBtn";
            this.copyToGacBtn.Size = new System.Drawing.Size(187, 23);
            this.copyToGacBtn.TabIndex = 5;
            this.copyToGacBtn.Text = "Копировать сборки";
            this.copyToGacBtn.UseVisualStyleBackColor = true;
            this.copyToGacBtn.Click += new System.EventHandler(this.СopyToGacBtn_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(74, 102);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(380, 188);
            this.logBox.TabIndex = 6;
            this.logBox.Text = "";
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLbl.Location = new System.Drawing.Point(34, 102);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(34, 15);
            this.logLbl.TabIndex = 7;
            this.logLbl.Text = "Лог:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 307);
            this.Controls.Add(this.logLbl);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.copyToGacBtn);
            this.Controls.Add(this.changeConfBtn);
            this.Controls.Add(this.projectLbl);
            this.Controls.Add(this.gacutilLbl);
            this.Controls.Add(this.projectsBox);
            this.Controls.Add(this.gacPathsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaiGAC";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gacPathsBox;
        private System.Windows.Forms.ComboBox projectsBox;
        private System.Windows.Forms.Label gacutilLbl;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.Button changeConfBtn;
        private System.Windows.Forms.Button copyToGacBtn;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label logLbl;
    }
}

