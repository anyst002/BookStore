namespace BookStore
{
    partial class frmSelectId
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
            btnSelect = new Button();
            btnCancel = new Button();
            lstListView = new ListView();
            colId = new ColumnHeader();
            colDescription = new ColumnHeader();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(12, 404);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(155, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(214, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstListView
            // 
            lstListView.Columns.AddRange(new ColumnHeader[] { colId, colDescription });
            lstListView.FullRowSelect = true;
            lstListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstListView.Location = new Point(0, 0);
            lstListView.Name = "lstListView";
            lstListView.Size = new Size(381, 398);
            lstListView.TabIndex = 0;
            lstListView.UseCompatibleStateImageBehavior = false;
            lstListView.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            // 
            // colDescription
            // 
            colDescription.Text = "Description";
            colDescription.Width = 317;
            // 
            // frmSelectId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 435);
            Controls.Add(lstListView);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSelectId";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select ID";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnCancel;
        private ListView lstListView;
        private ColumnHeader colId;
        private ColumnHeader colDescription;
    }
}