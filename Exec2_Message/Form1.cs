using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
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
			string result = now.ToString() + hi;
			string value = now.ToString("yyyy/MM/dd HH:mm:ss");
			
			timeLabel.Text = result;
			MessageBox.Show(value);
		}
	}
}
