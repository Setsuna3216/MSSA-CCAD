namespace Assignment_4._1
{
    partial class Form1
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblMobilePhone = new Label();
            lblWorkPhone = new Label();
            lblAddress = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvPhoneBook = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtMobilePhone = new TextBox();
            txtWorkPhone = new TextBox();
            txtAddress = new TextBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(45, 141);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(108, 24);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(45, 192);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(105, 24);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblMobilePhone
            // 
            lblMobilePhone.AutoSize = true;
            lblMobilePhone.Location = new Point(45, 248);
            lblMobilePhone.Name = "lblMobilePhone";
            lblMobilePhone.Size = new Size(134, 24);
            lblMobilePhone.TabIndex = 2;
            lblMobilePhone.Text = "Mobile Phone:";
            lblMobilePhone.Click += label3_Click;
            // 
            // lblWorkPhone
            // 
            lblWorkPhone.AutoSize = true;
            lblWorkPhone.Location = new Point(45, 306);
            lblWorkPhone.Name = "lblWorkPhone";
            lblWorkPhone.Size = new Size(119, 24);
            lblWorkPhone.TabIndex = 3;
            lblWorkPhone.Text = "Work Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(45, 360);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(84, 24);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            lblAddress.Click += label5_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 468);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(199, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(803, 468);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvPhoneBook
            // 
            dgvPhoneBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhoneBook.Location = new Point(45, 528);
            dgvPhoneBook.Name = "dgvPhoneBook";
            dgvPhoneBook.RowHeadersWidth = 62;
            dgvPhoneBook.Size = new Size(870, 592);
            dgvPhoneBook.TabIndex = 9;
            dgvPhoneBook.CellContentClick += dgvDisplayAll_CellContentClick;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(199, 138);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 30);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(199, 189);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 30);
            txtLastName.TabIndex = 11;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(199, 245);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(150, 30);
            txtMobilePhone.TabIndex = 12;
            // 
            // txtWorkPhone
            // 
            txtWorkPhone.Location = new Point(199, 303);
            txtWorkPhone.Name = "txtWorkPhone";
            txtWorkPhone.Size = new Size(150, 30);
            txtWorkPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(199, 357);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 30);
            txtAddress.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 24);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Phone Book";
            lblTitle.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 1148);
            Controls.Add(lblTitle);
            Controls.Add(txtAddress);
            Controls.Add(txtWorkPhone);
            Controls.Add(txtMobilePhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dgvPhoneBook);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblAddress);
            Controls.Add(lblWorkPhone);
            Controls.Add(lblMobilePhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblMobilePhone;
        private Label lblWorkPhone;
        private Label lblAddress;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvPhoneBook;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtMobilePhone;
        private TextBox txtWorkPhone;
        private TextBox txtAddress;
        private Label lblTitle;
    }
}
