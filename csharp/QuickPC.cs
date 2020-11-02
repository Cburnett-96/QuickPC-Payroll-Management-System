using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace csharp
{
    public partial class QuickPC : Form
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
        public QuickPC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void updatedata_Click(object sender, EventArgs e)
        {
            UpdateDB db = new UpdateDB();
            db.Show();
            this.Hide();
        }

        private void payroll_Click(object sender, EventArgs e)
        {
            Payroll pay = new Payroll();
            pay.Show();
            this.Hide();
        }

        private void payrollhistory_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
            this.Hide();
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
