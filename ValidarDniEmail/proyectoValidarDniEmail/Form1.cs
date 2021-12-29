using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StandardValidarDni;

namespace proyectoValidarDniEmail
{
    public partial class Form1 : Form
    {
        Class1 objeto = new Class1();
        String valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void email_Click(object sender, EventArgs e)
        {

            if (objeto.validarEmail(cajaEmail.Text))
            {
                MessageBox.Show("Es email Correcto");
               
            }
            else
            {
                MessageBox.Show("El email es Incorrecto.");
            }
            cajaEmail.Text = "";
            cajaEmail.Focus();
        }

        private void dni_Click(object sender, EventArgs e)
        {
            if (objeto.ValidarDNI(cajaDni.Text))
            {
                MessageBox.Show("Es DNI correcto");
            }
            else
            {
                MessageBox.Show("El DNI es incorrecto.");
            }
            cajaDni.Text = "";
            cajaDni.Focus();
        }

        private void cajaEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
