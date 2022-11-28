using System;
using System.Windows;
using System.Windows.Controls;

namespace WindowsCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";

        double temp = 0;

        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }
        
        // Number Button
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch(name)
            {
                case "buttonOne":
                    output += "1";
                    Output.Text = output;
                    break;

                case "buttonTwo":
                    output += "2";
                    Output.Text = output;
                    break;

                case "buttonThree":
                    output += "3";
                    Output.Text = output;
                    break;

                case "buttonFour":
                    output += "4";
                    Output.Text = output;
                    break;

                case "buttonFive":
                    output += "5";
                    Output.Text = output;
                    break;

                case "buttonSix":
                    output += "6";
                    Output.Text = output;
                    break;

                case "buttonSeven":
                    output += "7";
                    Output.Text = output;
                    break;

                case "buttonEight":
                    output += "8";
                    Output.Text = output;
                    break;

                case "buttonNine":
                    output += "9";
                    Output.Text = output;
                    break;

                case "buttonZero":
                    output += "0";
                    Output.Text = output;
                    break;                
            }
        }

        // Subtraction Button
        private void buttonSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "-";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Addition Button
        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {           
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "+";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Multiply Button
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "*";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Division Button
        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "/";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Sqr Button
        private void buttonSqr_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "sqr";
            }

            switch (operation)
            {
                case "sqr":
                    double outputTempSqr = temp * temp;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }

        // 1/x Button
        private void buttonOneX_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "1/x";
            }

            switch (operation)
            {
                case "1/x":
                    double outputTempSqr = (1) / temp;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = "1/" + "( " +temp + " )";
        }

        // Equals Button
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(output))
                output = temp.ToString();

            PreviewOutput.Text = (temp.ToString() + " " + operation + " " + double.Parse(output) + " " + "=");

            switch (operation)
            {
                case "-":
                    double outputTempSub = temp - double.Parse(output);
                    output = outputTempSub.ToString();
                    Output.Text = output;
                    break;
                
                case "+":
                    double outputTempAdd = temp + double.Parse(output);
                    output = outputTempAdd.ToString();
                    Output.Text = output;
                    break;

                case "*":
                    double outputTempMul = temp * double.Parse(output);
                    output = outputTempMul.ToString();
                    Output.Text = output;
                    break;

                case "/":
                    double outputTempDiv = temp / double.Parse(output);
                    output = outputTempDiv.ToString();
                    Output.Text = output;
                    break;

                case "%":
                    double outputTempPer = (temp * double.Parse(output)) / 100;
                    output = outputTempPer.ToString();
                    Output.Text = output;
                    break;
            }           
        }


        // Clear All Button
        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
            output = "";
            PreviewOutput.Clear();
            PreviewOutput.Text = "";
            temp = 0;
        }

        // Delete Button
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            Output.Undo();
        }

        // Clear Button
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
            else
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
            }
            
            // Function for Concluded
            if (PreviewOutput.Text.EndsWith("="))
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
        }

        // Percentage Button
        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "%";
            }

            switch (operation)
            {
                case "%":
                    double outputTempPer = temp / double.Parse(output) * 100;
                    output = outputTempPer.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation + " " + output);
            */
           
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "%";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Copy Button
        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Output.SelectAll();
            Output.Copy();
        }

        // Square Root Button
        private void buttonSquareRoot_Click(object sender, RoutedEventArgs e)
        {            
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "√";
            }

            switch (operation)
            {
                case "√":
                    double outputTempSqrt = Math.Sqrt(temp);
                    output = outputTempSqrt.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }

        // Pozitive(+) - Negative(-)
        private void buttonPoNe_Click(object sender, RoutedEventArgs e)
        {}

        // Dot(.)
        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonDot":
                    output += ".";
                    Output.Text = output;
                    break;
            }
        }
    }
}