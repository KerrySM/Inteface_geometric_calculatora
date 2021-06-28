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
    public partial class Form2 : Form
    {
        String const_map3 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\okr.png";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
           
            Form1 newForm = new Form1();
            newForm.Show();
            //newForm.close
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(const_map3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okruzhnost OK1 = new okruzhnost();
            OK1.R = Convert.ToDouble(textBox1.Text);
            OK1.Sp(OK1.R);
            OK1.PP(OK1.R);
            textBox2.Text= Convert.ToString(OK1.P);
            textBox3.Text = Convert.ToString(OK1.S);
        }
    }
}
