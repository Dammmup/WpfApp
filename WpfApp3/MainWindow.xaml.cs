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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int count = 0;
        public static string name=string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = text1.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("You must enter the name!!");
            }
            else
            {
                name = text;
                Window1 ob = new Window1();
                ob.Show();
                this.Close();
            }
        }
    }
}
