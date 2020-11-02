using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace csharp
{
	public partial class UpdateDB : Form
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
		public UpdateDB()
        {
            InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}
		SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\new\_\Programming\csharp_cpp\quickpc.mdf; Integrated Security = True; Connect Timeout = 30");
		private void find_Click(object sender, EventArgs e)
		{
			if (idnum.Text != "")
			{
				sqlcon.Open();
				SqlCommand cmd = new SqlCommand("Select * from quickpctbl where IdNumber = @IdNumber", sqlcon);
				cmd.Parameters.AddWithValue("@IdNumber", int.Parse(idnum.Text));
				SqlDataReader da = cmd.ExecuteReader();
				while (da.Read())
				{
					Firstname.Text = da.GetValue(1).ToString();
					Middlename.Text = da.GetValue(2).ToString();
					Lastname.Text = da.GetValue(3).ToString();
					bday.Text = da.GetValue(4).ToString();
					Address.Text = da.GetValue(5).ToString();
					Phonenum.Text = da.GetValue(6).ToString();
					Jobposition.Text = da.GetValue(7).ToString();
					Emailadd.Text = da.GetValue(8).ToString();
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
		private void newaccount_Click(object sender, EventArgs e)
		{
			if (Firstname.Text != "" && Lastname.Text != "" && Middlename.Text != "" && bday.Text != "" && Address.Text != "" && Phonenum.Text != "" && Jobposition.Text != "" && Emailadd.Text != "")
			{
				string query = "Insert into quickpctbl VALUES('" + idnum.Text.Trim() + "','" + Firstname.Text.Trim() + "','" + Middlename.Text.Trim() + "','" + Lastname.Text.Trim() + "','" + bday.Text.Trim() + "','" + Address.Text.Trim() + "','" + Phonenum.Text.Trim() + "','" + Jobposition.Text.Trim() + "','" + Emailadd.Text.Trim() + "')";
				SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
				DataTable dtbl = new DataTable();
				sda.Fill(dtbl);
				MessageBox.Show("Successfuly Added!");
				idnum.Clear();
				Firstname.Clear();
				Middlename.Clear();
				Lastname.Clear();
				bday.Text = String.Empty;
				Address.Clear();
				Phonenum.Clear();
				Jobposition.Text = String.Empty;
				Emailadd.Clear();
			}
			else
			{
				MessageBox.Show("Please Input!");
			}
		}
		private void update_Click(object sender, EventArgs e)
		{
			if (Firstname.Text != "" && Lastname.Text != "" && Middlename.Text != "" && bday.Text != "" && Address.Text != "" && Phonenum.Text != "" && Jobposition.Text != "" && Emailadd.Text != "")
			{
				sqlcon.Close();
				string query = "Update quickpctbl Set Fname ='" + Firstname.Text.Trim() + "', Mname ='" + Middlename.Text.Trim() + "', Lname ='" + Lastname.Text.Trim() + "', Birthday ='" + bday.Text.Trim() + "', Address ='" + Address.Text.Trim() + "', PhoneNumber ='" + Phonenum.Text.Trim() + "', JobPosition ='" + Jobposition.Text.Trim() + "', EmailAddress ='" + Emailadd.Text.Trim() + "' where IdNumber = '" + idnum.Text.Trim() + "'";
				SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
				DataTable dtbl = new DataTable();
				sda.Fill(dtbl);

				MessageBox.Show("Successfuly Update!");
			}
			else
			{
				MessageBox.Show("Please Input!");
			}
			idnum.Clear();
			Firstname.Clear();
			Middlename.Clear();
			Lastname.Clear();
			bday.Text = String.Empty;
			Address.Clear();
			Phonenum.Clear();
			Jobposition.Text = String.Empty;
			Emailadd.Clear();
		}
		private void menu_Click(object sender, EventArgs e)
		{
			QuickPC pc = new QuickPC();
			pc.Show();
			this.Close();
		}
		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
