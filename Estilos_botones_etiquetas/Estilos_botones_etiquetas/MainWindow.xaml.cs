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

namespace Estilos_botones_etiquetas
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

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            if (boton1.Content.ToString() == "Ocultar")
            {
                label1.Visibility = System.Windows.Visibility.Collapsed;
                boton1.Content = "Mostrar";

            }
            else if (boton1.Content.ToString() == "Mostrar")
            {
                label1.Visibility = System.Windows.Visibility.Visible;
                boton1.Content = "Ocultar";
            }
        }
        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            if (boton2.Content.ToString() == "Ocultar")
            {
                label2.Visibility = System.Windows.Visibility.Collapsed;
                boton2.Content = "Mostrar";

            }
            else if (boton2.Content.ToString() == "Mostrar")
            {
                label2.Visibility = System.Windows.Visibility.Visible;
                boton2.Content = "Ocultar";
            }
        }
        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            if (boton3.Content.ToString() == "Ocultar")
            {
                label3.Visibility = System.Windows.Visibility.Collapsed;
                boton3.Content = "Mostrar";

            }
            else if (boton3.Content.ToString() == "Mostrar")
            {
                label3.Visibility = System.Windows.Visibility.Visible;
                boton3.Content = "Ocultar";
            }
        }
        private void boton4_Click(object sender, RoutedEventArgs e)
        {
            if (boton4.Content.ToString() == "Ocultar")
            {
                label4.Visibility = System.Windows.Visibility.Collapsed;
                boton4.Content = "Mostrar";

            }
            else if (boton4.Content.ToString() == "Mostrar")
            {
                label4.Visibility = System.Windows.Visibility.Visible;
                boton4.Content = "Ocultar";
            }
        }
    }
}

