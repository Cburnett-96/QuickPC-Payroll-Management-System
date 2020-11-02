
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace csharp
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		[DllImport("cppdll.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int add(int a, int b);
		private void button1_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(textBox1.Text);
			int b = Convert.ToInt32(textBox2.Text);
			int z = add(a, b);
			MessageBox.Show("Required Answer is " + Convert.ToString(z), "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			QuickPC q = new QuickPC();
			q.Show();
			this.Hide();
		}
	}
}
