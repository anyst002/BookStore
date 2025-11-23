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
            btnAddBook = new Button();
            btnSearchBooks = new Button();
            btnViewReports = new Button();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(76, 69);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(125, 45);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(76, 168);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(125, 45);
            btnSearchBooks.TabIndex = 1;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(76, 277);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(125, 45);
            btnViewReports.TabIndex = 2;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnViewReports);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnAddBook);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainMenu";
            Text = "Book Collection - Main Menu";
            Load += frmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBook;
        private Button btnSearchBooks;
        private Button btnViewReports;
    }
}
