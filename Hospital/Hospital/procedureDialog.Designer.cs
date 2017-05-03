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
            this.acceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.acceptButton.Location = new System.Drawing.Point(11, 52);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(62, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
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
            // close
            // 
            this.close.Location = new System.Drawing.Point(92, 52);
            this.close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(62, 23);
            this.close.TabIndex = 4;
            this.close.Text = "Назад";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptButton);
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

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}