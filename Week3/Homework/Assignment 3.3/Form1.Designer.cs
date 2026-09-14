namespace Assignment_3._3
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
            lblStudentId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtStudentId = new TextBox();
            lblAdmissionMonth = new Label();
            lbStudentGrade = new Label();
            cmbMonth = new ComboBox();
            cmbStudentGrade = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(36, 25);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(106, 24);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(34, 68);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(108, 24);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(36, 115);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(105, 24);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            lblLastName.Click += label2_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(36, 159);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(84, 24);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(207, 65);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 30);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(207, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 30);
            txtLastName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(207, 156);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 30);
            txtAddress.TabIndex = 7;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(207, 22);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 30);
            txtStudentId.TabIndex = 8;
            // 
            // lblAdmissionMonth
            // 
            lblAdmissionMonth.AutoSize = true;
            lblAdmissionMonth.Location = new Point(34, 204);
            lblAdmissionMonth.Name = "lblAdmissionMonth";
            lblAdmissionMonth.Size = new Size(167, 24);
            lblAdmissionMonth.TabIndex = 9;
            lblAdmissionMonth.Text = "Admission Month:";
            // 
            // lbStudentGrade
            // 
            lbStudentGrade.AutoSize = true;
            lbStudentGrade.Location = new Point(36, 250);
            lbStudentGrade.Name = "lbStudentGrade";
            lbStudentGrade.Size = new Size(66, 24);
            lbStudentGrade.TabIndex = 10;
            lbStudentGrade.Text = "Grade:";
            lbStudentGrade.Click += label1_Click;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(207, 201);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(150, 32);
            cmbMonth.TabIndex = 12;
            // 
            // cmbStudentGrade
            // 
            cmbStudentGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentGrade.FormattingEnabled = true;
            cmbStudentGrade.Location = new Point(207, 247);
            cmbStudentGrade.Name = "cmbStudentGrade";
            cmbStudentGrade.Size = new Size(150, 32);
            cmbStudentGrade.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(291, 308);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(36, 376);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(855, 356);
            dgvStudents.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 877);
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbStudentGrade);
            Controls.Add(cmbMonth);
            Controls.Add(lbStudentGrade);
            Controls.Add(lblAdmissionMonth);
            Controls.Add(txtStudentId);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private Label lblAdmissionMonth;
        private Label lbStudentGrade;
        private ComboBox cmbMonth;
        private ComboBox cmbStudentGrade;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvStudents;
    }
}
