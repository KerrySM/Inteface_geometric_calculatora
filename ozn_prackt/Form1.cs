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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        String const_map3 = "C:\\Users\\sdd\\source\\repos\\ozn_prackt\\okr.png";
       
        

        private void button1_Click(object sender, EventArgs e)
        {


            //pictureBox1.Image = Image.FromFile("C:\\Users\\sdd\\source\\repos\\ozn_prackt\\Screenshot_1.png");



            //label1.Text = comboBox1.Text;
            String str = comboBox1.Text;
            if (str == "Окружность")
            {

                Hide();
                Form2 newForm = new Form2();
                newForm.ShowDialog(this);
            }



            else if (str == "Прямоугольник")
            {
                Hide();
                Form3 newForm = new Form3();
                newForm.ShowDialog(this);

            }
            else if (str == "Треугольник")
            {
                Hide();
                Form6 newForm = new Form6();
                newForm.ShowDialog(this);
            }
            else if (str == "Параллелограмм")
            {


                Hide();
                Form5 newForm = new Form5();
                newForm.ShowDialog(this);
                //
            }
            else if (str == "Трапеция")
            {

                Hide();
                Form4 newForm = new Form4();
                newForm.ShowDialog(this);

               
            }


            /*
             * Окружность
             * 
             * 
            okruzhnost OK1 = new okruzhnost();
            OK1.R = 5;
            OK1.Sp(5);
            OK1.PP(5);
            label1.Text = Convert.ToString(OK1.P);
    */

            // treugolnik TREG = new treugolnik();
            //TREG.A = 5;
            // TREG.B = 5;
            //TREG.C = 5;

            /*ПЛОЩАДЬ ТРЕУГОЛЬНИКА
                        TREG.Sp(5,5,5);
                        label1.Text = Convert.ToString(TREG.S);

                */
            /*ПЕРЕМИТР*/
            // TREG.PP(5, 5, 5);
            // label1.Text = Convert.ToString(TREG.P);



            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Окружность", "Прямоугольник", "Треугольник", "Трапеция", "Параллелограмм" });
            comboBox1.SelectedIndex = 0;
        }
    }
}
