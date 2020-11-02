namespace csharp
{
    partial class QuickPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickPC));
            this.updatedata = new System.Windows.Forms.Button();
            this.payroll = new System.Windows.Forms.Button();
            this.payrollhistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatedata
            // 
            this.updatedata.BackColor = System.Drawing.Color.Transparent;
            this.updatedata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatedata.BackgroundImage")));
            this.updatedata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updatedata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatedata.FlatAppearance.BorderSize = 0;
            this.updatedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatedata.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedata.Location = new System.Drawing.Point(64, 95);
            this.updatedata.Name = "updatedata";
            this.updatedata.Size = new System.Drawing.Size(166, 75);
            this.updatedata.TabIndex = 0;
            this.updatedata.Text = "Update Data";
            this.updatedata.UseVisualStyleBackColor = false;
            this.updatedata.Click += new System.EventHandler(this.updatedata_Click);
            // 
            // payroll
            // 
            this.payroll.BackColor = System.Drawing.Color.Transparent;
            this.payroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payroll.BackgroundImage")));
            this.payroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.payroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payroll.FlatAppearance.BorderSize = 0;
            this.payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payroll.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll.Location = new System.Drawing.Point(342, 95);
            this.payroll.Name = "payroll";
            this.payroll.Size = new System.Drawing.Size(166, 75);
            this.payroll.TabIndex = 1;
            this.payroll.Text = "Payroll";
            this.payroll.UseVisualStyleBackColor = false;
            this.payroll.Click += new System.EventHandler(this.payroll_Click);
            // 
            // payrollhistory
            // 
            this.payrollhistory.BackColor = System.Drawing.Color.Transparent;
            this.payrollhistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payrollhistory.BackgroundImage")));
            this.payrollhistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.payrollhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payrollhistory.FlatAppearance.BorderSize = 0;
            this.payrollhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payrollhistory.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollhistory.Location = new System.Drawing.Point(206, 200);
            this.payrollhistory.Name = "payrollhistory";
            this.payrollhistory.Size = new System.Drawing.Size(166, 75);
            this.payrollhistory.TabIndex = 2;
            this.payrollhistory.Text = "Payroll History";
            this.payrollhistory.UseVisualStyleBackColor = false;
            this.payrollhistory.Click += new System.EventHandler(this.payrollhistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUICKPC PAYROLL MANAGEMENT SYSTEM";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(488, 290);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 21);
            this.close.TabIndex = 26;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // QuickPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(572, 317);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payrollhistory);
            this.Controls.Add(this.payroll);
            this.Controls.Add(this.updatedata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuickPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatedata;
        private System.Windows.Forms.Button payroll;
        private System.Windows.Forms.Button payrollhistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
    }
}