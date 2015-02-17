using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostHearth
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AlphaSlider.Value = 10;
		}

		private void FloatButton_Click(object sender, EventArgs e)
		{
			StatusLabel.Text = HSWindowManager.FloatHS(1);
		}

		private void UnfloatButton_Click(object sender, EventArgs e)
		{
			StatusLabel.Text = HSWindowManager.FloatHS(0);
		}

		private void AlphaSlider_Scroll(object sender, EventArgs e)
		{
			//StatusLabel.Text = AlphaSlider.Value.ToString();
			StatusLabel.Text = HSWindowManager.SetHSAlpha(AlphaSlider.Value);
		}


	}
}
