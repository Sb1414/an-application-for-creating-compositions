using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creatingCompositions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            trackBar1.Value = (int)Class1.Red;
            trackBar2.Value = (int)Class1.Green;
            trackBar3.Value = (int)Class1.Blue;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            /*
            Class1.Red = trackBar1.Value;
            Class1.Green = trackBar2.Value;
            Class1.Blue = trackBar3.Value;
            */
            MessageBox.Show(Class1.Red.ToString(), Class1.Green.ToString());
            this.Close();
        }
    }
}
