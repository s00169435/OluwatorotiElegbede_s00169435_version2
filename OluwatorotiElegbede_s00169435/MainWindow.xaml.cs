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

namespace OluwatorotiElegbede_s00169435
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Phone> phones = (from p in db.Phones
                                  orderby p.Name descending
                                  select p).ToList();

            lbxPhones.ItemsSource = phones;
        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selected = lbxPhones.SelectedItem as Phone;

            if (selected != null)
            {
                txtBlkPrice.Text = selected.Price.ToString("C");
                imgPhone.Source = new BitmapImage(new Uri(selected.Phone_Image, UriKind.Relative));
            }
        }
    }
}
