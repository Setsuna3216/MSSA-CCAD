namespace PhoneBook
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
            phonebookGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)phonebookGrid).BeginInit();
            SuspendLayout();
            // 
            // phonebookGrid
            // 
            phonebookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phonebookGrid.Location = new Point(190, 78);
            phonebookGrid.Name = "phonebookGrid";
            phonebookGrid.Size = new Size(414, 199);
            phonebookGrid.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phonebookGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)phonebookGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView phonebookGrid;
    }
}
