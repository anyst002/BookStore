using BookStore.Entities;

namespace BookStore.Presentation
{
    internal class PresentationUtilities
    {
        public static string SelectId(List<IdInfo> list)
        {
            frmSelectId selectForm = new frmSelectId(list);
            selectForm.ShowDialog();
            return selectForm.id;
        }

        public static void ValidateState(string state)//may need a validator wrap
        {
            if (!string.IsNullOrWhiteSpace(state))
                AssertStringLengthEquals(state.Trim(), 2, "State must be exactly 2 characters.");
        }

        public static void ValidateZip(MaskedTextBox zipBox)
        {
            if (!string.IsNullOrWhiteSpace(zipBox.Text.Replace("-", "")))
            {
                AssertMaskFull(zipBox, "Zip must be 5 digits.");
            }
        }
    }
}
