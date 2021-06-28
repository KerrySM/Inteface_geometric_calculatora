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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        String const_map1 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\triangl.png";
        private void button2_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox7.Text);

            treugolnik.PP(A, B, C);
            textBox3.Text = Convert.ToString(treugolnik.P);
            treugolnik.Sp(A, B, C);
            textBox4.Text = Convert.ToString(treugolnik.S);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            

            pictureBox1.Image = Image.FromFile(const_map1);
            pictureBox2.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\treugolnik_90.png");
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double bet = Convert.ToDouble(textBox9.Text);
            double C = Convert.ToDouble(textBox8.Text);

         
            treugolnik.kat_a_gip_cos(C,bet);
            textBox10.Text = Convert.ToString(treugolnik.a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox5.Text);
            double C = Convert.ToDouble(textBox8.Text);


            treugolnik.kat_a_gip_SIN(C, ALF);
            textBox10.Text = Convert.ToString(treugolnik.a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox5.Text);
            double B = Convert.ToDouble(textBox6.Text);


            treugolnik.kat_a_gip_SIN(B, ALF);
            textBox10.Text = Convert.ToString(treugolnik.a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double ALF = Convert.ToDouble(textBox13.Text);
            double A = Convert.ToDouble(textBox14.Text);


            treugolnik.gip_a_alf(A, ALF);
            textBox11.Text = Convert.ToString(treugolnik.c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

            double BET = Convert.ToDouble(textBox12.Text);
            double A = Convert.ToDouble(textBox14.Text);


            treugolnik.gip_a_bet(A, BET);
            textBox11.Text = Convert.ToString(treugolnik.c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();

           
            double A = Convert.ToDouble(textBox15.Text);
            double B = Convert.ToDouble(textBox16.Text);

            treugolnik.gip_po_pif(B,A);
            textBox17.Text = Convert.ToString(treugolnik.c);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            treugolnik treugolnik = new treugolnik();


            double C = Convert.ToDouble(textBox20.Text);
            double A = Convert.ToDouble(textBox19.Text);

            treugolnik.KAT_po_pif(C, A);
            textBox18.Text = Convert.ToString(treugolnik.b);
        }

        private void button10_Click(object sender, EventArgs e)
        {

           
            treug_ravb newForm = new treug_ravb();
            newForm.Show();
        }
    }
}
