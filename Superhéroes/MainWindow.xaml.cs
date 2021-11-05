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

namespace Superhéroes
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

       

        private void FlechaAdelantar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int primernumero = int.Parse(Texto1TextBlock.Text);
            int tercernumero = int.Parse(Texto3TextBlock.Text);

            if (primernumero < tercernumero)
            {
                primernumero++;
                Texto1TextBlock.Text = primernumero.ToString();
            }
        }

        private void FlecharetrocesoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int primernumero = int.Parse(Texto1TextBlock.Text);

            if (primernumero > 1)
            {
                primernumero--;
                Texto1TextBlock.Text = primernumero.ToString();
            }
        }
    }
}
