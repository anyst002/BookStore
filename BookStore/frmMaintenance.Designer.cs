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
            btnTitles = new Button();
            btnAuthors = new Button();
            btnPublishers = new Button();
            btnStores = new Button();
            btnEmployees = new Button();
            SuspendLayout();
            // 
            // btnTitles
            // 
            btnTitles.Location = new Point(54, 43);
            btnTitles.Name = "btnTitles";
            btnTitles.Size = new Size(131, 47);
            btnTitles.TabIndex = 0;
            btnTitles.Text = "Titles";
            btnTitles.UseVisualStyleBackColor = true;
            btnTitles.Click += btnTitles_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.Location = new Point(54, 96);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(129, 47);
            btnAuthors.TabIndex = 1;
            btnAuthors.Text = "Authors";
            btnAuthors.UseVisualStyleBackColor = true;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // btnPublishers
            // 
            btnPublishers.Location = new Point(52, 149);
            btnPublishers.Name = "btnPublishers";
            btnPublishers.Size = new Size(131, 47);
            btnPublishers.TabIndex = 2;
            btnPublishers.Text = "Publishers";
            btnPublishers.UseVisualStyleBackColor = true;
            btnPublishers.Click += btnPublishers_Click;
            // 
            // btnStores
            // 
            btnStores.Location = new Point(54, 202);
            btnStores.Name = "btnStores";
            btnStores.Size = new Size(131, 47);
            btnStores.TabIndex = 3;
            btnStores.Text = "Stores";
            btnStores.UseVisualStyleBackColor = true;
            btnStores.Click += btnStores_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(52, 255);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(131, 47);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // frmMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployees);
            Controls.Add(btnStores);
            Controls.Add(btnPublishers);
            Controls.Add(btnAuthors);
            Controls.Add(btnTitles);
            Name = "frmMaintenance";
            Text = "Maintenance";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTitles;
        private Button btnAuthors;
        private Button btnPublishers;
        private Button btnStores;
        private Button btnEmployees;
    }
}