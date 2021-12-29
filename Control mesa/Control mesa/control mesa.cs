using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_mesa
{
    public partial class control_mesa : UserControl
    {
        public control_mesa()
        {
            InitializeComponent();

        }
        public int numMesa { get; set; }
        public int contador { get; set; }
        public void establecernumMesa(int num)
        {
            numMesa = num;
            label1.Text = "Nº" + numMesa;
        }
       
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox6.Checked == true)
            {
                checkBox6.Enabled = false;

            }
            checkBox6.Enabled = false;

            contador++;
            label2.Text = contador.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox1.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                checkBox2.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }



        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                checkBox3.Enabled = false;
                contador++;
                label2.Text = contador.ToString();

            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                checkBox4.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.Enabled = false;

                contador++;
                label2.Text = contador.ToString();
            }

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked == true)
            {
                checkBox7.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }



        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox8.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox9.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox10.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox11.Enabled = false;
                contador++;
                label2.Text = contador.ToString();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox1.Checked = false;

            checkBox2.Enabled = true;
            checkBox2.Checked = false;

            checkBox3.Enabled = true;
            checkBox3.Checked = false;

            checkBox4.Enabled = true;
            checkBox4.Checked = false;

            checkBox5.Enabled = true;
            checkBox5.Checked = false;

            checkBox6.Enabled = true;
            checkBox6.Checked = false;

            checkBox7.Enabled = true;
            checkBox7.Checked = false;

            checkBox8.Enabled = true;
            checkBox8.Checked = false;

            checkBox9.Enabled = true;
            checkBox9.Checked = false;

            checkBox10.Enabled = true;
            checkBox10.Checked = false;

            checkBox11.Enabled = true;
            checkBox11.Checked = false;

            contador = 0;
            label2.Text = "";
        }
    }
}
