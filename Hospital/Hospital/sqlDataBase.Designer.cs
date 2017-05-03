namespace Hospital
{
    partial class sqlDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sqlDataBase));
            this.label1 = new System.Windows.Forms.Label();
            this.nameServerTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameDataBaseTB = new System.Windows.Forms.TextBox();
            this.checkConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера:";
            // 
            // nameServerTB
            // 
            this.nameServerTB.Location = new System.Drawing.Point(15, 25);
            this.nameServerTB.Name = "nameServerTB";
            this.nameServerTB.Size = new System.Drawing.Size(157, 20);
            this.nameServerTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя базы данных:";
            // 
            // nameDataBaseTB
            // 
            this.nameDataBaseTB.Location = new System.Drawing.Point(15, 64);
            this.nameDataBaseTB.Name = "nameDataBaseTB";
            this.nameDataBaseTB.Size = new System.Drawing.Size(157, 20);
            this.nameDataBaseTB.TabIndex = 3;
            // 
            // checkConnection
            // 
            this.checkConnection.Location = new System.Drawing.Point(47, 90);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(85, 36);
            this.checkConnection.TabIndex = 4;
            this.checkConnection.Text = "Проверить подключение";
            this.checkConnection.UseVisualStyleBackColor = true;
            this.checkConnection.Click += new System.EventHandler(this.checkConnection_Click);
            // 
            // sqlDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 133);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.nameDataBaseTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameServerTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sqlDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к БД";
            this.Load += new System.EventHandler(this.sqlDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nameServerTB;
        public System.Windows.Forms.TextBox nameDataBaseTB;
        private System.Windows.Forms.Button checkConnection;
    }
}