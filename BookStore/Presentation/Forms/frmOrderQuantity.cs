using BookStore.Business;
using BookStore.Entities;

namespace BookStore
{
    public partial class frmOrderQuantity : Form
    {
        private readonly Order _order;
        private readonly OrderItem _item;
        public frmOrderQuantity(object rawData, Order order)
        {
            InitializeComponent();
            _order = order;
            _item = (OrderItem)rawData;
            numQuantity.Value = _item.Qty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _order.UpdateItemQuantity(_item, Convert.ToInt16(numQuantity.Value));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
