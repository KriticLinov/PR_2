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

namespace PR_2_task_2
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TbAnswer1.Clear();
            if (!double.TryParse(TbN.Text, out double n))
            {
                MessageBox.Show("Введите трехзначное число.");
            }

            else if (n < 999)
            {
                MessageBox.Show("Введите четырехзначное число.");
            }

            else
            {
                var result = n / 100 % 10;
                TbAnswer1.Text += result;
            }
        }
    }
}
