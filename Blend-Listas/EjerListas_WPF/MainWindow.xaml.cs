using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjerListas_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {

            //- Controlar que no falte ni el nombre ni el apellido antes de añadir. En caso de faltar uno de ellos mostrar mensaje de error.
            if (Nombre.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar el nombre");
            }
            else if (Apellido.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar el apellido");
            }
            else
            {
                String texto, texto1;
                texto = Nombre.Text;
                texto1 =Apellido.Text;
                Lista.Items.Add(texto + " " + texto1);
                Nombre.Clear();
                Apellido.Clear();
                Nombre.Focus();
            }


            

            if (Lista.Items.Count <= 20)
            {
                barra.Value = Lista.Items.Count;
                 int insertar = 20 - Lista.Items.Count;
                label.Content = "Te quedan " +  insertar + " elementos.";
            }
            if (Lista.Items.Count == 20)
            {
                MessageBox.Show("La lista esta llena");
                Nombre.IsEnabled = false;
                Apellido.IsEnabled = false;
                Boton.IsEnabled = false;
            }

        }
    }
}
