namespace Calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 86);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 50);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(108, 86);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 50);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(204, 86);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 50);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 142);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 50);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(108, 142);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 50);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(204, 142);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 50);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 198);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 50);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(108, 198);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 50);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(204, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 50);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(12, 254);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(90, 50);
            btnDecimal.TabIndex = 9;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += NumberButton_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(108, 254);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(204, 254);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 50);
            btnEqual.TabIndex = 11;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(300, 86);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 50);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += opreation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(300, 142);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 50);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += opreation_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(300, 198);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 50);
            btnSubtract.TabIndex = 14;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += opreation_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 50);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += opreation_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Microsoft YaHei UI", 24F);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(378, 68);
            txtDisplay.TabIndex = 16;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 337);
            Controls.Add(txtDisplay);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnEqual);
            Controls.Add(btn0);
            Controls.Add(btnDecimal);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDecimal;
        private Button btn0;
        private Button btnEqual;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private TextBox txtDisplay;
    }
}
