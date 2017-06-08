namespace Hospital
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.reports = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.reestrTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.staffTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTheProgramTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.connToTheDBTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gluingSheets = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addToDataBase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Services = new System.Windows.Forms.Button();
            this.addStaff = new System.Windows.Forms.Button();
            this.openReestr = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoFolderTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoDBTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoRowTSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reports
            // 
            this.reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.reports.Location = new System.Drawing.Point(0, 105);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(81, 35);
            this.reports.TabIndex = 1;
            this.reports.Text = "Отчеты";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTSM,
            this.settingsTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionTSM
            // 
            this.actionTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reestrTSM,
            this.staffTSM,
            this.reportsTSM,
            this.toolStripSeparator1,
            this.aboutTheProgramTSM,
            this.exitTSM});
            this.actionTSM.Name = "actionTSM";
            this.actionTSM.Size = new System.Drawing.Size(70, 20);
            this.actionTSM.Text = "Действие";
            // 
            // reestrTSM
            // 
            this.reestrTSM.Name = "reestrTSM";
            this.reestrTSM.Size = new System.Drawing.Size(149, 22);
            this.reestrTSM.Text = "Реестр";
            this.reestrTSM.Click += new System.EventHandler(this.reestrTSM_Click);
            // 
            // staffTSM
            // 
            this.staffTSM.Name = "staffTSM";
            this.staffTSM.Size = new System.Drawing.Size(149, 22);
            this.staffTSM.Text = "Штат";
            this.staffTSM.Click += new System.EventHandler(this.staffTSM_Click);
            // 
            // reportsTSM
            // 
            this.reportsTSM.Name = "reportsTSM";
            this.reportsTSM.Size = new System.Drawing.Size(149, 22);
            this.reportsTSM.Text = "Отчеты";
            this.reportsTSM.Click += new System.EventHandler(this.reportsTSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // aboutTheProgramTSM
            // 
            this.aboutTheProgramTSM.Name = "aboutTheProgramTSM";
            this.aboutTheProgramTSM.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgramTSM.Text = "О программе";
            this.aboutTheProgramTSM.Click += new System.EventHandler(this.aboutTheProgramTSM_Click);
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(149, 22);
            this.exitTSM.Text = "Выход";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click);
            // 
            // settingsTSM
            // 
            this.settingsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connToTheDBTSM,
            this.saveDirTSM});
            this.settingsTSM.Name = "settingsTSM";
            this.settingsTSM.Size = new System.Drawing.Size(79, 20);
            this.settingsTSM.Text = "Настройки";
            // 
            // connToTheDBTSM
            // 
            this.connToTheDBTSM.Name = "connToTheDBTSM";
            this.connToTheDBTSM.Size = new System.Drawing.Size(253, 22);
            this.connToTheDBTSM.Text = "Подключение к базе данных";
            this.connToTheDBTSM.Click += new System.EventHandler(this.connToTheDBTSM_Click);
            // 
            // saveDirTSM
            // 
            this.saveDirTSM.Name = "saveDirTSM";
            this.saveDirTSM.Size = new System.Drawing.Size(253, 22);
            this.saveDirTSM.Text = "Директория сохранения отчетов";
            this.saveDirTSM.Click += new System.EventHandler(this.saveDirTSM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // gluingSheets
            // 
            this.gluingSheets.Dock = System.Windows.Forms.DockStyle.Top;
            this.gluingSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gluingSheets.Location = new System.Drawing.Point(0, 140);
            this.gluingSheets.Name = "gluingSheets";
            this.gluingSheets.Size = new System.Drawing.Size(81, 35);
            this.gluingSheets.TabIndex = 9;
            this.gluingSheets.Text = "Объеденить листы";
            this.gluingSheets.UseVisualStyleBackColor = true;
            this.gluingSheets.Visible = false;
            this.gluingSheets.Click += new System.EventHandler(this.gluingSheets_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(87, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 326);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addToDataBase
            // 
            this.addToDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.addToDataBase.Location = new System.Drawing.Point(0, 35);
            this.addToDataBase.Name = "addToDataBase";
            this.addToDataBase.Size = new System.Drawing.Size(81, 35);
            this.addToDataBase.TabIndex = 11;
            this.addToDataBase.Text = "Добавить в БД";
            this.addToDataBase.UseVisualStyleBackColor = true;
            this.addToDataBase.Click += new System.EventHandler(this.addToDataBase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Services);
            this.panel1.Controls.Add(this.gluingSheets);
            this.panel1.Controls.Add(this.reports);
            this.panel1.Controls.Add(this.addStaff);
            this.panel1.Controls.Add(this.addToDataBase);
            this.panel1.Controls.Add(this.openReestr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 332);
            this.panel1.TabIndex = 12;
            // 
            // Services
            // 
            this.Services.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Services.Location = new System.Drawing.Point(0, 297);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(81, 35);
            this.Services.TabIndex = 14;
            this.Services.Text = "Услуги";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // addStaff
            // 
            this.addStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.addStaff.Location = new System.Drawing.Point(0, 70);
            this.addStaff.Name = "addStaff";
            this.addStaff.Size = new System.Drawing.Size(81, 35);
            this.addStaff.TabIndex = 13;
            this.addStaff.Text = "Штат";
            this.addStaff.UseVisualStyleBackColor = true;
            this.addStaff.Click += new System.EventHandler(this.addStaff_Click);
            // 
            // openReestr
            // 
            this.openReestr.Dock = System.Windows.Forms.DockStyle.Top;
            this.openReestr.Location = new System.Drawing.Point(0, 0);
            this.openReestr.Name = "openReestr";
            this.openReestr.Size = new System.Drawing.Size(81, 35);
            this.openReestr.TabIndex = 12;
            this.openReestr.Text = "Реестр";
            this.openReestr.UseVisualStyleBackColor = true;
            this.openReestr.Click += new System.EventHandler(this.openReestr_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoFolderTSM,
            this.infoDBTSM,
            this.infoRowTSM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoFolderTSM
            // 
            this.infoFolderTSM.Image = global::Hospital.Properties.Resources.folder;
            this.infoFolderTSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoFolderTSM.Name = "infoFolderTSM";
            this.infoFolderTSM.Size = new System.Drawing.Size(16, 17);
            this.infoFolderTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoFolderTSM.Visible = false;
            // 
            // infoDBTSM
            // 
            this.infoDBTSM.Image = global::Hospital.Properties.Resources.DB;
            this.infoDBTSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoDBTSM.Name = "infoDBTSM";
            this.infoDBTSM.Size = new System.Drawing.Size(884, 17);
            this.infoDBTSM.Spring = true;
            this.infoDBTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoRowTSM
            // 
            this.infoRowTSM.Margin = new System.Windows.Forms.Padding(0);
            this.infoRowTSM.Name = "infoRowTSM";
            this.infoRowTSM.Size = new System.Drawing.Size(0, 0);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionTSM;
        private System.Windows.Forms.ToolStripMenuItem reestrTSM;
        private System.Windows.Forms.Button gluingSheets;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addToDataBase;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openReestr;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoFolderTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportsTSM;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramTSM;
        private System.Windows.Forms.Button addStaff;
        private System.Windows.Forms.ToolStripMenuItem staffTSM;
        private System.Windows.Forms.ToolStripMenuItem settingsTSM;
        private System.Windows.Forms.ToolStripMenuItem connToTheDBTSM;
        private System.Windows.Forms.ToolStripMenuItem saveDirTSM;
        public System.Windows.Forms.ToolStripStatusLabel infoDBTSM;
        private System.Windows.Forms.ToolStripStatusLabel infoRowTSM;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Services;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

