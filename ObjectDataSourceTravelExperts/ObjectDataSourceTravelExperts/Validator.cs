using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDataSourceTravelExperts
{
    /// <summary>
    /// Provides static methods for validating data.
    /// </summary>
    public static class Validator
    {
        //Part done by Mohamed 

        // checks if text box is not empty
        public static bool IsPresent(TextBox tb)
        {
            bool result = true; // innocent intil proven guilty
            if (tb.Text == "")
            {
                MessageBox.Show(tb.Tag + " has to be provided",
                    "Input Error");
                result = false; // guilty
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in an int
        public static bool IsInteger(TextBox tb)
        {
            bool result = true;
            int parsedValue;
            if (!Int32.TryParse(tb.Text, out parsedValue))// bad!
            {
                MessageBox.Show(tb.Tag + " has to be a whole number",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a non-negative int
        public static bool IsNonNegativeInteger(TextBox tb)
        {
            bool result = true;
            int parsedValue = Int32.Parse(tb.Text);// we already know it is an int
            if (parsedValue < 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }
        // checks if input in a text box in a positive int (strictly greater than 0)
        public static bool IsPositiveInteger(TextBox tb)
        {
            bool result = true;
            int parsedValue = Int32.Parse(tb.Text);// we already know it is an int
            if (parsedValue <= 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive (strictly greater than zero)",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }
        // checks if input in a text box in a double value
        public static bool IsDouble(TextBox tb)
        {
            bool result = true;
            double parsedValue;
            if (!Double.TryParse(tb.Text, out parsedValue))// bad!
            {
                MessageBox.Show(tb.Tag + " has to be a number (can have decimal part)",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a non-negative int
        public static bool IsNonNegativeDouble(TextBox tb)
        {
            bool result = true;
            double parsedValue = Double.Parse(tb.Text);// we already know it is a double
            if (parsedValue < 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        //public static bool IsDecimal(TextBox tb)
        //{
        //    bool result = true;
        //    decimal parsedValue;
        //    if (!Decimal.TryParse(tb.Text, out parsedValue))// bad!
        //    {
        //        MessageBox.Show(tb.Tag + " has to be a number (can have decimal part)",
        //            "Input Error");
        //        result = false;
        //        tb.SelectAll();
        //        tb.Focus();
        //    }
        //    return result;
        //}

        // checks if input in a text box in a non-negative decimal
        public static bool IsNonNegativeDecimal(TextBox tb)
        {
            bool result = true;
            decimal parsedValue = Decimal.Parse(tb.Text);// we already know it is a decimal
            if (parsedValue < 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a non-negative int
        public static bool IsDecimalInRange(TextBox tb, decimal minValue,
                                            decimal maxValue)
        {
            bool result = true;
            decimal parsedValue = Decimal.Parse(tb.Text);// we already know it is a decimal
            if (parsedValue < minValue || parsedValue > maxValue)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be between " +
                    minValue.ToString() + " and " + maxValue.ToString(),
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }



        //Part done By Lee
        private static string title = "Entry Error";

        /// <summary>
        /// The title that will appear in dialog boxes.
        /// </summary>
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Checks whether the user entered data into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered data.</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks whether the user entered a decimal value into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered a decimal value.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks whether the user entered an int value into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered an int value.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks whether the user entered a value within a specified range into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <param name="min">The minimum value for the range.</param>
        /// <param name="max">The maximum value for the range.</param>
        /// <returns>True if the user has entered a value within the specified range.</returns>
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}