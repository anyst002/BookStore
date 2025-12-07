using BookStore.Data;

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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnSelect = new Button();
            btnCancel = new Button();
            grdDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            infoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idInfoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)grdDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idInfoBindingSource).BeginInit();
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
            // grdDataGrid
            // 
            grdDataGrid.AllowUserToAddRows = false;
            grdDataGrid.AllowUserToDeleteRows = false;
            grdDataGrid.AllowUserToResizeColumns = false;
            grdDataGrid.AllowUserToResizeRows = false;
            grdDataGrid.AutoGenerateColumns = false;
            grdDataGrid.BackgroundColor = SystemColors.ControlLight;
            grdDataGrid.BorderStyle = BorderStyle.Fixed3D;
            grdDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, infoDataGridViewTextBoxColumn });
            grdDataGrid.DataSource = idInfoBindingSource;
            grdDataGrid.Dock = DockStyle.Top;
            grdDataGrid.Location = new Point(0, 0);
            grdDataGrid.MultiSelect = false;
            grdDataGrid.Name = "grdDataGrid";
            grdDataGrid.ReadOnly = true;
            grdDataGrid.RowHeadersVisible = false;
            grdDataGrid.RowHeadersWidth = 20;
            grdDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            grdDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDataGrid.Size = new Size(381, 397);
            grdDataGrid.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 50;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            infoDataGridViewTextBoxColumn.HeaderText = "Info";
            infoDataGridViewTextBoxColumn.MinimumWidth = 50;
            infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            infoDataGridViewTextBoxColumn.ReadOnly = true;
            infoDataGridViewTextBoxColumn.Width = 328;
            // 
            // idInfoBindingSource
            // 
            idInfoBindingSource.DataSource = typeof(IdInfo);
            // 
            // frmSelectId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 435);
            Controls.Add(grdDataGrid);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSelectId";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select ID";
            ((System.ComponentModel.ISupportInitialize)grdDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)idInfoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnCancel;
        private DataGridView grdDataGrid;
        private BindingSource idInfoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
    }
}