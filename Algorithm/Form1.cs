using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label8.Text = ""; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string a = textBox1.Text;
            int x = int.Parse(a);

            string b = textBox1.Text;
            int y = int.Parse(b);

            string c = textBox1.Text;
            int z = int.Parse(c);

            string d = textBox1.Text;
            int p = int.Parse(d);

            string ee = textBox1.Text;
            int q = int.Parse(ee);


            int s = x+y;
            int s1 = x + y + z;
            int s2 = x + y + z + p;
            int s3 = x + y + z + p + q;
            //int s4 = int.Parse(c) + y;


            chart1.Series["WaitTime"].Points.AddXY(1, 0);
            chart1.Series["BurstTime"].Points.AddXY(1, x);
           
            chart1.Series["WaitTime"].Points.AddXY(2, x);
            chart1.Series["BurstTime"].Points.AddXY(2, x+y);

            chart1.Series["WaitTime"].Points.AddXY(3, x+y+y);
            chart1.Series["BurstTime"].Points.AddXY(3, x+y+z);
            
            chart1.Series["WaitTime"].Points.AddXY(4, x+y+y+z+z+z);
            chart1.Series["BurstTime"].Points.AddXY(4, x+y+z+p);

            //label8.Text = " "+(x + y + z)/2;
            


        }
    }
}
