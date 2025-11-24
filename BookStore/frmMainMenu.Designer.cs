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
            SuspendLayout();
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(40, 40);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(120, 35);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(40, 100);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(120, 35);
            btnCreateOrder.TabIndex = 1;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(40, 160);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(120, 35);
            btnViewReports.TabIndex = 2;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnMMClose
            // 
            btnMMClose.Location = new Point(40, 270);
            btnMMClose.Name = "btnMMClose";
            btnMMClose.Size = new Size(120, 35);
            btnMMClose.TabIndex = 2;
            btnMMClose.Text = "Close";
            btnMMClose.UseVisualStyleBackColor = true;
            btnMMClose.Click += btnMMClose_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 340);
            Controls.Add(btnViewReports);
            Controls.Add(btnCreateOrder);
            Controls.Add(btnMaintenance);
            Controls.Add(btnMMClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMaintenance;
        private Button btnCreateOrder;
        private Button btnViewReports;
        private Button btnMMClose;
    }
}
