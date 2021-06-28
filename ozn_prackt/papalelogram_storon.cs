using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozn_prackt
{
    public partial class papalelogram_storon : Form
    {
        public papalelogram_storon()
        {
            InitializeComponent();
        }

        private void papalelogram_storon_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\paralelogram2.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();

            
            double D1 = Convert.ToDouble(textBox6.Text);
            double D2 = Convert.ToDouble(textBox5.Text);
            double alf = Convert.ToDouble(textBox7.Text);

            parallelogram.a_po_diag_alf(D1, D2, alf);
            textBox4.Text = Convert.ToString(parallelogram.A1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();


            double D1 = Convert.ToDouble(textBox8.Text);
            double D2 = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox1.Text);

            parallelogram.a_po_diag_b(D1, D2, b);
            textBox2.Text = Convert.ToString(parallelogram.A1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();


            double H = Convert.ToDouble(textBox16.Text);
            double ALF = Convert.ToDouble(textBox13.Text);
         

            parallelogram.a_po_h_alf(H,ALF);
            textBox14.Text = Convert.ToString(parallelogram.A1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();


            double H = Convert.ToDouble(textBox11.Text);
            double S = Convert.ToDouble(textBox12.Text);


            parallelogram.a_po_S_H(S, H);
            textBox10.Text = Convert.ToString(parallelogram.A1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();


            double A = Convert.ToDouble(textBox17.Text);
            
            

            parallelogram.UG(A);
            textBox9.Text = Convert.ToString(parallelogram.L);
        }
    }
}
