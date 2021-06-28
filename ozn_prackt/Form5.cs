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
    public partial class Form5 : Form
    {
        String const_map4 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\parallelogram.png";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(const_map4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();

            double A = Convert.ToDouble(textBox1.Text);
            double H = Convert.ToDouble(textBox2.Text);




            parallelogram.Sp_PO_VIS(A, H);
            textBox3.Text = Convert.ToString(parallelogram.S);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();

            double D1 = Convert.ToDouble(textBox6.Text);
            double D2 = Convert.ToDouble(textBox5.Text);
            double ALF = Convert.ToDouble(textBox7.Text);




            parallelogram.Sp_PO_DIAG(D1, D2, ALF);
            textBox4.Text = Convert.ToString(parallelogram.S);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            parallelogram parallelogram = new parallelogram();

            double a = Convert.ToDouble(textBox11.Text);
            double b = Convert.ToDouble(textBox10.Text);
            double ALF = Convert.ToDouble(textBox8.Text);




            parallelogram.Sp_PO_ULGU_STORON(a, b, ALF);
            textBox9.Text = Convert.ToString(parallelogram.S);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();

            double a = Convert.ToDouble(textBox15.Text);
            double b = Convert.ToDouble(textBox14.Text);
           
                        
            parallelogram.PP(a, b);
            textBox13.Text = Convert.ToString(parallelogram.P);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parallelogram parallelogram = new parallelogram();

            double a = Convert.ToDouble(textBox17.Text);
            double D1 = Convert.ToDouble(textBox16.Text);
            double D2 = Convert.ToDouble(textBox18.Text);


            parallelogram.P_D(a, D1,D2);
            textBox12.Text = Convert.ToString(parallelogram.P);
        }

        private void button7_Click(object sender, EventArgs e)
        {


            papalelogram_storon newForm = new papalelogram_storon();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
