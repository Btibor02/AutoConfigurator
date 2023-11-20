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
using System.Media;

namespace AutoConfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public static class Adatok
    {
        public static int Végösszeg { get; set; }
        public static int TechnikaiFelár { get; set; }
        public static int ExtrákFelár { get; set; }
        public static string VálasztottTipus { get; set; }
        public static string VálasztottMeghajtás { get; set; }
        public static string VálasztottVáltó { get; set; }
        public static string VálasztottÜzemanyag { get; set; }
        public static string VálasztottMotor { get; set; }
        public static List<string> VálasztottExtrák { get; set; }
        public static string VálasztottSzín { get; set; }

    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Adatok.Végösszeg = 0;
            Adatok.TechnikaiFelár = 0;
            Adatok.ExtrákFelár = 0;
            Adatok.VálasztottExtrák = null;

        }

        private void Választ1_Click(object sender, RoutedEventArgs e)
        {
            Tipusok.A5tipus sa = new Tipusok.A5tipus();
            sa.Show();
            this.Close();

        }
        private void Választ2_Click(object sender, RoutedEventArgs e)
        {
            Tipusok.R8tipus sr = new Tipusok.R8tipus();
            sr.Show();
            this.Close();

        }
        private void Választ3_Click(object sender, RoutedEventArgs e)
        {
            Tipusok.Q3tipus sq = new Tipusok.Q3tipus();
            sq.Show();
            this.Close();

        }

        private void Playbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Window.Width <= 700)
            {
                logo.Opacity = 0;
            }
            else
            {
                logo.Opacity = 1;
            }

        }

        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
