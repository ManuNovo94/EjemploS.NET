using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MenusContra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          


            if (contador <3)
            {
                if (textContra.Text.Equals("hola"))
                {
                    pictureBox2.Visible = true;
                    groupBox1.Visible = false;
                    toolStrip1.Enabled = true;

                }
                else contador = contador+1;
            }
            else Application.Exit();

        }
            private void textUsuario_TextChanged(object sender, EventArgs e)
            {

            }

            private void textContra_TextChanged(object sender, EventArgs e)
            {
                textContra.PasswordChar = '*';
            }
        }
    }


