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
            this.nameServerBT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameDataBaseBT = new System.Windows.Forms.TextBox();
            this.checkConnection = new System.Windows.Forms.Button();
            this.loginBT = new System.Windows.Forms.TextBox();
            this.passBT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // nameServerBT
            // 
            this.nameServerBT.Location = new System.Drawing.Point(15, 25);
            this.nameServerBT.Name = "nameServerBT";
            this.nameServerBT.Size = new System.Drawing.Size(171, 20);
            this.nameServerBT.TabIndex = 1;
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
            // nameDataBaseBT
            // 
            this.nameDataBaseBT.Location = new System.Drawing.Point(15, 64);
            this.nameDataBaseBT.Name = "nameDataBaseBT";
            this.nameDataBaseBT.Size = new System.Drawing.Size(171, 20);
            this.nameDataBaseBT.TabIndex = 3;
            // 
            // checkConnection
            // 
            this.checkConnection.Location = new System.Drawing.Point(54, 129);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(85, 36);
            this.checkConnection.TabIndex = 4;
            this.checkConnection.Text = "Проверить подключение";
            this.checkConnection.UseVisualStyleBackColor = true;
            this.checkConnection.Click += new System.EventHandler(this.checkConnection_Click);
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(15, 103);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(84, 20);
            this.loginBT.TabIndex = 5;
            // 
            // passBT
            // 
            this.passBT.Location = new System.Drawing.Point(105, 103);
            this.passBT.Name = "passBT";
            this.passBT.PasswordChar = '*';
            this.passBT.Size = new System.Drawing.Size(81, 20);
            this.passBT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Логин:";
            // 
            // sqlDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBT);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.nameDataBaseBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameServerBT);
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
        public System.Windows.Forms.TextBox nameServerBT;
        public System.Windows.Forms.TextBox nameDataBaseBT;
        private System.Windows.Forms.Button checkConnection;
        public System.Windows.Forms.TextBox loginBT;
        public System.Windows.Forms.TextBox passBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}