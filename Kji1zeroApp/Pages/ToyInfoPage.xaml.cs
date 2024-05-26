using System;
using System.Collections.Generic;
using System.IO;
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
using Kji1zeroApp.DB;

namespace Kji1zeroApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ToyInfoPage.xaml
    /// </summary>
    public partial class ToyInfoPage : Page
    {

        public ToyInfoPage(Tovar toy)
        {
            InitializeComponent();
            nameTB.Text = toy.Name;
            priceTB.Text = $"Цена: {toy.Price} RUB";
            ageTB.Text = $"Возраст: {toy.AgeTovar.NameAge}";
            materialTB.Text = $"Материал: {toy.Material}";
            sizeTB.Text = $"Размер: {toy.Size}";
            colorTB.Text = $"Цвет: {toy.Color}";
            try
            {
                MemoryStream stream = new MemoryStream(toy.Image);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                ImageTovar.Source = bitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load the image: {ex.Message}", "Error");
            }
        }


        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = (MainWindow)Window.GetWindow(this);
            objMainWindow.contentFrame.NavigationService.Navigate(new BuyItemItog());
        }

        private void addToCartBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
