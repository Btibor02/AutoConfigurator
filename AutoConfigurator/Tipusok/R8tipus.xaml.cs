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
using System.Windows.Shapes;

namespace AutoConfigurator.Tipusok
{
    /// <summary>
    /// Interaction logic for R8tipus.xaml
    /// </summary>
    public partial class R8tipus : Window
    {
        public R8tipus()
        {
            InitializeComponent();
        }

        private void választr8_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 63037670;
            Adatok.VálasztottTipus = "Audi R8";
            Technikai sa = new Technikai();
            sa.Show();
            this.Close();
        }

        private void választr8spyder_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 68370400;
            Adatok.VálasztottTipus = "Audi R8 Spyder";
            Technikai sp = new Technikai();
            sp.Show();
            this.Close();
        }

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            MainWindow vi = new MainWindow();
            vi.Show();
            this.Close();
            
        }

        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
