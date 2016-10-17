using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace CalculatorWP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            //tb.Text += b.Content.ToString();

            switch (b.Content.ToString())
            {
                case "+":
                    tbPreview.Text = tb.Text + " +";
                    tb.Text = "";
                    break;

                case "-":
                    tbPreview.Text = tb.Text + " -";
                    tb.Text = "";
                    break;

                case "*":
                    tbPreview.Text = tb.Text + " *";
                    tb.Text = "";
                    break;

                case "/":
                    tbPreview.Text = tb.Text + " /";
                    tb.Text = "";
                    break;

                default:
                    //do nothing
                    tb.Text += b.Content.ToString();
                    break;
            }
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                tb.Text = "Error!";
            }
        }

        private void result()
        {

            String operand;
            operand = tbPreview.Text.Substring(tbPreview.Text.Length-1, 1);
            double num1 = Convert.ToDouble(tbPreview.Text.Substring(0, tbPreview.Text.Length - 2));
            double num2 = Convert.ToDouble(tb.Text);

            switch (operand)
            {
                case "+":
                    tb.Text = "" + (num1 + num2);
                    break;
                case "-":
                    tb.Text = "" + (num1 - num2);
                    break;
                case "*":
                    tb.Text = "" + (num1 * num2);
                    break;
                case "/":
                    tb.Text = "" + (num1 / num2);
                    break;

            }

            tbPreview.Text = "";
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }
    }
}