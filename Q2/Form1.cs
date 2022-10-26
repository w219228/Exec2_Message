using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			timeLabel.Text = String.Empty;
		}

		private void displayButton_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;

			string hi = "嗨";
			string result = now.ToString() +"\r\n"+hi;
			timeLabel.Text = result;
			
		}
	}
}
