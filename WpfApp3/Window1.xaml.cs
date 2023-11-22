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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window 
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (TextBlock)basa.SelectedItem;
            if (item.Text == "B^2-4ac" && MainWindow.count < 1)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else
            {
                MainWindow.count++;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var item = (TextBlock)basa1.SelectedItem;
            if (item.Text == "40075" && MainWindow.count < 2)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else
            {
                MainWindow.count++;
            }
        }

        private void basa2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (TextBlock)basa2.SelectedItem;
            if (item.Text == "9" && MainWindow.count < 3)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else
            {
                MainWindow.count++;
            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Window2 ob = new Window2();
            ob.Show();
            this.Close();
        }
    }
}
