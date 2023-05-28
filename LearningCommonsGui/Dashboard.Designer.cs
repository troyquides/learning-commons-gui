namespace LearningCommonsGui
{
    partial class Dashboard
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
            BtnAddBook = new Button();
            BtnShowBooks = new Button();
            BtnBorrowBook = new Button();
            LabelWelcome = new Label();
            DataGridBorrowList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridBorrowList).BeginInit();
            SuspendLayout();
            // 
            // BtnAddBook
            // 
            BtnAddBook.Location = new Point(94, 142);
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(202, 112);
            BtnAddBook.TabIndex = 0;
            BtnAddBook.Text = "Add Book";
            BtnAddBook.UseVisualStyleBackColor = true;
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // BtnShowBooks
            // 
            BtnShowBooks.Location = new Point(349, 142);
            BtnShowBooks.Name = "BtnShowBooks";
            BtnShowBooks.Size = new Size(202, 112);
            BtnShowBooks.TabIndex = 1;
            BtnShowBooks.Text = "Show Books";
            BtnShowBooks.UseVisualStyleBackColor = true;
            BtnShowBooks.Click += BtnShowBooks_Click;
            // 
            // BtnBorrowBook
            // 
            BtnBorrowBook.Location = new Point(607, 142);
            BtnBorrowBook.Name = "BtnBorrowBook";
            BtnBorrowBook.Size = new Size(202, 112);
            BtnBorrowBook.TabIndex = 2;
            BtnBorrowBook.Text = "Borrow Book";
            BtnBorrowBook.UseVisualStyleBackColor = true;
            BtnBorrowBook.Click += BtnBorrowBook_Click;
            // 
            // LabelWelcome
            // 
            LabelWelcome.AutoSize = true;
            LabelWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LabelWelcome.Location = new Point(214, 34);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.Size = new Size(0, 60);
            LabelWelcome.TabIndex = 3;
            // 
            // DataGridBorrowList
            // 
            DataGridBorrowList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBorrowList.Location = new Point(94, 450);
            DataGridBorrowList.Name = "DataGridBorrowList";
            DataGridBorrowList.RowHeadersWidth = 62;
            DataGridBorrowList.RowTemplate.Height = 33;
            DataGridBorrowList.Size = new Size(715, 225);
            DataGridBorrowList.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 753);
            Controls.Add(DataGridBorrowList);
            Controls.Add(LabelWelcome);
            Controls.Add(BtnBorrowBook);
            Controls.Add(BtnShowBooks);
            Controls.Add(BtnAddBook);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridBorrowList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddBook;
        private Button BtnShowBooks;
        private Button BtnBorrowBook;
        private Label LabelWelcome;
        private DataGridView DataGridBorrowList;
    }
}