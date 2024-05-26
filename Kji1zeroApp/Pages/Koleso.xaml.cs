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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kji1zeroApp.Pages
{
    public partial class Koleso : Page
    {
        private bool spinning = false; // Флаг определяющий, вращается ли колесо в данный момент
        private RotateTransform WheelTransform = new RotateTransform();

        public Koleso()
        {
            InitializeComponent();
        }

        private void SpinWheel_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                spinning = true;

                Random random = new Random();
                int result = random.Next(12); // Генерация случайного результата от 0 до 11

                DoubleAnimation animation = new DoubleAnimation
                {
                    By = 360 * 5 + 30 * result, // Вращение на 5 оборотов + сдвиг на 30 градусов для показа результата
                    Duration = TimeSpan.FromSeconds(3),
                    FillBehavior = FillBehavior.HoldEnd // Завершение анимации с сохранением конечного состояния
                };

                animation.Completed += (s, _) => ShowResult(result); // Показ результата при завершении анимации

                WheelTransform.CenterX = Wheel.ActualWidth / 2; // Установка центра вращения по X
                WheelTransform.CenterY = Wheel.ActualHeight / 2; // Установка центра вращения по Y
                Wheel.BeginAnimation(RotateTransform.AngleProperty, animation);
            }
        }

        private void ShowResult(int result)
        {
            // Здесь вы можете обработать результат, например, отобразить его на экране
            MessageBox.Show($"Выпал результат: {result}", "Результат");
        }
    }
}