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

namespace Kji1zeroApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {

            public MainWindow()
            {
                InitializeComponent();
            }

                private bool _isDragging = false;
                private Point _startPoint;

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.GetPosition(this).Y <= 30)
            {
                _isDragging = true;
                _startPoint = e.GetPosition(this);
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point currentPosition = e.GetPosition(this);

                this.Left = currentPosition.X - _startPoint.X + this.Left;
                this.Top = currentPosition.Y - _startPoint.Y + this.Top;
            }
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _isDragging = false;
        }
    }
    } 



