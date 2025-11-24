namespace BookStore
{
    partial class frmMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTitles = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnStores = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnMaintClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitles 
            //
            this.btnTitles.Location = new System.Drawing.Point(60, 40);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(120, 35);
            this.btnTitles.TabIndex = 0;
            this.btnTitles.Text = "Titles";
            this.btnTitles.UseVisualStyleBackColor = true;
            this.btnTitles.Click += new System.EventHandler(this.btnTitles_Click);
            // 
            // btnAuthors 
            //
            this.btnAuthors.Location = new System.Drawing.Point(60, 95);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(120, 35);
            this.btnAuthors.TabIndex = 1;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnPublishers
            //
            this.btnPublishers.Location = new System.Drawing.Point(60, 150);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(120, 35);
            this.btnPublishers.TabIndex = 2;
            this.btnPublishers.Text = "Publishers";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            //
            // btnStores 
            //
            this.btnStores.Location = new System.Drawing.Point(60, 205);
            this.btnStores.Name = "btnStores";
            this.btnStores.Size = new System.Drawing.Size(120, 35);
            this.btnStores.TabIndex = 3;
            this.btnStores.Text = "Stores";
            this.btnStores.UseVisualStyleBackColor = true;
            this.btnStores.Click += new System.EventHandler(this.btnStores_Click);
            // 
            // btnEmployees 
            //
            this.btnEmployees.Location = new System.Drawing.Point(60, 260);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 35);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            //
            // btnMaintClose
            //
            this.btnMaintClose.Location = new System.Drawing.Point(60, 325);
            this.btnMaintClose.Name = "btnMaintClose";
            this.btnMaintClose.Size = new System.Drawing.Size(120, 35);
            this.btnMaintClose.TabIndex = 0;
            this.btnMaintClose.Text = "Close";
            this.btnMaintClose.UseVisualStyleBackColor = true;
            this.btnMaintClose.Click += new System.EventHandler(this.btnMaintClose_Click);
            //
            // frmMaintenance
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnStores);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnTitles);
            this.Controls.Add(this.btnMaintClose);
            this.Name = "frmMaintenance";
            this.Text = "Maintenance";
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnTitles;
        private Button btnAuthors;
        private Button btnPublishers;
        private Button btnStores;
        private Button btnEmployees;
        private Button btnMaintClose;
    }
}