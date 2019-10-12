using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            if (i < 3)
            {
                ovalGreen.FillColor = Color.White;
                ovalRed.FillColor = Color.Red;

            }
            else if (i < 6 && i > 3)
            {
                ovalRed.FillColor = Color.White;
                ovalYellow.FillColor = Color.Yellow;
            }
            else if (i > 6 && i < 9)
            {
                ovalYellow.FillColor = Color.White;
                ovalGreen.FillColor = Color.Green;

            }
            else if (i > 9 && i < 12)
            {
                ovalGreen.FillColor = Color.White;
                ovalYellow.FillColor = Color.Yellow;
            }
            else if (i > 12 && i < 15)
            {
                ovalYellow.FillColor = Color.White;
                ovalRed.FillColor = Color.Red;
                i = 0;
            }
        }
    }
}
