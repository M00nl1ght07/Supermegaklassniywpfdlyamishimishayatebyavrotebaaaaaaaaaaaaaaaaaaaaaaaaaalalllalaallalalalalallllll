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

namespace WpfApp1
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

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            window2.Top = this.Top;
            window2.Left = this.Left;
            this.Close();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            window3.Top = this.Top;
            window3.Left = this.Left;
            this.Close();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.Top = this.Top;
            window1.Left = this.Left;
            this.Close();
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {

        }
    }
}
