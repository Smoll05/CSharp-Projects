using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

using System.Data;
using System.Linq.Expressions;

namespace Calculator_Intelligent_System
{
    public partial class calculator : Form
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        string input = "";
        string equation = "";
        bool operatorPending = false;
        bool equalPending = false;

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        public void textBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            HideCaret(textBox.Handle);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            updateResultDisplay(sender as Button);
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input) || input == "0")
                return;

            if (input.StartsWith("-"))
            {
                input = input.Substring(1);
            }
            else
            {
                input = "-" + input;
            }

            if (isOperator(input[input.Length - 1]))
            {
                resultDisplay.Text = input.Remove(input.Length - 1);
            }
            else
            {
                resultDisplay.Text = input;
            }
        }


        private void buttonPow_Click(object sender, EventArgs e)
        {
            updateOperatorResultDisplay(sender as Button);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            updateOperatorResultDisplay(sender as Button);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            updateOperatorResultDisplay(sender as Button);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            updateOperatorResultDisplay(sender as Button);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            updateOperatorResultDisplay(sender as Button);
        }

        private void updateResultDisplay(Button buttonInput)
        {
            if (resultDisplay.Text == "Error" || resultDisplay.Text == "Math Error" || resultDisplay.Text == "0")
            {
                input = "";
                resultDisplay.Text = input;
            }

            if(operatorPending)
            {
                input = "";
            }

            if(equalPending)
            {
                input = "";
                equation = "";
                equationDisplay.Text = equation;
            }
            
            input += buttonInput.Text;
            equalPending = false;
            operatorPending = false;
            resultDisplay.Text = input;
        }

        private void updateOperatorResultDisplay(Button buttonInput)
        {
            if (resultDisplay.Text == "Error" || resultDisplay.Text == "Math Error")
            {
                input = "0";
                resultDisplay.Text = input;
            }
            else if (operatorPending)
            {
                string op = buttonInput.Text;
                equation = equation.Remove(equation.Length - 1) + op;
            }
            else if (equation.Length == 0)
            {
                operatorPending = true;
                equation = resultDisplay.Text + buttonInput.Text;
            }
            else
            {
                if(equalPending)
                {
                    input += buttonInput.Text;
                    equation = input;
                    equalPending = false;
                } 
                else
                {
                    string calculateResult = CalculatorLogic.Calculate(equation + input);
                    if (calculateResult == "Math Error" || calculateResult == "Error")
                    {
                        resetDisplay();
                        resultDisplay.Text = calculateResult;
                    } 
                    else
                    {
                        input += buttonInput.Text;
                        equation += input;
                        input = calculateResult;
                    }
                    resultDisplay.Text = input;
                }
                operatorPending = true;
            }
            equationDisplay.Text = equation;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (input.Length > 1)
            {
                input = input.Remove(input.Length - 1);
            } else
            {
                input = "0";
            }
            resultDisplay.Text = input;
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            resetDisplay();
            equalPending = false;
            operatorPending = false;
        } 

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string calculateResult = CalculatorLogic.Calculate(equation + input);

            if (calculateResult == "Math Error" || calculateResult == "Error")
            {
                resetDisplay();
                resultDisplay.Text = calculateResult;
            }
            else
            {
                input = calculateResult;
                equationDisplay.Text = input + "=";
                resultDisplay.Text = input;
                equalPending = true;
            }
        }

        private void resetDisplay()
        {
            input = "0";
            equation = "";
            resultDisplay.Text = input;
            equationDisplay.Text = equation;
        }
        private bool isOperator(char input)
        {
            return input == '+' || input == '-' || input == 'x' || input == '÷' || input == '^';
        }
    }

    public class CalculatorLogic
    {
        public static string Calculate(string equation)
        {
            string expression = equation.Replace("x", "*").Replace("÷", "/");

            try
            {
                Regex powRegex = new Regex(@"(\d+(\.\d+)?)\^(\d+(\.\d+)?)");
                while (powRegex.IsMatch(expression))
                {
                    Match match = powRegex.Match(expression);

                    double baseNum = Convert.ToDouble(match.Groups[1].Value);
                    double exponent = Convert.ToDouble(match.Groups[3].Value);

                    double powValue = Math.Pow(baseNum, exponent);

                    expression = expression.Replace(match.Value, powValue.ToString("G"));
                }

                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                if (result == null || result == DBNull.Value)
                {
                    return "Error";
                }

                double number = Convert.ToDouble(result);

                if (double.IsInfinity(number) || double.IsNaN(number))
                {
                    return "Math Error";
                }

                return number % 1 == 0 ? ((int)number).ToString() : number.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Math Error";
            }
            catch
            {
                return "Error";
            }
        }
    }
}
