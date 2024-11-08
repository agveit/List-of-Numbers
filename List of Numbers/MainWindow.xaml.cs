using System.Windows;

namespace List_of_Numbers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            numberList.Items.Remove(numberList.SelectedItem);
        }

        // Переменная для запоминания последнего введённого числа
        int clickC = 0;
        
        
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            numberList.Items.Add(clickC);
            clickC++;
        }

        // Обработчик для очистки списка и переменной 
        private void Button_Click_Refresh(object sender, RoutedEventArgs e)
        {
            clickC = 0;
            numberList.Items.Clear();
        }
    }
}
