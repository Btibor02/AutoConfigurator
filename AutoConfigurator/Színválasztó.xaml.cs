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
    /// Interaction logic for Színválasztó.xaml
    /// </summary>
    public partial class Színválasztó : Window
    {
        public Színválasztó()
        {
            InitializeComponent();
            ÖsszegVáltozás();
            SzínválasztásAutó();
        }

        private void Fekete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Piros_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kék_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TovábbKész_Click(object sender, RoutedEventArgs e)
        {
            if (Fekete.IsChecked == true)
            {
                Adatok.VálasztottSzín = "Fekete";
            }
            if (Piros.IsChecked == true)
            {
                Adatok.VálasztottSzín = "Piros";
            }
            if (Kék.IsChecked == true)
            {
                Adatok.VálasztottSzín = "Kék";
            }
            Összegzés st = new Összegzés();
            st.Show();
            this.Close();

        }

        private void ÖsszegVáltozás()
        {
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";
            string kiírandó = Adatok.Végösszeg.ToString("#,0", nfi);
            végösszegki.Content = $"{kiírandó} Ft";
        }

        private void Fekete_Checked(object sender, RoutedEventArgs e)
        {

            SzínválasztásAutó();

        }

        private void Piros_Checked(object sender, RoutedEventArgs e)
        {
            SzínválasztásAutó();
        }

        private void Kék_Checked(object sender, RoutedEventArgs e)
        {
            SzínválasztásAutó();
        }

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            Extrák ex = new Extrák();
            ex.Show();
            this.Close();
            Adatok.ExtrákFelár = 0;
        }
        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void SzínválasztásAutó()
        {
            if (autóKép != null)
            {


                if (Adatok.VálasztottTipus == "Audi A5")
                {

                    autóNeve.Content = "Audi A5";
                    if (Fekete.IsChecked == true)
                    {
                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5fekete.png", UriKind.RelativeOrAbsolute));


                    }

                    if (Kék.IsChecked == true)
                    {
                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5kék.png", UriKind.RelativeOrAbsolute));
                    }

                    if (Piros.IsChecked == true)
                    {
                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5piros.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi A5 Sportback")
                {
                    autóNeve.Content = "Audi A5 Sportback";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5feketesportback.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5kéksportback.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5pirossportback.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi A5 Cabriolet")
                {
                    autóNeve.Content = "Audi A5 Cabriolet";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupefekete.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupekek.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/A5coupepiros.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi R8")
                {
                    autóNeve.Content = "Audi R8";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8fekete.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8kek.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8piros.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi R8 Spyder")
                {
                    autóNeve.Content = "Audi R8 Spyder";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderfekete.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderkek.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/R8spyderpiros.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi Q3")
                {
                    autóNeve.Content = "Audi Q3";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3fekete.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3kek.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3piros.png", UriKind.RelativeOrAbsolute));

                    }
                }

                if (Adatok.VálasztottTipus == "Audi Q3 Sportback")
                {
                    autóNeve.Content = "Audi Q3 Sportback";
                    if (Fekete.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackfekete.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Kék.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackkek.png", UriKind.RelativeOrAbsolute));

                    }

                    if (Piros.IsChecked == true)
                    {

                        autóKép.Source = new BitmapImage(new Uri("/Szinek/SzinekKép/Q3sportbackpiros.png", UriKind.RelativeOrAbsolute));

                    }
                }
            }
        }
    }
}



