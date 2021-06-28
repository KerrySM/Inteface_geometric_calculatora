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
    public partial class Form3 : Form
    {
        String const_map2 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\pram.png";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            Form1 newForm= new Form1();
            newForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(const_map2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pramougolnic pram = new pramougolnic();
            //  pram.R = Convert.ToDouble(textBox1.Text);
            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            pram.Sp(A, B);
            pram.PP(A, B);
            textBox3.Text = Convert.ToString(pram.c);
            textBox4.Text = Convert.ToString(pram.b);


            textBox5.Text = Convert.ToString(pram.P);
            textBox6.Text = Convert.ToString(pram.S);
        }
    }
}
