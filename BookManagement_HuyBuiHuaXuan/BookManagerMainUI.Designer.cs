namespace BookManagement_HuyBuiHuaXuan
{
    partial class BookManagerMainUI
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
            lblHeader = new Label();
            grpSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            lblBooklist = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            dgvBookList = new DataGridView();
            lblCopyright = new Label();
            grpSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            lblHeader.Location = new Point(23, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(350, 62);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Book Manager";
            // 
            // grpSearchCriteria
            // 
            grpSearchCriteria.Controls.Add(btnSearch);
            grpSearchCriteria.Controls.Add(txtDescription);
            grpSearchCriteria.Controls.Add(txtBookName);
            grpSearchCriteria.Controls.Add(lblBookDescription);
            grpSearchCriteria.Controls.Add(lblBookName);
            grpSearchCriteria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpSearchCriteria.Location = new Point(40, 108);
            grpSearchCriteria.Name = "grpSearchCriteria";
            grpSearchCriteria.Size = new Size(871, 129);
            grpSearchCriteria.TabIndex = 0;
            grpSearchCriteria.TabStop = false;
            grpSearchCriteria.Text = " Search Criteria ";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(730, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(495, 49);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(187, 34);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(135, 49);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(173, 34);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookDescription.Location = new Point(314, 49);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(175, 28);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookName.Location = new Point(7, 49);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(122, 28);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBooklist
            // 
            lblBooklist.AutoSize = true;
            lblBooklist.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBooklist.Location = new Point(40, 255);
            lblBooklist.Name = "lblBooklist";
            lblBooklist.Size = new Size(99, 28);
            lblBooklist.TabIndex = 2;
            lblBooklist.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.Location = new Point(757, 286);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 57);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(757, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 57);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(757, 514);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 57);
            btnExit.TabIndex = 5;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(757, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 57);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ControlDarkDark;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(40, 286);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(682, 285);
            dgvBookList.TabIndex = 1;
            dgvBookList.CellEnter += dgvBookList_CellEnter;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCopyright.Location = new Point(47, 574);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(171, 28);
            lblCopyright.TabIndex = 13;
            lblCopyright.Text = "©2024-HuyXuan";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(936, 610);
            Controls.Add(lblCopyright);
            Controls.Add(dgvBookList);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblBooklist);
            Controls.Add(grpSearchCriteria);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookManagerMainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grpSearchCriteria.ResumeLayout(false);
            grpSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grpSearchCriteria;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private Label lblBookName;
        private Label lblBooklist;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnExit;
        private Button btnDelete;
        private DataGridView dgvBookList;
        private Label lblCopyright;
    }
}
