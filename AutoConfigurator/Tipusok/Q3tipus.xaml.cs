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
    /// Interaction logic for Q3tipus.xaml
    /// </summary>
    
    public partial class Q3tipus : Window
    {

        public Q3tipus()
        {
            InitializeComponent();
        }

        private void választq3_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 10552340;
            Adatok.VálasztottTipus = "Audi Q3";
            Technikai sa = new Technikai();
            sa.Show();
            this.Close();
        }

        private void választq3sportback_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 11037480;
            Adatok.VálasztottTipus = "Audi Q3 Sportback";
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
