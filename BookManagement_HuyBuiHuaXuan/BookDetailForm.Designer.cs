namespace BookManagement_HuyBuiHuaXuan
{
    partial class BookDetailForm
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
            btnSave = new Button();
            grpBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            lblBookName = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtBookId = new TextBox();
            lblDescription = new Label();
            lblBookId = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grpBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(810, 94);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 57);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grpBookInfo
            // 
            grpBookInfo.Controls.Add(cboBookCategoryId);
            grpBookInfo.Controls.Add(dtpPublicationDate);
            grpBookInfo.Controls.Add(txtPrice);
            grpBookInfo.Controls.Add(txtQuantity);
            grpBookInfo.Controls.Add(txtBookName);
            grpBookInfo.Controls.Add(txtDescription);
            grpBookInfo.Controls.Add(txtAuthor);
            grpBookInfo.Controls.Add(lblBookName);
            grpBookInfo.Controls.Add(lblPublicationDate);
            grpBookInfo.Controls.Add(lblQuantity);
            grpBookInfo.Controls.Add(lblAuthor);
            grpBookInfo.Controls.Add(lblPrice);
            grpBookInfo.Controls.Add(lblCategory);
            grpBookInfo.Controls.Add(txtBookId);
            grpBookInfo.Controls.Add(lblDescription);
            grpBookInfo.Controls.Add(lblBookId);
            grpBookInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpBookInfo.Location = new Point(12, 74);
            grpBookInfo.Name = "grpBookInfo";
            grpBookInfo.Size = new Size(768, 502);
            grpBookInfo.TabIndex = 0;
            grpBookInfo.TabStop = false;
            grpBookInfo.Text = "Book Info";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(189, 450);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(179, 36);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(189, 309);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(157, 34);
            dtpPublicationDate.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(547, 355);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(201, 34);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(189, 358);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(201, 34);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(189, 101);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(559, 34);
            txtBookName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(189, 149);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(559, 146);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(189, 407);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(559, 34);
            txtAuthor.TabIndex = 6;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookName.Location = new Point(7, 101);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(122, 28);
            lblBookName.TabIndex = 10;
            lblBookName.Text = "Book Name";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPublicationDate.Location = new Point(8, 309);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(170, 28);
            lblPublicationDate.TabIndex = 9;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuantity.Location = new Point(8, 358);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 28);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAuthor.Location = new Point(8, 407);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(78, 28);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrice.Location = new Point(449, 358);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(8, 450);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(98, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(189, 49);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(559, 34);
            txtBookId.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescription.Location = new Point(8, 149);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(121, 28);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookId.Location = new Point(7, 49);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(87, 28);
            lblBookId.TabIndex = 3;
            lblBookId.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblHeader.Location = new Point(3, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(350, 46);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(810, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 57);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(964, 605);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpBookInfo);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grpBookInfo.ResumeLayout(false);
            grpBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grpBookInfo;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private Label lblBookName;
        private Label lblPublicationDate;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtBookId;
        private Label lblDescription;
        private Label lblBookId;
        private Label lblHeader;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategoryId;
        private Button btnCancel;
    }
}