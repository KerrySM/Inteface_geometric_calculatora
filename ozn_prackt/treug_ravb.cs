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
    public partial class treug_ravb : Form
    {
        public treug_ravb()
        {
            InitializeComponent();
        }

        private void treug_ravb_Load(object sender, EventArgs e)

        {

            pictureBox2.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\treug_ravnobed.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\ugly_treug.png");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox9.Text);
            double a = Convert.ToDouble(textBox8.Text);

            
            treugolnik.b_sin(a, ALF);
            textBox7.Text = Convert.ToString(treugolnik.b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox9.Text);
            double a = Convert.ToDouble(textBox8.Text);


            treugolnik.b_cos(a, ALF);
            textBox7.Text = Convert.ToString(treugolnik.b);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox12.Text);
            double b = Convert.ToDouble(textBox11.Text);
            double BET = Convert.ToDouble(textBox10.Text);

            treugolnik.a_sin(b, BET);
            textBox13.Text = Convert.ToString(treugolnik.a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox12.Text);
            double b = Convert.ToDouble(textBox11.Text);
            double BET = Convert.ToDouble(textBox10.Text);

            treugolnik.a_cos(b, BET);
            textBox13.Text = Convert.ToString(treugolnik.a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox12.Text);
            double b = Convert.ToDouble(textBox11.Text);
            double BET = Convert.ToDouble(textBox10.Text);

            treugolnik.a_cos_bet(b, ALF);
            textBox13.Text = Convert.ToString(treugolnik.a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double A = Convert.ToDouble(textBox3.Text);
            double B = Convert.ToDouble(textBox1.Text);
            double C = Convert.ToDouble(textBox2.Text);

            treugolnik.UG(A, B, C);
            textBox6.Text = Convert.ToString(treugolnik.alf);
            textBox4.Text = Convert.ToString(treugolnik.bet);
            textBox5.Text = Convert.ToString(treugolnik.gam);
        }
    }
}
