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
    /// Interaction logic for Összegzés.xaml
    /// </summary>
    public partial class Összegzés : Window
    {
        public Összegzés()
        {
            
            InitializeComponent();
            ÖsszegVáltozás();
            ÖsszegzésKiirásTechnikai();
            ÖsszegKiirásExtrák();
            ÖsszegzésAutó();

        }
        private void ÖsszegzésKiirásTechnikai()
        {

            if (Adatok.VálasztottMeghajtás == "Elsőkerék")
            {
                meghajtás.Content = "Elsőkerék";
                meghajtásKép.Source = new BitmapImage(new Uri("/KépekTechnika/elsőkerék.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMeghajtás == "Quatro")
            {
                meghajtás.Content = "Quatro";
                meghajtásKép.Source = new BitmapImage(new Uri("/KépekTechnika/quatro.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottVáltó == "Kézi")
            {
                váltó.Content = "Kézi";
                váltóKép.Source = new BitmapImage(new Uri("/KépekTechnika/simaváltó.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottVáltó == "Automata")
            {
                váltó.Content = "Automata";
                váltóKép.Source = new BitmapImage(new Uri("/KépekTechnika/automataváltó.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottÜzemanyag == "Benzin")
            {
                üzemanyag.Content = "Benzin";
                üzemanyagKép.Source = new BitmapImage(new Uri("/KépekTechnika/benzin.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottÜzemanyag == "Diesel")
            {
                üzemanyag.Content = "Diesel";
                üzemanyagKép.Source = new BitmapImage(new Uri("/KépekTechnika/diesel.png", UriKind.RelativeOrAbsolute));
            }

            

            if (Adatok.VálasztottMotor == "R4 16v TSI 2,4 l")
            {
                motor.Content = "R4 16v TSI 2,4 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/2,4l.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "R5 20v TFSI 3,0 l")
            {
                motor.Content = "R5 20v TFSI 3,0 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/3,0l.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "V6 24v FSI 3,2 l")
            {
                motor.Content = "V6 24v FSI 3,2 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/3,2l.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "V8 32v FSI 4,2")
            {
                motor.Content = "V8 32v FSI 4,2";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/4,2l.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "TDI 1,4 l 66kW")
            {
                motor.Content = "TDI 1,4 l 66kW";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/dízel1,4l.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "V6 TDI 3,0 l")
            {
                motor.Content = "V6 TDI 3,0 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/dízelv6.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "V8 TDI 4,0 l")
            {
                motor.Content = "V8 TDI 4,0 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/dízelv8.png", UriKind.RelativeOrAbsolute));
            }

            if (Adatok.VálasztottMotor == "V12 TDI 6,0 l")
            {
                motor.Content = "V12 TDI 6,0 l";
                motorkép.Source = new BitmapImage(new Uri("/KépekTechnika/dízelv12.png", UriKind.RelativeOrAbsolute));
            }

        }

        private void ÖsszegKiirásExtrák()
        {
            string kiirtExtrák = "";
            
                if (Adatok.VálasztottExtrák.Contains("Audi HD-Matrix LED-fényszórók Audi lézer"))
                {
                    kiirtExtrák += "\nAudi HD-Matrix LED-fényszórók Audi lézer";
                }

                if (Adatok.VálasztottExtrák.Contains("Csomag: Abroncsok"))
                {
                    kiirtExtrák += "\nCsomag: Abroncsok";
                }

                if (Adatok.VálasztottExtrák.Contains("Vonóhorog előkészítés"))
                {
                    kiirtExtrák += "\nVonóhorog előkészítés";
                }

                if (Adatok.VálasztottExtrák.Contains("Állóhelyzeti fűtés és szellőztetés"))
                {
                    kiirtExtrák += "\nÁllóhelyzeti fűtés és szellőztetés";
                }

                if (Adatok.VálasztottExtrák.Contains("Tetőablak: Panoráma üvegtető"))
                {
                    kiirtExtrák += "\nTetőablak: Panoráma üvegtető";
                }

                if (Adatok.VálasztottExtrák.Count() == 0)
                {
                    kiirtExtrák = "\nNem választott ki extrákat!";
                }

            extrák.Content = kiirtExtrák;
        }

        private void ÖsszegzésAutó()
        {
            if (Adatok.VálasztottTipus == "Audi A5")
            {
                autónév.Content = "Audi A5";
                if (Adatok.VálasztottSzín == "Fekete")
                {
                    
                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5fekete.png", UriKind.RelativeOrAbsolute));
                    
                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5kék.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5piros.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi A5 Sportback")
            {
                autónév.Content = "Audi A5 Sportback";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5feketesportback.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5kéksportback.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5pirossportback.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi A5 Cabriolet")
            {
                autónév.Content = "Audi A5 Cabriolet";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupefekete.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupekek.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupepiros.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi R8")
            {
                autónév.Content = "Audi R8";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8fekete.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8kek.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8piros.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi R8 Spyder")
            {
                autónév.Content = "Audi R8 Spyder";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderfekete.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderkek.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderpiros.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi Q3")
            {
                autónév.Content = "Audi Q3";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3fekete.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3kek.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3piros.png", UriKind.RelativeOrAbsolute));

                }
            }

            if (Adatok.VálasztottTipus == "Audi Q3 Sportback")
            {
                autónév.Content = "Audi Q3 Sportback";
                if (Adatok.VálasztottSzín == "Fekete")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackfekete.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Kék")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackkek.png", UriKind.RelativeOrAbsolute));

                }

                if (Adatok.VálasztottSzín == "Piros")
                {

                    autó.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackpiros.png", UriKind.RelativeOrAbsolute));

                }
            }
        }

        

        private void ÖsszegVáltozás()
        {
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";
            string kiírandó = Adatok.Végösszeg.ToString("#,0", nfi);
            végösszegki.Content = $"{kiírandó} Ft";
        }
        private void TovábbMégsem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sc = new MainWindow();
            sc.Show();
            this.Close();
        }

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            if (Adatok.VálasztottTipus == "Audi A5")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi A5 Sportback")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi A5 Cabriolet")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi R8")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi R8 Spyder")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi Q3")
            {
                Színválasztó vi = new Színválasztó();
                vi.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi Q3 Sportback")
            {
                Színválasztó vi = new Színválasztó();
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
