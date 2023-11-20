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
    /// Interaction logic for Extrák.xaml
    /// </summary>
    public partial class Extrák : Window
    {
        int extrákFelár = 0;
        int extrákVégösszeg = Adatok.Végösszeg - Adatok.ExtrákFelár;
        public Extrák()
        {
            InitializeComponent();
            ÖsszegVáltozás();
            Adatok.VálasztottExtrák = new List<string>();
            Adatok.Végösszeg -= Adatok.ExtrákFelár;
            Adatok.ExtrákFelár = 0;
        }
        private void ÖsszegVáltozás()
        {
            extrákFelár = 0;
            if (Fényszórók.IsChecked == true)
            {
                Adatok.VálasztottExtrák.Add("Audi HD-Matrix LED-fényszórók Audi lézer");
                extrákFelár += 822960;
            }
            if (Abroncsok.IsChecked == true)
            {
                Adatok.VálasztottExtrák.Add("Csomag: Abroncsok");
                extrákFelár += 63500;
            }
            if (Vonóhorog.IsChecked == true)
            {
                Adatok.VálasztottExtrák.Add("Vonóhorog előkészítés");
                extrákFelár += 77400;
            }
            if (Fűtés.IsChecked == true)
            {
                Adatok.VálasztottExtrák.Add("Állóhelyzeti fűtés és szellőztetés");
                extrákFelár += 642620;
            }
            if (Üvegtető.IsChecked == true)
            {
                Adatok.VálasztottExtrák.Add("Tetőablak: Panoráma üvegtető");
                extrákFelár += 557530;
            }

            // int kiírandó = helyiVégösszeg + motorfelár;
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";
            //string formatted = kiírandó.ToString("#,0.00", nfi);
            string kiírandó = (extrákVégösszeg + extrákFelár).ToString("#,0", nfi);

            végösszegki.Content = $"{kiírandó} Ft";

        }


        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            Adatok.Végösszeg -= Adatok.ExtrákFelár;
            extrákFelár = 0;
            Technikai vi = new Technikai();
            vi.Show();
            this.Close();
            Adatok.VálasztottExtrák.Clear();
            Adatok.ExtrákFelár = 0;
        }

        private void TovábbSzin_Click(object sender, RoutedEventArgs e)
        {
            
            Adatok.ExtrákFelár = extrákFelár;
            Adatok.Végösszeg = extrákVégösszeg + Adatok.ExtrákFelár;
            if (Adatok.VálasztottTipus == "Audi A5")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi A5 Sportback")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi A5 Cabriolet")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi R8")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi R8 Spyder")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi Q3")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }

            if (Adatok.VálasztottTipus == "Audi Q3 Sportback")
            {
                Színválasztó sz = new Színválasztó();
                sz.Show();
                this.Close();
            }
        }
        private void Kattintás_Click(object sender, RoutedEventArgs e)
        {
            ÖsszegVáltozás();
        }

        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

