using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calc01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regex reg = new Regex(@"^[-]?([0]{1})|([1-9]{1}([0-9]{1,7})?)([,][0-9]{1,8})?$");
      
        private int operation = 0; //0+ 1- 2* 3/
        public MainWindow()
        {
            InitializeComponent();
            a_value.Text = "";
            a_value.Width = this.Width;
            b_value.Text = "";
            b_value.Width = this.Width;
            result.Text = "";
            result.Width = this.Width;

            Background = new SolidColorBrush(Color.FromRgb(179,201,230));
            a_value.Background = new SolidColorBrush(Color.FromRgb(194, 211, 235));
            b_value.Background = new SolidColorBrush(Color.FromRgb(194, 211, 235));
            result.Background = new SolidColorBrush(Color.FromRgb(179, 201, 230));
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            operation = 0;
            default_button_col();
            button_plus.Background= new SolidColorBrush(Color.FromRgb(147, 178, 220));
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            operation = 1;
            default_button_col();
            button_minus.Background = new SolidColorBrush(Color.FromRgb(147, 178, 220));
        }

        private void button_multi_Click(object sender, RoutedEventArgs e)
        {
            operation = 2;
            default_button_col();
            button_multi.Background = new SolidColorBrush(Color.FromRgb(147, 178, 220));
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            operation = 3;
            default_button_col();
            button_div.Background = new SolidColorBrush(Color.FromRgb(147, 178, 220));
        }

        private void default_button_col()
        {
            button_plus.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            button_minus.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            button_multi.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            button_div.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            if (!(reg.IsMatch(a_value.Text) && reg.IsMatch(b_value.Text)))
            {
                MessageBox.Show("Invalid input! ");
                return;
            }

                switch (operation)
                {
                    case 0:
                        result.Text = (Convert.ToDouble(a_value.Text) + Convert.ToDouble(b_value.Text)).ToString();
                        break;
                    case 1:
                        result.Text = (Convert.ToDouble(a_value.Text) - Convert.ToDouble(b_value.Text)).ToString();
                        break;
                    case 2:
                        result.Text = (Convert.ToDouble(a_value.Text) * Convert.ToDouble(b_value.Text)).ToString();
                        break;
                    case 3:
                        result.Text = (Convert.ToDouble(a_value.Text) / Convert.ToDouble(b_value.Text)).ToString();
                        break;

                }
        
            
            
        }
    }
}
