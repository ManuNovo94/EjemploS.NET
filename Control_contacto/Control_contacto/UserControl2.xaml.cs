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

namespace Control_contacto
{
    /// <summary>
    /// Lógica de interacción para UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public int opcion { get; set; }

        public void botones(int opc){

            opcion = opc;
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (opcion == 1)
            {
                Window1 formulario = new Window1();
                formulario.ShowDialog();
            }
            if (opcion == 2)
            {
                Window2 formulario = new Window2();
                formulario.ShowDialog();
            }
            if (opcion == 3)
            {
                Window3 formulario = new Window3();
                formulario.ShowDialog();
            }
        }
    }
}
