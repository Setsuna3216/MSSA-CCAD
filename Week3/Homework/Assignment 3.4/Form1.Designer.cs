namespace Assignment_3._4
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
            lblName = new Label();
            lblPrice = new Label();
            lblSize = new Label();
            lblRoast = new Label();
            chkMilk = new CheckBox();
            dgvCoffee = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            txtPrice = new TextBox();
            cmbSize = new ComboBox();
            cmbRoast = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCoffee).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(64, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 24);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.Click += label1_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(64, 147);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 24);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price:";
            lblPrice.Click += label2_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(64, 233);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(48, 24);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size:";
            lblSize.Click += label3_Click;
            // 
            // lblRoast
            // 
            lblRoast.AutoSize = true;
            lblRoast.Location = new Point(64, 311);
            lblRoast.Name = "lblRoast";
            lblRoast.Size = new Size(62, 24);
            lblRoast.TabIndex = 3;
            lblRoast.Text = "Roast:";
            // 
            // chkMilk
            // 
            chkMilk.AutoSize = true;
            chkMilk.Location = new Point(64, 409);
            chkMilk.Name = "chkMilk";
            chkMilk.Size = new Size(111, 28);
            chkMilk.TabIndex = 4;
            chkMilk.Text = "Has Milk";
            chkMilk.UseVisualStyleBackColor = true;
            // 
            // dgvCoffee
            // 
            dgvCoffee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoffee.Location = new Point(64, 623);
            dgvCoffee.Name = "dgvCoffee";
            dgvCoffee.RowHeadersWidth = 62;
            dgvCoffee.Size = new Size(707, 299);
            dgvCoffee.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(63, 514);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(271, 514);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(132, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(132, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 30);
            txtPrice.TabIndex = 9;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(132, 230);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(182, 32);
            cmbSize.TabIndex = 10;
            // 
            // cmbRoast
            // 
            cmbRoast.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoast.FormattingEnabled = true;
            cmbRoast.Location = new Point(132, 308);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(182, 32);
            cmbRoast.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 944);
            Controls.Add(cmbRoast);
            Controls.Add(cmbSize);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCoffee);
            Controls.Add(chkMilk);
            Controls.Add(lblRoast);
            Controls.Add(lblSize);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private Label lblSize;
        private Label lblRoast;
        private CheckBox chkMilk;
        private DataGridView dgvCoffee;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbSize;
        private ComboBox cmbRoast;
    }
}
