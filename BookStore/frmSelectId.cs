using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmSelectId : Form
    {

        public frmSelectId() //frmSelectId(ListViewItem[] list)
        {
            InitializeComponent();
            //lstListView.Items.AddRange(list);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add("001");
            item.SubItems.Add("test");
            item.SubItems.RemoveAt(0); //TODO figure out why [0] is just storing empty space
            lstListView.Items.Add(item);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(lstListView.SelectedItems.Count == 1)
            {
                ListViewItem item = lstListView.SelectedItems[0];
                //return this to parent form somehow
                Close();
            }
            else
            {
                MessageBox.Show("Please select a single ID.", "Invalid Selection");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
