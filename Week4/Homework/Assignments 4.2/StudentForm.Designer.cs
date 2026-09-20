namespace Assignments_4._2
{
    partial class StudentForm
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
            lblStudentId = new Label();
            lblStudentName = new Label();
            lblGpa = new Label();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            dgvStudent = new DataGridView();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            txtGpa = new TextBox();
            btnSaveHighest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(161, 153);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(106, 24);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(161, 223);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(139, 24);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(161, 296);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(51, 24);
            lblGpa.TabIndex = 2;
            lblGpa.Text = "GPA:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(161, 409);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(156, 34);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(342, 409);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(156, 34);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(47, 540);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.Size = new Size(797, 411);
            dgvStudent.TabIndex = 5;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(306, 150);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 30);
            txtStudentId.TabIndex = 6;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(306, 220);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(150, 30);
            txtStudentName.TabIndex = 7;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(306, 293);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(150, 30);
            txtGpa.TabIndex = 8;
            // 
            // btnSaveHighest
            // 
            btnSaveHighest.Location = new Point(528, 409);
            btnSaveHighest.Name = "btnSaveHighest";
            btnSaveHighest.Size = new Size(190, 34);
            btnSaveHighest.TabIndex = 9;
            btnSaveHighest.Text = "Save Highest GPA";
            btnSaveHighest.UseVisualStyleBackColor = true;
            btnSaveHighest.Click += btnSaveHighest_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 1129);
            Controls.Add(btnSaveHighest);
            Controls.Add(txtGpa);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentId);
            Controls.Add(dgvStudent);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(lblGpa);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentId);
            Name = "StudentForm";
            Text = "StudentForm";
            FormClosed += StudentForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private Label lblStudentName;
        private Label lblGpa;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private DataGridView dgvStudent;
        private TextBox txtStudentId;
        private TextBox txtStudentName;
        private TextBox txtGpa;
        private Button btnSaveHighest;
    }
}