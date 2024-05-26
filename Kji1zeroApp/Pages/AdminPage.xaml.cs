using Kji1zeroApp.DB;
using Microsoft.Win32;
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

namespace Kji1zeroApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public byte[] ImageData { get; set; }
        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем диалоговое окно для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                // Загружаем выбранное изображение
                BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
                AddImage.Source = bitmap;
                ImageData = File.ReadAllBytes(openFileDialog.FileName);
            }
        }


        public AdminPage()
        {
            InitializeComponent();

            CategoryCb.ItemsSource = DB.Class1.kursachEntities.Category_Tovar.ToList();
            CategoryCb.DisplayMemberPath = "NameCategory";
            AgeCb.ItemsSource = DB.Class1.kursachEntities.AgeTovar.ToList();
            AgeCb.DisplayMemberPath = "NameAge";
         


        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NameTb.Text) ||
                string.IsNullOrEmpty(PriceTb.Text) ||
                string.IsNullOrEmpty(SizeTb.Text) ||
                string.IsNullOrEmpty(AgeCb.Text) ||
                string.IsNullOrEmpty(ColorTb.Text) ||
                string.IsNullOrEmpty(MaterialTb.Text) ||
                ImageData == null ||
                string.IsNullOrEmpty(CategoryCb.Text))
            {
                MessageBox.Show("Введите все данные!!!");
            }
            else
            {
                Tovar tovar = new Tovar();
                tovar.Name = NameTb.Text;
                tovar.Price = Convert.ToDecimal(PriceTb.Text);
                tovar.Size = SizeTb.Text;
                tovar.IdAge = (AgeCb.SelectedItem as AgeTovar).IdAge;
                tovar.Color = ColorTb.Text;
                tovar.Material = MaterialTb.Text;
                tovar.Image = ImageData;
                tovar.IdCategory = (CategoryCb.SelectedItem as Category_Tovar).IdCategory;
                DB.Class1.kursachEntities.Tovar.Add(tovar);
                DB.Class1.kursachEntities.SaveChanges();



                MessageBox.Show("Все данные успешно записаны!");

                NameTb.Text = "";
                PriceTb.Text = "";
                SizeTb.Text = "";
                AgeCb.Text = "";
                ColorTb.Text = "";
                MaterialTb.Text = "";
                AddImage.Source = null;
                CategoryCb.Text = "";
            }


        }
    }
}
