namespace BookStore
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMaintenance = new Button();
            btnCreateOrder = new Button();
            btnViewReports = new Button();
            btnMMClose = new Button();
            grpStoreSpecific = new GroupBox();
            btnStoreSelect = new Button();
            grpStoreSpecific.SuspendLayout();
            SuspendLayout();
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(22, 93);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(120, 35);
            btnMaintenance.TabIndex = 2;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(6, 22);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(120, 35);
            btnCreateOrder.TabIndex = 3;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(6, 81);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(120, 35);
            btnViewReports.TabIndex = 4;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnMMClose
            // 
            btnMMClose.Location = new Point(102, 151);
            btnMMClose.Name = "btnMMClose";
            btnMMClose.Size = new Size(120, 35);
            btnMMClose.TabIndex = 5;
            btnMMClose.Text = "Close";
            btnMMClose.UseVisualStyleBackColor = true;
            btnMMClose.Click += btnMMClose_Click;
            // 
            // grpStoreSpecific
            // 
            grpStoreSpecific.Controls.Add(btnCreateOrder);
            grpStoreSpecific.Controls.Add(btnViewReports);
            grpStoreSpecific.Enabled = false;
            grpStoreSpecific.Location = new Point(170, 12);
            grpStoreSpecific.Name = "grpStoreSpecific";
            grpStoreSpecific.Size = new Size(132, 123);
            grpStoreSpecific.TabIndex = 3;
            grpStoreSpecific.TabStop = false;
            grpStoreSpecific.Text = "No Store Selected";
            // 
            // btnStoreSelect
            // 
            btnStoreSelect.Location = new Point(22, 34);
            btnStoreSelect.Name = "btnStoreSelect";
            btnStoreSelect.Size = new Size(120, 35);
            btnStoreSelect.TabIndex = 1;
            btnStoreSelect.Text = "Select Store";
            btnStoreSelect.UseVisualStyleBackColor = true;
            btnStoreSelect.Click += btnStoreSelect_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 203);
            Controls.Add(btnStoreSelect);
            Controls.Add(grpStoreSpecific);
            Controls.Add(btnMaintenance);
            Controls.Add(btnMMClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            grpStoreSpecific.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMaintenance;
        private Button btnCreateOrder;
        private Button btnViewReports;
        private Button btnMMClose;
        private GroupBox grpStoreSpecific;
        private Button btnStoreSelect;
    }
}
