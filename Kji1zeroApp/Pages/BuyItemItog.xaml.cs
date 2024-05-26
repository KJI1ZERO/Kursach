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
    /// Логика взаимодействия для BuyItemItog.xaml
    /// </summary>
    public partial class BuyItemItog : Page
    {
        public BuyItemItog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                // Здесь можно добавить логику для выполнения оплаты.
                MessageBox.Show("Оплата проведена успешно!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все необходимые поля перед оплатой.");
            }
        }

        private bool AreAllFieldsFilled()
        {
            // Проверяем, что все необходимые поля заполнены.
            if (string.IsNullOrEmpty(txtCardNumber.Text) || string.IsNullOrEmpty(txtDataEnd.Text) || string.IsNullOrEmpty(txtCVV.Text))
            {
                return false;
            }

            return true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
