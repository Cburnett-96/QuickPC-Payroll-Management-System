using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace csharp
{
    public partial class History : Form
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
        public History()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from calulatedhistory", sqlcon);
            DataTable dtbl = new DataTable();
            cmd.Fill(dtbl);
            dghistory.DataSource = dtbl;
            sqlcon.Close();
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
