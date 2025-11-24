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
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnMMClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.btnMaintenance.Location = new System.Drawing.Point(40, 40);
            this.btnMaintenance.Name = "btnMaintenance"
            this.btnMaintenance.Size = new System.Drawing.Size(120, 35);
            this.btnMaintenance.TabIndex = 0;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            //
            // btnSearchBooks
            //
            this.btnCreateOrder.Location = new System.Drawing.Point(40, 100);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(120, 35);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnViewReports
            //
            this.btnViewReports.Location = new System.Drawing.Point(40, 160);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(120, 35);
            this.btnViewReports.TabIndex = 2;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            //
            // btnMMClose
            //
            this.btnMMClose.Location = new System.Drawing.Point(40, 270);
            this.btnMMClose.Name = "btnMMClose";
            this.btnMMClose.Size = new System.Drawing.Size(120, 35);
            this.btnMMClose.TabIndex = 2;
            this.btnMMClose.Text = "Close";
            this.btnMMClose.UseVisualStyleBackColor = true;
            this.btnMMClose.Click += new System.EventHandler(this.btnMMClose_Click);
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnMMClose);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            Load += frmMainMenu_Load;
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnMaintenance;
        private Button btnCreateOrder;
        private Button btnViewReports;
        private Button btnMMClose;
    }
}
