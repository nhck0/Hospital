namespace Hospital
{
    partial class procedure
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procedure));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.saveReports = new System.Windows.Forms.Button();
            this.updateReports = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoSaveDirTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoTableTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoErrorTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.actionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWinTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTheProgramTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveChanges);
            this.panel1.Controls.Add(this.saveReports);
            this.panel1.Controls.Add(this.updateReports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 418);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить и распечатать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveChanges.Location = new System.Drawing.Point(0, 72);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(81, 35);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // saveReports
            // 
            this.saveReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveReports.Location = new System.Drawing.Point(0, 37);
            this.saveReports.Name = "saveReports";
            this.saveReports.Size = new System.Drawing.Size(81, 35);
            this.saveReports.TabIndex = 2;
            this.saveReports.Text = "Сохранить отчеты";
            this.saveReports.UseVisualStyleBackColor = true;
            this.saveReports.Click += new System.EventHandler(this.saveReports_Click);
            // 
            // updateReports
            // 
            this.updateReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateReports.Location = new System.Drawing.Point(0, 0);
            this.updateReports.Name = "updateReports";
            this.updateReports.Size = new System.Drawing.Size(81, 37);
            this.updateReports.TabIndex = 0;
            this.updateReports.Text = "Обновить отчеты";
            this.updateReports.UseVisualStyleBackColor = true;
            this.updateReports.Click += new System.EventHandler(this.updateReports_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoSaveDirTSM,
            this.infoTSM,
            this.infoTableTSM,
            this.infoErrorTSM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoSaveDirTSM
            // 
            this.infoSaveDirTSM.Image = global::Hospital.Properties.Resources.save;
            this.infoSaveDirTSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoSaveDirTSM.Name = "infoSaveDirTSM";
            this.infoSaveDirTSM.Size = new System.Drawing.Size(16, 17);
            // 
            // infoTSM
            // 
            this.infoTSM.Name = "infoTSM";
            this.infoTSM.Size = new System.Drawing.Size(451, 17);
            this.infoTSM.Spring = true;
            this.infoTSM.Tag = "";
            this.infoTSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoTableTSM
            // 
            this.infoTableTSM.Name = "infoTableTSM";
            this.infoTableTSM.Size = new System.Drawing.Size(451, 17);
            this.infoTableTSM.Spring = true;
            this.infoTableTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoErrorTSM
            // 
            this.infoErrorTSM.Name = "infoErrorTSM";
            this.infoErrorTSM.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(87, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 415);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Посещения по врачам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(833, 383);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(839, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Нормативы мед помощи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(839, 389);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(839, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Услуги амбулаторной хирургии";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(839, 389);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(839, 389);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Посещения по отделениям";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(839, 389);
            this.dataGridView5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(839, 389);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Диспансеризация";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(839, 389);
            this.dataGridView6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(839, 389);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Ошибки";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(833, 383);
            this.dataGridView7.TabIndex = 0;
            // 
            // actionTSM
            // 
            this.actionTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWinTSM,
            this.saveReportsTSM,
            this.openDirTSM,
            this.toolStripSeparator1,
            this.aboutTheProgramTSM,
            this.exitTSM});
            this.actionTSM.Name = "actionTSM";
            this.actionTSM.Size = new System.Drawing.Size(70, 20);
            this.actionTSM.Text = "Действие";
            // 
            // mainWinTSM
            // 
            this.mainWinTSM.Name = "mainWinTSM";
            this.mainWinTSM.Size = new System.Drawing.Size(256, 22);
            this.mainWinTSM.Text = "Главное окно";
            this.mainWinTSM.Click += new System.EventHandler(this.mainWinTSM_Click);
            // 
            // saveReportsTSM
            // 
            this.saveReportsTSM.Name = "saveReportsTSM";
            this.saveReportsTSM.Size = new System.Drawing.Size(256, 22);
            this.saveReportsTSM.Text = "Сохранить отчеты";
            this.saveReportsTSM.Click += new System.EventHandler(this.saveReportsTSM_Click);
            // 
            // openDirTSM
            // 
            this.openDirTSM.Name = "openDirTSM";
            this.openDirTSM.Size = new System.Drawing.Size(256, 22);
            this.openDirTSM.Text = "Открыть директорию с отчетами";
            this.openDirTSM.Click += new System.EventHandler(this.openDirTSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // aboutTheProgramTSM
            // 
            this.aboutTheProgramTSM.Name = "aboutTheProgramTSM";
            this.aboutTheProgramTSM.Size = new System.Drawing.Size(256, 22);
            this.aboutTheProgramTSM.Text = "О программе";
            this.aboutTheProgramTSM.Click += new System.EventHandler(this.aboutTheProgramTSM_Click);
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(256, 22);
            this.exitTSM.Text = "Выход";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTSM,
            this.settingsTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsTSM
            // 
            this.settingsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDirTSM});
            this.settingsTSM.Name = "settingsTSM";
            this.settingsTSM.Size = new System.Drawing.Size(79, 20);
            this.settingsTSM.Text = "Настройки";
            // 
            // saveDirTSM
            // 
            this.saveDirTSM.Name = "saveDirTSM";
            this.saveDirTSM.Size = new System.Drawing.Size(253, 22);
            this.saveDirTSM.Text = "Директория сохранения отчетов";
            this.saveDirTSM.Click += new System.EventHandler(this.saveDirTSM_Click);
            // 
            // procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "procedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчеты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.procedure_FormClosing);
            this.Load += new System.EventHandler(this.procedure_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateReports;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button saveReports;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.DataGridView dataGridView6;
        public System.Windows.Forms.DataGridView dataGridView7;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.ToolStripStatusLabel infoErrorTSM;
        public System.Windows.Forms.ToolStripStatusLabel infoTSM;
        public System.Windows.Forms.ToolStripStatusLabel infoTableTSM;
        public System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.ToolStripMenuItem actionTSM;
        private System.Windows.Forms.ToolStripMenuItem mainWinTSM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem saveReportsTSM;
        public System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramTSM;
        private System.Windows.Forms.ToolStripStatusLabel infoSaveDirTSM;
        private System.Windows.Forms.ToolStripMenuItem settingsTSM;
        private System.Windows.Forms.ToolStripMenuItem saveDirTSM;
        private System.Windows.Forms.ToolStripMenuItem openDirTSM;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TabPage tabPage3;
    }
}