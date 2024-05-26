using Kji1zeroApp.Pages;
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
using Kji1zeroApp.DB;

namespace Kji1zeroApp.Components
{
    public partial class Topbar : Page     
    {
        public static Topbar Page;
        public class Topbar1
        {
            public void SetWindowState(Window window, WindowState state)
            {
                window.WindowState = state;
            }
        }


      
        public Topbar()
        {
            InitializeComponent();
           

            Button closeButton = new Button
            {
                Content = "❌",
                FontSize = 16,
                Width = 43,
                Height = 35,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Background = Brushes.Red, // Красный цвет для кнопки "Закрыть"
                Foreground = Brushes.White // Белый цвет для текста на кнопке
            };

            closeButton.Click += (sender, e) => { Application.Current.Shutdown(); };

            Button minimizeButton = new Button
            {
                Content = "-",
                FontWeight = FontWeights.Bold,
                FontSize = 16,
                Width = 35,
                Height = 35,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(0, 0, 30, 0),
                Background = Brushes.Yellow, // Желтый цвет для кнопки "Свернуть"
                Foreground = Brushes.Black // Черный цвет для текста на кнопке
            };

            minimizeButton.Click += (sender, e) => {
                Window mainWindow = Window.GetWindow(this);
                Topbar1 topbarHelper = new Topbar1();
                topbarHelper.SetWindowState(mainWindow, WindowState.Minimized);
            };

            this.LayoutRoot.Children.Add(closeButton);
            this.LayoutRoot.Children.Add(minimizeButton);
        }

      
        private void DragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.OriginalSource == this)
                    DragMove(this, e);
            }
        }




        private void profileBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = (MainWindow)Window.GetWindow(this);
            objMainWindow.contentFrame.NavigationService.Navigate(new AutorizahionPage());
        }
    }
}