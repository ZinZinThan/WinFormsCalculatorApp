using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZinZTDotNetCore.WinFormsCalculatorApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btn_onClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (IsOpeartor(btn.Text))
            {
                if (txtDisplay.Text.Length == 0 || IsOpeartor(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1)) ) return;
            }
            txtDisplay.Text += btn.Text;
        }

        private bool IsOpeartor(string character)
        {
            return character == "+" || character == "-" || character == "*" || character == "/" || character == "%";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            txtResult.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string text = txtDisplay.Text;
            if (string.IsNullOrEmpty(text)) return;
            txtDisplay.Text = text.Substring(0, text.Length - 1);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string data = txtDisplay.Text;

            if (IsValidExpression(data))
            {
                try
                {
                    var result = new DataTable().Compute(data, string.Empty);
                    txtResult.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in computation: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid expression: Division by zero is not allowed.");
            }
        }

        private bool IsValidExpression(string data)
        {
            // Regex to match division by zero
            string pattern = @"/\s*0(\D|$)";

            // Check if the expression matches the pattern
            return !Regex.IsMatch(data, pattern);
        }

    }
}
