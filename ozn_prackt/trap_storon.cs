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
    public partial class trap_storon : Form
    {
        public trap_storon()
        {
            InitializeComponent();
        }

        private void trap_storon_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\trap_r1.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\trap_r2.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\trap_r3.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();

            double A = Convert.ToDouble(textBox1.Text);
            double M = Convert.ToDouble(textBox2.Text);
            trap.OSNOV_PO_SR_LINE(A, M);
           
            
            textBox3.Text = Convert.ToString(trap.otvet);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            trapecia trap = new trapecia();

            double A = Convert.ToDouble(textBox7.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double alf = Convert.ToDouble(textBox6.Text);
            double bet = Convert.ToDouble(textBox4.Text);
            trap.OPREDELENIE_STORON_PO_A(alf, bet, A, h);


            textBox9.Text = Convert.ToString(trap.C);
            textBox10.Text = Convert.ToString(trap.D);
            textBox8.Text = Convert.ToString(trap.B);



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();

            double B = Convert.ToDouble(textBox8.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double alf = Convert.ToDouble(textBox6.Text);
            double bet = Convert.ToDouble(textBox4.Text);
            trap.OPREDELENIE_STORON_PO_B(alf, bet, B, h);


            textBox9.Text = Convert.ToString(trap.C);
            textBox10.Text = Convert.ToString(trap.D);
            textBox7.Text = Convert.ToString(trap.A);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            trapecia trap = new trapecia();

            double A = Convert.ToDouble(textBox12.Text);
            double h = Convert.ToDouble(textBox15.Text);
            double alf = Convert.ToDouble(textBox14.Text);
            double d1 = Convert.ToDouble(textBox16.Text);
            double d2 = Convert.ToDouble(textBox17.Text);
            trap.OPREDELENIE_STORON_PO_DIAGONALI_I_A(alf, A, h, d1, d2);
            textBox11.Text = Convert.ToString(trap.B);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();

            double B = Convert.ToDouble(textBox11.Text);
            double h = Convert.ToDouble(textBox15.Text);
            double alf = Convert.ToDouble(textBox14.Text);
            double d1 = Convert.ToDouble(textBox16.Text);
            double d2 = Convert.ToDouble(textBox17.Text);
            trap.OPREDELENIE_STORON_PO_DIAGONALI_I_B(alf, B, h, d1, d2);
            textBox12.Text = Convert.ToString(trap.A);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
