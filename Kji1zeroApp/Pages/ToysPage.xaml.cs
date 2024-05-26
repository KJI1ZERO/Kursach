using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kji1zeroApp.DB;

namespace Kji1zeroApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ToysPage.xaml
    /// </summary>
    /// 




    public partial class ToysPage : Page
    {
       

        public ToysPage()
        {
            InitializeComponent();
            DataContext = this;
            toysIC.ItemsSource = DB.Class1.kursachEntities.Tovar.Where(i => i.Category_Tovar.NameCategory == "для мальчиков").ToList();
        }



        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            MainWindow objMainWindow = (MainWindow)Window.GetWindow(this);
            objMainWindow.contentFrame.NavigationService.Navigate(new ToyInfoPage((panel.DataContext as Tovar)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();
        }
    }
}