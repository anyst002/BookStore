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
    }
}
