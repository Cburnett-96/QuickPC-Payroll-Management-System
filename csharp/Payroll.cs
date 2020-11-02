using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace csharp
{
	public partial class Payroll : Form
    {
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
		int nLeftRect,     // x-coordinate of upper-left corner
		int nTopRect,      // y-coordinate of upper-left corner
		int nRightRect,    // x-coordinate of lower-right corner
		int nBottomRect,   // y-coordinate of lower-right corner
		int nWidthEllipse, // height of ellipse
		int nHeightEllipse // width of ellipse
		);
		SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\new\_\Programming\csharp_cpp\quickpc.mdf; Integrated Security = True; Connect Timeout = 30");
		const string dllfile = "D:\\new\\_\\Programming\\csharp_cpp\\Debug\\cppdll.dll";
		public Payroll()
        {
            InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}
        private void Search_Click(object sender, EventArgs e)
        {
			if (idnum.Text != "")
			{
				sqlcon.Open();
				SqlCommand cmd = new SqlCommand("Select * from quickpctbl where IdNumber = @IdNumber", sqlcon);
				cmd.Parameters.AddWithValue("@IdNumber", int.Parse(idnum.Text));
				SqlDataReader da = cmd.ExecuteReader();
				while (da.Read())
				{
					name.Text = da.GetValue(1).ToString();
					jobposition.Text = da.GetValue(7).ToString();
				}
			sqlcon.Close();
				if (idnum.Text != "@IdNumber")
				{
					MessageBox.Show("No Previous Data!");
				}
			}
			else
			{
				MessageBox.Show("Please Input");
			}
		}
		[DllImport(dllfile, CallingConvention = CallingConvention.Cdecl)]
		public static extern double holiday(double a);

		[DllImport(dllfile, CallingConvention = CallingConvention.Cdecl)]
		public static extern double incometaxes(double a, double b, double c);

		[DllImport(dllfile, CallingConvention = CallingConvention.Cdecl)]
		public static extern double total(double a, double b, double c);
		[DllImport(dllfile, CallingConvention = CallingConvention.Cdecl)]
		public static extern double totaldeduction(double a, double b, double c);
		private void calculate_Click(object sender, EventArgs e)
        {
			double totalsalary = 0;
			double a = Convert.ToDouble(monthpay.Text);
			double b = Convert.ToDouble(overtimepay.Text);
			double c = Convert.ToDouble(absences.Text);
			double z = incometaxes(a, b, c);
			double all = total(a, b, c) - int.Parse(monthpay.Text);
			double holtotal = holiday(a);
			double deduction = totaldeduction(a, b, c);
			if (idnum.Text != "")
			{
				if (holidayworkhr.Checked == true)
				{
					totalsalary += holtotal;
				}
				if (incometax.Checked == true)
				{
					totalsalary += z;
				}
				if (incometax.Checked == true && holidayworkhr.Checked == true)
				{
					totalsalary += all;
				}
				salary.Text = totalsalary.ToString();
				txtdeduct.Text = deduction.ToString();

				//Auto Added data calculated into database
				sqlcon.Open();
				string query = "Insert into calulatedhistory VALUES('" + idnum.Text.Trim() + "','" + name.Text.Trim() + "','" + jobposition.Text.Trim() + "','" + date.Text.Trim() + "','" + monthpay.Text.Trim() + "','" + overtimepay.Text.Trim() + "','" + absences.Text.Trim() + "','" + salary.Text.Trim() + "','" + txtdeduct.Text.Trim() + "')";
				SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
				DataTable dtbl = new DataTable();
				sda.Fill(dtbl);
				sqlcon.Close();
			}
			else
			{
				MessageBox.Show("Please Input");
			}
		}
		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void menu_Click(object sender, EventArgs e)
		{
			QuickPC pc = new QuickPC();
			pc.Show();
			this.Close();
		}
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
						m.Result = (IntPtr)0x2;
					return;
			}
			base.WndProc(ref m);
		}
	}
}