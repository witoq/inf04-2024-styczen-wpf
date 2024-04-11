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

namespace egzamin_inf_04_2024_01_desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zmiana_zdj(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(numer_text_box.Text ,out int a))
            {
                if (a == 000 || a == 111 || a == 333)
                {
                    zdj.Visibility= Visibility.Visible;
                    odcisk_zdj.Visibility = Visibility.Visible;
                    zdj.Source = new BitmapImage(new Uri("Images/" + a + "-zdjecie.jpg", UriKind.Relative));
                    odcisk_zdj.Source = new BitmapImage(new Uri("Images/" + a + "-odcisk.jpg", UriKind.Relative));
                }
                else
                {
                    zdj.Visibility = Visibility.Hidden;
                    odcisk_zdj.Visibility = Visibility.Hidden;
                }

            }
        }
        private void wyswietl_komunikat(object sender, RoutedEventArgs e)
        {
            string kolor_oczu = "";
            if(niebieskie.IsChecked== true) {
                kolor_oczu = "niebieskie";
            }
            if (zielone.IsChecked == true)
            {
                kolor_oczu = "zielone";
            }
            if (piwne.IsChecked == true)
            {
                kolor_oczu = "piwne";
            }
            if (imie_text_box.Text.Equals("") || nazwisko_text_box.Text.Equals(""))
            {
                MessageBox.Show("Wprowadź dane");
            }
            else
            {
                MessageBox.Show(imie_text_box.Text + " " + nazwisko_text_box.Text + " kolor oczu " + kolor_oczu);
            }
        }
    }
}
