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
    /// Логика взаимодействия для CreateReviewPage.xaml
    /// </summary>
    public partial class CreateReviewPage : Page
    {
        public CreateReviewPage()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ratingRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {

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
