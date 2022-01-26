using System;
using System.Windows;
using System.Windows.Controls;

namespace Calc_MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBox_mathsOperation.ItemsSource = Model.OperationsList;
        }

        private void ComboBox_mathsOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.IndexOperationList = (byte)ComboBox_mathsOperation.SelectedIndex;
            Label_mathsOperation.Content = Model.OperationList;
        }

        private void Button_result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBox_first.Text != null && TextBox_second.Text != null)
                {
                    Model.A = Convert.ToDouble(TextBox_first.Text);
                    Model.B = Convert.ToDouble(TextBox_second.Text);

                    if (ComboBox_mathsOperation.SelectedIndex == 0)
                    {
                        TextBox_result.Text = Model.Sum.ToString();
                    }
                    if (ComboBox_mathsOperation.SelectedIndex == 1)
                    {
                        TextBox_result.Text = Model.Sub.ToString();
                    }
                    if (ComboBox_mathsOperation.SelectedIndex == 2)
                    {
                        TextBox_result.Text = Model.Mul.ToString();
                    }
                    if (ComboBox_mathsOperation.SelectedIndex == 3)
                    {
                        TextBox_result.Text = Model.Del.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
