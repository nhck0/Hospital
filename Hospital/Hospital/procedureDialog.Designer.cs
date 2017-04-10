namespace Hospital
{
    partial class procedureDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procedureDialog));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(11, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчет за:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // procedureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 80);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "procedureDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновление";
            this.Load += new System.EventHandler(this.procedureDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}