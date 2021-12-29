using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            listView1.Columns.Add("Clave",75);
            listView1.Columns.Add("Usuario",75);

            listView2.Columns.Add("Clave",75);
            listView2.Columns.Add("Usuario",75);
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (boton1.Checked)
            {
                string[] arr1 = new string[4];
                ListViewItem itm1;

                arr1[0] =clave.Text;
                arr1[1] = usuario.Text; 
                itm1 = new ListViewItem(arr1);
                listView1.Items.Add(itm1);
            }

            if (boton2.Checked )
            {
                string[] arr2 = new string[4];
                ListViewItem itm2;

                arr2[0] = clave.Text;
                arr2[1] = usuario.Text;
                itm2 = new ListViewItem(arr2);
                listView2.Items.Add(itm2);
                }
            
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem seleccion in listView1.SelectedItems)
            {
                seleccion.Remove();
            }

            foreach (ListViewItem seleccion2 in listView2.SelectedItems)
            {
                seleccion2.Remove();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            if (boton1.Checked)
            {
                listView1.Items.Clear();
            }
            if (boton2.Checked)
            {
                listView2.Items.Clear();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
