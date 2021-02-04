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

namespace WpfAppCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string operation;
        public string num;
        public bool rightOperand;

        public MainWindow()
        {
            rightOperand = false;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rightOperand)
            {
                rightOperand = false;
                TextBox1.Text = "0";
            }
            Button btn = (Button)sender;
            if (TextBox1.Text == "0")
                TextBox1.Text = (string)btn.Content;
            else
                TextBox1.Text += btn.Content;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            operation = (string)btn.Content;
            num = TextBox1.Text;
            rightOperand = true;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double storedVal1, storedVal2, res;
            res = 0;
            storedVal1 = Convert.ToDouble(num);
            storedVal2 = Convert.ToDouble(TextBox1.Text);
            switch (operation)
            {
                case "+":
                    res = storedVal1 + storedVal2;
                    break;
                case "-":
                    res = storedVal1 - storedVal2;
                    break;
                case "*":
                    res = storedVal1 * storedVal2;
                    break;
                case "/":
                    res = storedVal1 / storedVal2;
                    break;
                case "x^y":
                    res = Math.Pow(storedVal1, storedVal2);
                    break;
            }
            operation = "=";
            rightOperand = true;
            TextBox1.Text = Convert.ToString(res);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double storedVal, res;
            storedVal = Convert.ToDouble(TextBox1.Text);
            res = Math.Sqrt(storedVal);
            TextBox1.Text = Convert.ToString(res);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double storedVal, res;
            storedVal = Convert.ToDouble(TextBox1.Text);
            res = Math.Pow(storedVal,2);
            TextBox1.Text = Convert.ToString(res);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double storedVal, res;
            storedVal = Convert.ToDouble(TextBox1.Text);
            res = 1 / storedVal;
            TextBox1.Text = Convert.ToString(res);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double storedVal, res;
            storedVal = Convert.ToDouble(TextBox1.Text);
            res = -storedVal;
            TextBox1.Text = Convert.ToString(res);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (!TextBox1.Text.Contains(","))
                TextBox1.Text += ",";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox1.Text = Convert.ToString(DateTime.Now);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Visibility vis;
            vis = Visibility.Collapsed;
            StackPanel1.Visibility = vis;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Visibility vis;
            vis = Visibility.Visible;
            StackPanel1.Visibility = vis;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Background = new SolidColorBrush(Colors.Black);
            LayoutCalc.Background = new SolidColorBrush(Colors.DarkGray);
            this.Resources["MyBackgraund"] = new SolidColorBrush(Colors.Black);

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox1.Background = new SolidColorBrush(Colors.White);
            LayoutCalc.Background = new SolidColorBrush(Colors.White);
            this.Resources["MyBackgraund"] = new SolidColorBrush(Colors.DarkOrange);
        }
    }
}
