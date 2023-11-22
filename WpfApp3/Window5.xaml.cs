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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sl = (Slider)sender;

            if (sl == slider && sl.Value == 60 && MainWindow.count < 17)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else if (sl == slider1 && sl.Value == 200 && MainWindow.count < 18)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else if (sl == slider2 && sl.Value == 5 && MainWindow.count < 19)
            {
                MainWindow.count++;
                MessageBox.Show(MainWindow.count.ToString());
            }
            else
            {
                MainWindow.count--;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Finish ob = new Finish();
            ob.Show();
            this.Close();
        }
    }
}
