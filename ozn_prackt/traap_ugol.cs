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
    public partial class traap_ugol : Form
    {
        public traap_ugol()
        {
            InitializeComponent();
        }

        private void traap_ugol_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\trap_ug.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trapecia trap = new trapecia();

           
            double alf = Convert.ToDouble(textBox1.Text);
           
            trap.UG(alf);
            textBox2.Text = Convert.ToString(trap.L);
        }
    }
}
