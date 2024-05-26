using Kji1zeroApp.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для AutorizahionPage.xaml
    /// </summary>
    /// 

   


    public partial class AutorizahionPage : Page
    {
        public static List<User> user {  get; set; }


        public AutorizahionPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = loginTb.Text.Trim();
                string password = passwordPb.Password.Trim();

                var user = Class1.kursachEntities.User.ToList();
                var users = user.FirstOrDefault(i => i.Login == login && i.Password == password);
                if (users != null && users.Role.Name == "Admin")
                {
                    MessageBox.Show("Вы вошли как админ!");
                    NavigationService.Navigate(new Pages.ProfilePage());
                }
                else if (users != null && users.Role.Name == "User")
                {
                    MessageBox.Show("Добро пожаловать, наш дорогой пользователь!");
                    NavigationService.Navigate(new Pages.ProfilePage());
                }
                else
                {
                    MessageBox.Show("Ошибка! Проверьте свои данные!");
                }

            }
            catch
            {
                MessageBox.Show("Извините! Возникла ошибка входа!");
            }

            
            
        }
    }
}
