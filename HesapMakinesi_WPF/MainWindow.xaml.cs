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

namespace HesapMakinesi_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long no1 = 0;
        long no2 = 0;
        string hesap = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 1;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 1;
                btntext.Text = no2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 2;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 2;
                btntext.Text = no2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 3;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 3;
                btntext.Text = no2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 4;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 4;
                btntext.Text = no2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 5;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 5;
                btntext.Text = no2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 6;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 6;
                btntext.Text = no2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 7;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 7;
                btntext.Text = no2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 8;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 8;
                btntext.Text = no2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10) + 9;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10) + 9;
                btntext.Text = no2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 * 10);
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 * 10);
                btntext.Text = no2.ToString();
            }
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            hesap = "+";
            btntext.Text = "0";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            hesap = "-";
            btntext.Text = "0";
        }

        private void btntimes_Click(object sender, RoutedEventArgs e)
        {
            hesap = "*";
            btntext.Text = "0";
        }

        private void btndivide_Click(object sender, RoutedEventArgs e)
        {
            hesap = "/";
            btntext.Text = "0";
        }

        private void btnequals_Click(object sender, RoutedEventArgs e)
        {
            switch(hesap)
            {
                case "+":
                    btntext.Text = (no1 + no2).ToString();
                    break;
                case "-":
                    btntext.Text = (no1 - no2).ToString();
                    break;
                case "*":
                    btntext.Text = (no1 * no2).ToString();
                    break;
                case "/":
                    btntext.Text = (no1 / no2).ToString();
                    break;
            }
            
        }

        private void btnclearenter_Click(object sender, RoutedEventArgs e)
        {
            if (hesap =="")
            {
                no1 = 0;

            }
            else
            {
                no2 = 0;
            }
            btntext.Text = "0";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            no1 = 0;
            no2 = 0;
            hesap = "";
            btntext.Text = "";
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 = (no1 / 10);
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 = (no2 / 10);
                btntext.Text = no2.ToString();
            }
        }

        private void btnposneg_Click(object sender, RoutedEventArgs e)
        {
            if (hesap == "")
            {
                no1 *= -1;
                btntext.Text = no1.ToString();
            }
            else
            {
                no2 *= -1;
                btntext.Text = no2.ToString();
            }
        }
    }
}
