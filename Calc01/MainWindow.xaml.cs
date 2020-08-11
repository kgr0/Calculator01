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
        Regex reg1 = new Regex(@"^[1-9]{1}$");
        Regex reg2 = new Regex(@"^\d{0,5}$");
        private int znak = 0; //0+ 1- 2* 3/
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            znak = 0;
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            znak = 1;
        }

        private void button_multi_Click(object sender, RoutedEventArgs e)
        {
            znak = 2;
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            znak = 3;
        }

        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(a_value.Text. )

            if(a_value.Text != "" && b_value.Text != "")
            {
                switch (znak)
                {
                    case 0:
                        result.Text = (Convert.ToInt32(a_value.Text) + Convert.ToInt32(b_value.Text)).ToString();
                        break;
                    case 1:
                        result.Text = (Convert.ToInt32(a_value.Text) - Convert.ToInt32(b_value.Text)).ToString();
                        break;
                    case 2:
                        result.Text = (Convert.ToInt32(a_value.Text) * Convert.ToInt32(b_value.Text)).ToString();
                        break;
                    case 3:
                        result.Text = (Convert.ToInt32(a_value.Text) / Convert.ToInt32(b_value.Text)).ToString();
                        break;

                }
            }

            else
            {
                result.Text =  "Error"
            }
            
            
        }
    }
}
