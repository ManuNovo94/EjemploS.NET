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

namespace WPF
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

        private void altura_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rectangulo.Height = altura.Value*20;
        }

        private void anchura_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rectangulo.Width = anchura.Value * 20;
        }

        private void opacidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rectangulo.Opacity = opacidad.Value / 10;
        }
    }
}
