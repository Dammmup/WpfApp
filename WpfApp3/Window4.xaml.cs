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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void CheckAnswer(object sender, RoutedEventArgs e)
        {
            
            TextBox tb = (TextBox)sender;


            if (tb == textBox && tb.Text == "голубой" && MainWindow.count < 14)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else if (tb == textBox1 && tb.Text == "парацетамол" && MainWindow.count < 15)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else if (tb == textBox2 && tb.Text == "отдохнуть" && MainWindow.count < 16)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else
            {
                MainWindow.count--;
            }



            // MessageBox.Show(MainWindow.count.ToString());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 ob = new Window5();
            ob.Show();
            this.Close();
        }
    }
}
