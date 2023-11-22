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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 ob = new Window3();
            ob.Show();
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            string str = (cb).Content.ToString();
            if ((str.Equals("Android") || str.Equals("IOS")) && cb.IsChecked.Value && MainWindow.count < 6)
            {
                MainWindow.count++;
            }
            else
            {
                MainWindow.count--;
            }
            
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            string str = (cb).Content.ToString();
            if ((str.Equals("Развития") || str.Equals("Будущего")) && cb.IsChecked.Value && MainWindow.count < 8)
            {
                MainWindow.count++;
            }
            else
            {
                MainWindow.count--;
            }
           
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            string str = (cb).Content.ToString();
            if ((str.Equals("Шакал") || str.Equals("Волк")) && cb.IsChecked.Value && MainWindow.count < 10)
            {
                MainWindow.count++;
            }
            else
            {
                MainWindow.count--;
            }
            //MessageBox.Show(MainWindow.count.ToString());
        }
    }
}
