namespace csharp
{
    partial class UpdateDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDB));
            this.newaccount = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.idnum = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.Address = new System.Windows.Forms.TextBox();
            this.Emailadd = new System.Windows.Forms.TextBox();
            this.Phonenum = new System.Windows.Forms.TextBox();
            this.Jobposition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newaccount
            // 
            this.newaccount.BackColor = System.Drawing.Color.Transparent;
            this.newaccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newaccount.BackgroundImage")));
            this.newaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newaccount.FlatAppearance.BorderSize = 0;
            this.newaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newaccount.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccount.Location = new System.Drawing.Point(63, 343);
            this.newaccount.Name = "newaccount";
            this.newaccount.Size = new System.Drawing.Size(102, 38);
            this.newaccount.TabIndex = 0;
            this.newaccount.Text = "Create New Account";
            this.newaccount.UseVisualStyleBackColor = false;
            this.newaccount.Click += new System.EventHandler(this.newaccount_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(288, 343);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 38);
            this.update.TabIndex = 1;
            this.update.Text = "Update Account";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // idnum
            // 
            this.idnum.Location = new System.Drawing.Point(126, 51);
            this.idnum.MaxLength = 4;
            this.idnum.Name = "idnum";
            this.idnum.Size = new System.Drawing.Size(92, 20);
            this.idnum.TabIndex = 2;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(126, 105);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(92, 20);
            this.Firstname.TabIndex = 3;
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(224, 105);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(92, 20);
            this.Middlename.TabIndex = 4;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(322, 105);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(92, 20);
            this.Lastname.TabIndex = 5;
            // 
            // bday
            // 
            this.bday.CustomFormat = "";
            this.bday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bday.Location = new System.Drawing.Point(126, 142);
            this.bday.Name = "bday";
            this.bday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bday.Size = new System.Drawing.Size(92, 20);
            this.bday.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(126, 178);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(288, 20);
            this.Address.TabIndex = 7;
            // 
            // Emailadd
            // 
            this.Emailadd.Location = new System.Drawing.Point(126, 299);
            this.Emailadd.Name = "Emailadd";
            this.Emailadd.Size = new System.Drawing.Size(190, 20);
            this.Emailadd.TabIndex = 8;
            // 
            // Phonenum
            // 
            this.Phonenum.Location = new System.Drawing.Point(126, 216);
            this.Phonenum.Name = "Phonenum";
            this.Phonenum.Size = new System.Drawing.Size(190, 20);
            this.Phonenum.TabIndex = 9;
            // 
            // Jobposition
            // 
            this.Jobposition.FormattingEnabled = true;
            this.Jobposition.Items.AddRange(new object[] {
            "Store Manager",
            "Accountant/Cashier",
            "Technician",
            "Clerk",
            "Delivery"});
            this.Jobposition.Location = new System.Drawing.Point(126, 260);
            this.Jobposition.Name = "Jobposition";
            this.Jobposition.Size = new System.Drawing.Size(190, 21);
            this.Jobposition.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "BirthDate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Current Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Job Position:";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Transparent;
            this.find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("find.BackgroundImage")));
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.FlatAppearance.BorderSize = 0;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(241, 49);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 21;
            this.find.Text = "Find";
            this.toolTip1.SetToolTip(this.find, "Find for Old/Previous ID Number");
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(177, 343);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(97, 38);
            this.menu.TabIndex = 22;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(366, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 21);
            this.close.TabIndex = 23;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Staff Account";
            // 
            // UpdateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(448, 404);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.close);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jobposition);
            this.Controls.Add(this.Phonenum);
            this.Controls.Add(this.Emailadd);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.idnum);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newaccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newaccount;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox idnum;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.DateTimePicker bday;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Emailadd;
        private System.Windows.Forms.TextBox Phonenum;
        private System.Windows.Forms.ComboBox Jobposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label11;
    }
}