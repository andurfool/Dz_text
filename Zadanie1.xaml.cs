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
using System.Windows.Shapes;
using System.IO; 

namespace Dz_text
{
    /// <summary>
    /// Логика взаимодействия для Zadanie1.xaml
    /// </summary>
    public partial class Zadanie1 : Window
    {
        public Zadanie1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что текст введен
            if (string.IsNullOrWhiteSpace(InputTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите текст.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Создаем уникальное имя файла
                string fileName = $"Text_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                // Сохраняем текст в файл
                File.WriteAllText(filePath, InputTextBox.Text);

                // Выводим пользователю путь к файлу
                InfoTextBlock.Text = $"Файл сохранен по пути: {filePath}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}