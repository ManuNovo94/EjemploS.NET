using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanasDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            
            if (Open.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                    textBox1.Visible = false;
                openFileDialog1.ShowDialog();
                String directorio = openFileDialog1.FileName;
                Caja.Text = directorio;
                label.Text = "Fichero Seleccionado";
                }
                else
                {
                    Caja.Text = "Fichero no encontrado";
                }
}
            if (save.Checked)
            {
                textBox1.Visible = false;
                saveFileDialog1.ShowDialog();
                label.Text = "Fichero Seleccionada";
            }
            if (folder.Checked)
            {
                textBox1.Visible = false;
                folderBrowserDialog1.ShowDialog();
                Caja.Text = folderBrowserDialog1.SelectedPath; ;
            }
            if (color.Checked)
            {
                colorDialog1.ShowDialog();
                label.Text = "Texto del color";
                Caja.Text = "Ejemplo de color seleccionado";
                textBox1.Visible = true;
                textBox1.BackColor = colorDialog1.Color;
                Caja.ForeColor = colorDialog1.Color;
            }
            if (font.Checked)
            {
                textBox1.Visible = false;
                fontDialog1.ShowDialog();
                Caja.Text = "Ejemplo de Texto Seleccionado";
                Caja.Font = fontDialog1.Font;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
