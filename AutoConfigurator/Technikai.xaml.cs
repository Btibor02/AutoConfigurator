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
using System.Globalization;

namespace AutoConfigurator
{
    /// <summary>
    /// Interaction logic for Technikai.xaml
    /// </summary>
    public partial class Technikai : Window
    {
        int helyiVégösszeg = Adatok.Végösszeg - Adatok.TechnikaiFelár - Adatok.ExtrákFelár;
        int motorfelár = 0;
        int meghajtásfelár = 0;
        int váltófelár = 0;
        int üzemanyagfelár = 0;
        
        public Technikai()
        {
            InitializeComponent();
            ÖsszegVáltozás();
        }
        private void ÖsszegVáltozás()
        {
            // int kiírandó = helyiVégösszeg + motorfelár;
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";
            //string formatted = kiírandó.ToString("#,0.00", nfi);

            string kiírandó = (helyiVégösszeg + motorfelár + meghajtásfelár + váltófelár + üzemanyagfelár).ToString("#,0", nfi);

            végösszegki.Content = $"{kiírandó} Ft";
        }
        
        private void Elsőkerék_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMeghajtás = "Elsőkerék";
            meghajtásfelár = 0;
            ÖsszegVáltozás();
        }

        private void Quatro_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMeghajtás = "Quatro";
            meghajtásfelár = 2456180;
            ÖsszegVáltozás();
        }

        private void Kézi_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottVáltó = "Kézi";
            váltófelár = 0;
            ÖsszegVáltozás();
        }

        private void Automata_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottVáltó = "Automata";
            váltófelár = 806450;
            ÖsszegVáltozás();
        }

        private void Benzin_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottÜzemanyag = "Benzin";
            üzemanyagfelár = 0;
            ÖsszegVáltozás();
        }
        private void Diesel_Click(object sender, RoutedEventArgs e)
        {
            BenzinMotor.Visibility = Visibility.Collapsed;
            DízelMotor.Visibility = Visibility.Visible;
            MotorDízel1.IsChecked = true;
            Adatok.VálasztottMotor = "TDI 1,4 l 66kW";

        }

        private void Benzin_Click(object sender, RoutedEventArgs e)
        {
            BenzinMotor.Visibility = Visibility.Visible;
            DízelMotor.Visibility = Visibility.Collapsed;
            Motor1.IsChecked = true;
            Adatok.VálasztottMotor = "R4 16v TSI 2,4 l";
        }

        private void Diesel_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottÜzemanyag = "Diesel";
            üzemanyagfelár = 1483360;
            ÖsszegVáltozás();

        }

        private void Motor1_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "R4 16v TSI 2,4 l";
            motorfelár = 0;
            ÖsszegVáltozás();
        }

        private void Motor2_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "R5 20v TFSI 3,0 l";
            motorfelár = 806450;
            ÖsszegVáltozás();
        }

        private void Motor3_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "V6 24v FSI 3,2 l";
            motorfelár = 1496060;
            ÖsszegVáltozás();
        }

        private void Motor4_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "V8 32v FSI 4,2";
            motorfelár = 2456180;
            ÖsszegVáltozás();
        }

        private void MotorDízel1_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "TDI 1,4 l 66kW";
            motorfelár = 0;
            ÖsszegVáltozás();
        }

        private void MotorDízel2_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "V6 TDI 3,0 l";
            motorfelár = 412750;
            ÖsszegVáltozás();
        }

        private void MotorDízel3_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "V8 TDI 4,0 l";
            motorfelár = 1372870;
            ÖsszegVáltozás();
        }

        private void MotorDízel4_Checked(object sender, RoutedEventArgs e)
        {
            Adatok.VálasztottMotor = "V12 TDI 6,0 l";
            motorfelár = 4579620;
            ÖsszegVáltozás();
        }
        private void Tovább_Click(object sender, RoutedEventArgs e)
        {
            Adatok.TechnikaiFelár = motorfelár + meghajtásfelár + üzemanyagfelár + váltófelár;
            Adatok.Végösszeg = helyiVégösszeg + motorfelár + meghajtásfelár + üzemanyagfelár + váltófelár;
            Extrák ex = new Extrák();
            ex.Show();
            this.Close();
        }

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            Adatok.TechnikaiFelár = 0;
            if (Adatok.VálasztottTipus == "Audi A5" || Adatok.VálasztottTipus == "Audi A5 Sportback" || Adatok.VálasztottTipus == "Audi A5 Cabriolet")
            {
                Tipusok.A5tipus vi = new Tipusok.A5tipus();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi R8" || Adatok.VálasztottTipus == "Audi R8 Spyder")
            {
                Tipusok.R8tipus vi = new Tipusok.R8tipus();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi Q3" || Adatok.VálasztottTipus == "Audi Q3 Sportback")
            {
                Tipusok.Q3tipus vi = new Tipusok.Q3tipus();
                vi.Show();
                this.Close();
            }
        }

        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}

