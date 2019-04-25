using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delightful_Cakes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripProgressBar1.Value = 100;
            toolStripStatusLabel1.Text = "Fuel Amount:";
        }

        private void ToolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {                     
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {         
            if (toolStripProgressBar1.Value - 10 >= 0)
            {
                toolStripProgressBar1.Value -= 10;
                if (toolStripProgressBar1.Value == 0)
                {
                    MessageBox.Show("RAN OUT OF FUEL");
                }
            }
            else if (toolStripProgressBar1.Value - 10 < 0)
            {
                MessageBox.Show("RAN OUT OF FUEL");
            }
            
        }
    }
}
