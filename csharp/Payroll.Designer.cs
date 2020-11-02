namespace csharp
{
    partial class Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idnum = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.incometax = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jobposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthpay = new System.Windows.Forms.TextBox();
            this.holidayworkhr = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overtimepay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.absences = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdeduct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(159, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff ID Number:";
            // 
            // idnum
            // 
            this.idnum.Location = new System.Drawing.Point(159, 68);
            this.idnum.MaxLength = 4;
            this.idnum.Name = "idnum";
            this.idnum.Size = new System.Drawing.Size(112, 20);
            this.idnum.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(151, 98);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.toolTip1.SetToolTip(this.Search, "Search your ID in Database");
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // incometax
            // 
            this.incometax.AutoSize = true;
            this.incometax.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incometax.Location = new System.Drawing.Point(151, 338);
            this.incometax.Name = "incometax";
            this.incometax.Size = new System.Drawing.Size(109, 19);
            this.incometax.TabIndex = 11;
            this.incometax.Text = "Taxable Income";
            this.toolTip1.SetToolTip(this.incometax, "Taxable Income = (Monthly Basic Pay + Additional Pay) – \r\n(SSS + PhilHealth + PAG" +
        "-IBIG)");
            this.incometax.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Position:";
            // 
            // jobposition
            // 
            this.jobposition.Enabled = false;
            this.jobposition.Location = new System.Drawing.Point(159, 165);
            this.jobposition.Name = "jobposition";
            this.jobposition.Size = new System.Drawing.Size(186, 20);
            this.jobposition.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly Basic Pay:";
            // 
            // monthpay
            // 
            this.monthpay.Location = new System.Drawing.Point(159, 235);
            this.monthpay.Name = "monthpay";
            this.monthpay.Size = new System.Drawing.Size(112, 20);
            this.monthpay.TabIndex = 8;
            this.monthpay.Text = "0";
            // 
            // holidayworkhr
            // 
            this.holidayworkhr.AutoSize = true;
            this.holidayworkhr.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayworkhr.Location = new System.Drawing.Point(284, 236);
            this.holidayworkhr.Name = "holidayworkhr";
            this.holidayworkhr.Size = new System.Drawing.Size(99, 19);
            this.holidayworkhr.TabIndex = 10;
            this.holidayworkhr.Text = "Holiday work";
            this.holidayworkhr.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculate.BackgroundImage")));
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.FlatAppearance.BorderSize = 0;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(92, 433);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(101, 37);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // salary
            // 
            this.salary.Enabled = false;
            this.salary.Location = new System.Drawing.Point(159, 392);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(112, 20);
            this.salary.TabIndex = 14;
            this.salary.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Deduction:";
            // 
            // overtimepay
            // 
            this.overtimepay.Location = new System.Drawing.Point(159, 263);
            this.overtimepay.Name = "overtimepay";
            this.overtimepay.Size = new System.Drawing.Size(112, 20);
            this.overtimepay.TabIndex = 16;
            this.overtimepay.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Overtime Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Absences/Tardiness Hours:";
            // 
            // absences
            // 
            this.absences.Location = new System.Drawing.Point(159, 311);
            this.absences.Name = "absences";
            this.absences.Size = new System.Drawing.Size(112, 20);
            this.absences.TabIndex = 18;
            this.absences.Text = "0";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(159, 197);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(99, 20);
            this.date.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Current Date:";
            // 
            // txtdeduct
            // 
            this.txtdeduct.Enabled = false;
            this.txtdeduct.Location = new System.Drawing.Point(159, 363);
            this.txtdeduct.Name = "txtdeduct";
            this.txtdeduct.Size = new System.Drawing.Size(112, 20);
            this.txtdeduct.TabIndex = 22;
            this.txtdeduct.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Deduction Total:";
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
            this.close.Location = new System.Drawing.Point(317, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 21);
            this.close.TabIndex = 25;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.menu.Location = new System.Drawing.Point(236, 432);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(97, 38);
            this.menu.TabIndex = 24;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(115, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Payroll Account";
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(404, 499);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.close);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdeduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.absences);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.overtimepay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.incometax);
            this.Controls.Add(this.holidayworkhr);
            this.Controls.Add(this.monthpay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jobposition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.idnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idnum;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monthpay;
        private System.Windows.Forms.CheckBox holidayworkhr;
        private System.Windows.Forms.CheckBox incometax;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox overtimepay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox absences;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdeduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label11;
    }
}