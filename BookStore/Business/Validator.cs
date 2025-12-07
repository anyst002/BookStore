using System.Diagnostics;

namespace BookStore.Business
{
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
            catch (MissingFieldException ex)
            {
                MessageBox.Show(ex.Message, "Input Missing");
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
                MessageBox.Show(ex.Message, "Unexpected Error");
            }
        }
    }
}

