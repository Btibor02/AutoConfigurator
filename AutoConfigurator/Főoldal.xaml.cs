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
using System.Media;

namespace AutoConfigurator
{
    /// <summary>
    /// Interaction logic for Főoldal.xaml
    /// </summary>
    public partial class Főoldal : Window
    {
        public Főoldal()
        {
            InitializeComponent();
        }

        private void Kilépés_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Elkezdés_Click(object sender, RoutedEventArgs e)
        {
            MainWindow st = new MainWindow();
            st.Show();
            this.Close();
        }
    }
}
