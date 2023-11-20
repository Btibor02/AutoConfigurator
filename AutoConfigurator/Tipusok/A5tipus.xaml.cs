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
    /// Interaction logic for A5tipus.xaml
    /// </summary>
    public partial class A5tipus : Window
    {
        public A5tipus()
        {
            InitializeComponent();
        }

        private void választcoupe_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 12295940;
            Adatok.VálasztottTipus = "Audi A5";
            Technikai sa = new Technikai();
            sa.Show();
            this.Close();
        }

        private void választsportback_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 12295940;
            Adatok.VálasztottTipus = "Audi A5 Sportback";
            Technikai sp = new Technikai();
            sp.Show();
            this.Close();
        }

        private void választcabriolet_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg = 15150900;
            Adatok.VálasztottTipus = "Audi A5 Cabriolet";
            Technikai sw = new Technikai();
            sw.Show();
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

