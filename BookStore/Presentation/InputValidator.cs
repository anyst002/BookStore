using System;
using System.Diagnostics;

namespace BookStore.Presentation
{
    //===============================================================
    // A group of methods to assert inputs meet criteria, throwing
    // exceptions to be handled by a validator if not. Exceptions
    // throw a default error message unless overridden by an optional
    // parameter in the method call.
    //===============================================================

    public static class InputAssertions
    {
        public static int AssertNonNegative(int input, string customError = "Input must not be negative.")
        {
            if (input < 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static decimal AssertNonNegative(decimal input, string customError = "Input must not be negative.")
        {
            if (input < 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static int AssertPositive(int input, string customError = "Input must be positive.")
        {
            if (input <= 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static decimal AssertPositive(decimal input, string customError = "Input must be positive.")
        {
            if (input <= 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static int AssertNegative(int input, string customError = "Input must be negative.")
        {
            if (input >= 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static decimal AssertNegative(decimal input, string customError = "Input must be negative.")
        {
            if (input >= 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static int AssertZero(int input, string customError = "Input must be zero.")
        {
            if (input != 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static decimal AssertZero(decimal input, string customError = "Input must be zero.")
        {
            if (input != 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static int AssertNonZero(int input, string customError = "Input must not be zero.")
        {
            if (input == 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static decimal AssertNonZero(decimal input, string customError = "Input must not be zero.")
        {
            if (input == 0) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static string AssertNotNullOrWhiteSpace(string? input, string customError = "Missing required input.")
        {
            if (string.IsNullOrWhiteSpace(input)) throw new NullReferenceException(customError);
            return input;
        }

        public static string AssertNoWhitespace(string input, string customError = "Missing required input.")
        {
            foreach (var c in input)
            {
                if (char.IsWhiteSpace(c)) throw new ArgumentException(customError);
            }
            return input;
        }

        public static string AssertStringLengthEquals(string input, int length, string customError = "Input must be correct length.")
        {
            if (input.Length != length) throw new ArgumentOutOfRangeException("", customError);
            return input;
        }

        public static int AssertInt32(string input, string customError = "Input must be an integer only.")
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                throw new FormatException(customError);
            }
        }

        public static int AssertByte(string input, string customError = "Input must be a byte only.")
        {
            try
            {
                return Convert.ToByte(input);
            }
            catch
            {
                throw new FormatException(customError);
            }
        }

        public static decimal AssertDecimal(string input, string customError = "Input must be a decimal only.")
        {
            try
            {
                return Convert.ToDecimal(input);
            }
            catch
            {
                throw new FormatException(customError);
            }
        }

        public static DateTime AssertDateTime(string input, string customError = "Input must be a valid date-time only.")
        {
            try
            {
                return Convert.ToDateTime(input);
            }
            catch
            {
                throw new FormatException(customError);
            }
        }

        public static string AssertRadioSelection(Control container, string customError = "A radio button option must be selected.")
        {
            RadioButton? rdoChecked = container.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)
                ?? throw new NullReferenceException(customError);
            return rdoChecked!.Text;
        }

        public static string AssertComboSelection(ComboBox cboBox, string customError = "A combo box option must be selected.")
        {
            object? item = cboBox.SelectedItem
                ?? throw new NullReferenceException(customError);
            return item.ToString()!;
        }
    }

    //===============================================================
    // A psuedo-abstract class to handle exceptions for validation
    // failures. Can be extended to implement custom handling.
    //===============================================================

    public class Validator
    {
        public virtual void Validate(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Format");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Value");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Missing Value");
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
                MessageBox.Show(ex.Message, "Unexpected Error");
            }
        }
    }

    //===============================================================
    // An example Validator implementation with a unique error
    // message. Could be modified to take in additional actions and
    // execute them conditionally on specific exception call. For
    // instance, to reset fields on a window only for some errors.
    //===============================================================

    public class OrderValidator : Validator
    {
        public override void Validate(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "different window title");
                //other unique code for this exception in this validator class
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Value");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Missing Value");
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
                MessageBox.Show(ex.Message, "Unexpected Error");
            }
        }
    }
}

