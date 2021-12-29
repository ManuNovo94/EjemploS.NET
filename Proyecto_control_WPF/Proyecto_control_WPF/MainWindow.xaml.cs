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

namespace Proyecto_control_WPF
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

        private void contacto_Loaded(object sender, RoutedEventArgs e)
        {
          
            
           
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (almacen.IsChecked==true)
            {
                contacto.botones(1);
            }
            if (oficina.IsChecked==true)
            {
                contacto.botones(2);
            }
            if (tienda.IsChecked==true)
            {
                contacto.botones(3);
            }

        }
    }
}
