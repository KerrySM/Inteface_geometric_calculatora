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
    public partial class Form4 : Form
    {
        String const_map5 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\trapecia.png";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(const_map5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();
            
            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox7.Text);
            double D = Convert.ToDouble(textBox8.Text);

            if (A < B)
            {
                A = Convert.ToDouble(textBox2.Text);
                B = Convert.ToDouble(textBox1.Text);
            }

                //trap.Sp(A, B);
                trap.PP(A, B,C,D);
                        textBox3.Text = Convert.ToString(trap.P);
            trap.VIS_PO_STORONAM();
            textBox5.Text = Convert.ToString(trap.H);



            //textBox6.Text = Convert.ToString(trap.S);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            trapecia trap = new trapecia();

            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox7.Text);
            double D = Convert.ToDouble(textBox8.Text);
            trap.A = A;
            trap.B = B;
            trap.C = C;
            trap.D = D;
            trap.Sp_OSN_VIS(A, B);
            textBox6.Text = Convert.ToString(trap.S);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();

            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox7.Text);
            double D = Convert.ToDouble(textBox8.Text);
            trap.A = A;
            trap.B = B;
            trap.C = C;
            trap.D = D;
            trap.Sp_SR_LIN_VIS();
            textBox9.Text = Convert.ToString(trap.S);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            trap_storon newForm = new trap_storon();
            newForm.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            traap_ugol newForm = new traap_ugol();
            newForm.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
