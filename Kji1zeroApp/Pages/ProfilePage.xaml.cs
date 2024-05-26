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

namespace Kji1zeroApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public class CartItem
    {
        public string name { get; set; }
        public int amount { get; set; }
        public float sum { get; set; }
    }
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            cartLW.ItemsSource = new List<CartItem>
            {
                new CartItem
                {
                    name = "Item 1",
                    amount = 1,
                    sum = 5
                },
                new CartItem
                {
                    name = "Item 2",
                    amount = 2,
                    sum = 10
                },
                new CartItem
                {
                    name = "Item 3",
                    amount = 4,
                    sum = 20
                },
                new CartItem
                {
                    name = "Xren\'",
                    amount = 100,
                    sum = 40
                },
            };
        }

        private void rateBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = (MainWindow)Window.GetWindow(this);
            objMainWindow.contentFrame.NavigationService.Navigate(new CreateReviewPage());
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
