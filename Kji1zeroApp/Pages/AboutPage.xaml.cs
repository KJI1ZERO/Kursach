using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
           // webBrowser.LoadCompleted += WebBrowser_LoadCompleted;
           // webBrowser.Navigated += WebBrowser_Navigated;
        }

       // private void WebBrowser_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
       // {
           // dynamic doc = webBrowser.Document;
           // if (doc != null)
           // {
           //     doc.parentWindow.execScript("window.onerror = function() { return true; }", "javascript");
          //  }
//
          //  if (webBrowser.Source != null && webBrowser.Source.AbsoluteUri.Contains("maps"))
           // {
           //     MessageBox.Show("Карта успешно загружена!");
           // }
   //      }

      //  private void WebBrowser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
       // {
       //     if (webBrowser.Source == null)
       //     {
        //        MessageBox.Show("Не удалось загрузить содержимое. Проверьте подключение к Интернету или настройки безопасности.");
        //    }
       // }
    }
}