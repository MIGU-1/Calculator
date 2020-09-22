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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn0.Click += Btn_Click;
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            btnPlus.Click += Btn_Click;
            btnMinus.Click += Btn_Click;
            btnMulti.Click += Btn_Click;
            btnDiv.Click += Btn_Click;
            btnResult.Click += Btn_Click;
            btnDelete.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            char operatorSign = ' ';
            int[] numbers;

            switch (btn.Content.ToString())
            {
                case "+":
                    txt.Text += btn.Content.ToString();
                    operatorSign = Convert.ToChar(btn.Content.ToString());
                    break;
                case "-":
                    txt.Text += btn.Content.ToString();
                    operatorSign = Convert.ToChar(btn.Content.ToString());
                    break;
                case "*":
                    txt.Text += btn.Content.ToString();
                    operatorSign = Convert.ToChar(btn.Content.ToString());
                    break;
                case "/":
                    txt.Text += btn.Content.ToString();
                    operatorSign = Convert.ToChar(btn.Content.ToString());
                    break;
                case "C":
                    txt.Text = "";
                    break;
                case "=":
                    numbers = FindNumbers(txt.Text, operatorSign);
                    break;
                default:
                    txt.Text += btn.Content.ToString();
                    break;
            }
        }

        private int[] FindNumbers(string text, char sign)
        {
            string[] strNum = text.Split(sign);
            return new int[]
            {
                Convert.ToInt32(strNum[0]),
                Convert.ToInt32(strNum[1])
            };
        }
    }
}
