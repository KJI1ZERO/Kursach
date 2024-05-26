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
    /// Логика взаимодействия для ReviewsPage.xaml
    /// </summary>
    public class Review
    {
        public string login { get; set; }
        public string message { get; set; }
    }

    public partial class ReviewsPage : Page
    {
        public ReviewsPage()
        {
            InitializeComponent();

            DataTemplate dataTemplate = new DataTemplate(typeof(Review));
            FrameworkElementFactory stackPanelFactory = new FrameworkElementFactory(typeof(StackPanel));
            FrameworkElementFactory loginBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            FrameworkElementFactory textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));

            Binding loginBinding = new Binding("login");
            Binding messageBinding = new Binding("message");

            loginBlockFactory.SetBinding(TextBlock.TextProperty, loginBinding);
            loginBlockFactory.SetValue(TextBlock.FontWeightProperty, FontWeights.Bold);

            textBlockFactory.SetBinding(TextBlock.TextProperty, messageBinding);
            textBlockFactory.SetValue(TextBlock.TextWrappingProperty, TextWrapping.Wrap);
            textBlockFactory.SetValue(TextBlock.FontSizeProperty, 16.0);
            textBlockFactory.SetValue(TextBlock.ForegroundProperty, Brushes.Black);

            stackPanelFactory.AppendChild(loginBlockFactory);
            stackPanelFactory.AppendChild(textBlockFactory);

            dataTemplate.VisualTree = stackPanelFactory;

            reviewsLW.ItemTemplate = dataTemplate;


            {
                reviewsLW.ItemsSource = new List<Review>
{
    new Review
    {
        login = "РадостныйРебенок123",
        message = "Отличное приложение! Нашел здесь прекрасную игрушку для своего ребенка."
    },
    new Review
    {
        login = "ИгрушечныйМир",
        message = "Мои дети обожают разнообразие товаров на этом приложении. 🎁"
    },
    new Review
    {
        login = "СчастливыеРодители",
        message = "Лучший опыт покупки игрушек! Просто в использовании и быстрая доставка."
    },
    new Review
    {
        login = "ОхотникЗаИгрушками",
        message = "Здесь всегда можно найти уникальные игрушки. Это как обнаружить клад!"
    },
    new Review
    {
        login = "ПрофиПо_Родительству",
        message = "Покупка игрушек никогда не была проще. В этом приложении есть все, что нужно ."
    },
    new Review
    {
        login = "ЛюбительИгрушек",
        message = "Обожаю качество игрушек в этом приложении."
    }
};
            }
        }

        private void addReview_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = (MainWindow)Window.GetWindow(this);
            objMainWindow.contentFrame.NavigationService.Navigate(new CreateReviewPage());
        }
    }
}
