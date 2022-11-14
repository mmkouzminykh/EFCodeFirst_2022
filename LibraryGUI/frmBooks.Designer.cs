namespace LibraryGUI
{
    partial class frmBooks
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublishingYear = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblContents = new System.Windows.Forms.Label();
            this.lstContents = new System.Windows.Forms.ListBox();
            this.lstOtherBooks = new System.Windows.Forms.ListBox();
            this.lblOtherBooks = new System.Windows.Forms.Label();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.btnAddContents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(17, 12);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 15);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "<Author>";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Location = new System.Drawing.Point(12, 52);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(183, 214);
            this.lstBooks.TabIndex = 1;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(210, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(210, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 15);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Наимен.";
            // 
            // lblPublishingYear
            // 
            this.lblPublishingYear.AutoSize = true;
            this.lblPublishingYear.Location = new System.Drawing.Point(210, 125);
            this.lblPublishingYear.Name = "lblPublishingYear";
            this.lblPublishingYear.Size = new System.Drawing.Size(50, 15);
            this.lblPublishingYear.TabIndex = 4;
            this.lblPublishingYear.Text = "Год изд.";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(267, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 23);
            this.txtID.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(267, 88);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 23);
            this.txtTitle.TabIndex = 6;
            // 
            // nudPublishingYear
            // 
            this.nudPublishingYear.Location = new System.Drawing.Point(267, 123);
            this.nudPublishingYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudPublishingYear.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.nudPublishingYear.Name = "nudPublishingYear";
            this.nudPublishingYear.Size = new System.Drawing.Size(85, 23);
            this.nudPublishingYear.TabIndex = 7;
            this.nudPublishingYear.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(291, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(12, 278);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(76, 15);
            this.lblContents.TabIndex = 11;
            this.lblContents.Text = "Содержание";
            // 
            // lstContents
            // 
            this.lstContents.FormattingEnabled = true;
            this.lstContents.ItemHeight = 15;
            this.lstContents.Location = new System.Drawing.Point(14, 308);
            this.lstContents.Name = "lstContents";
            this.lstContents.Size = new System.Drawing.Size(181, 139);
            this.lstContents.TabIndex = 12;
            this.lstContents.SelectedIndexChanged += new System.EventHandler(this.lstContents_SelectedIndexChanged);
            // 
            // lstOtherBooks
            // 
            this.lstOtherBooks.FormattingEnabled = true;
            this.lstOtherBooks.ItemHeight = 15;
            this.lstOtherBooks.Location = new System.Drawing.Point(210, 308);
            this.lstOtherBooks.Name = "lstOtherBooks";
            this.lstOtherBooks.Size = new System.Drawing.Size(309, 139);
            this.lstOtherBooks.TabIndex = 13;
            // 
            // lblOtherBooks
            // 
            this.lblOtherBooks.AutoSize = true;
            this.lblOtherBooks.Location = new System.Drawing.Point(210, 278);
            this.lblOtherBooks.Name = "lblOtherBooks";
            this.lblOtherBooks.Size = new System.Drawing.Size(118, 15);
            this.lblOtherBooks.TabIndex = 14;
            this.lblOtherBooks.Text = "Также встречается в";
            // 
            // btnFindBook
            // 
            this.btnFindBook.Location = new System.Drawing.Point(372, 123);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(75, 23);
            this.btnFindBook.TabIndex = 15;
            this.btnFindBook.Text = "Искать";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnAddContents
            // 
            this.btnAddContents.Location = new System.Drawing.Point(210, 243);
            this.btnAddContents.Name = "btnAddContents";
            this.btnAddContents.Size = new System.Drawing.Size(179, 23);
            this.btnAddContents.TabIndex = 16;
            this.btnAddContents.Text = "Добавить произведение";
            this.btnAddContents.UseVisualStyleBackColor = true;
            this.btnAddContents.Click += new System.EventHandler(this.btnAddContents_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 475);
            this.Controls.Add(this.btnAddContents);
            this.Controls.Add(this.btnFindBook);
            this.Controls.Add(this.lblOtherBooks);
            this.Controls.Add(this.lstOtherBooks);
            this.Controls.Add(this.lstContents);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudPublishingYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPublishingYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblAuthor);
            this.Name = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAuthor;
        private ListBox lstBooks;
        private Label lblID;
        private Label lblTitle;
        private Label lblPublishingYear;
        private TextBox txtID;
        private TextBox txtTitle;
        private NumericUpDown nudPublishingYear;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblContents;
        private ListBox lstContents;
        private ListBox lstOtherBooks;
        private Label lblOtherBooks;
        private Button btnFindBook;
        private Button btnAddContents;
    }
}