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
            LabelBorrowHistoryList = new Label();
            LabelPenaltyText = new Label();
            LabelPenaltyValue = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridBorrowList).BeginInit();
            SuspendLayout();
            // 
            // BtnAddBook
            // 
            BtnAddBook.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            BtnShowBooks.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            BtnBorrowBook.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            DataGridBorrowList.AllowUserToAddRows = false;
            DataGridBorrowList.AllowUserToDeleteRows = false;
            DataGridBorrowList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBorrowList.Location = new Point(94, 356);
            DataGridBorrowList.Name = "DataGridBorrowList";
            DataGridBorrowList.ReadOnly = true;
            DataGridBorrowList.RowHeadersWidth = 62;
            DataGridBorrowList.RowTemplate.Height = 33;
            DataGridBorrowList.Size = new Size(715, 225);
            DataGridBorrowList.TabIndex = 4;
            // 
            // LabelBorrowHistoryList
            // 
            LabelBorrowHistoryList.AutoSize = true;
            LabelBorrowHistoryList.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBorrowHistoryList.Location = new Point(94, 312);
            LabelBorrowHistoryList.Name = "LabelBorrowHistoryList";
            LabelBorrowHistoryList.Size = new Size(185, 36);
            LabelBorrowHistoryList.TabIndex = 5;
            LabelBorrowHistoryList.Text = "Borrow History";
            // 
            // LabelPenaltyText
            // 
            LabelPenaltyText.AutoSize = true;
            LabelPenaltyText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPenaltyText.Location = new Point(94, 639);
            LabelPenaltyText.Name = "LabelPenaltyText";
            LabelPenaltyText.Size = new Size(166, 36);
            LabelPenaltyText.TabIndex = 6;
            LabelPenaltyText.Text = "Total Penalty:";
            // 
            // LabelPenaltyValue
            // 
            LabelPenaltyValue.AutoSize = true;
            LabelPenaltyValue.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPenaltyValue.Location = new Point(266, 639);
            LabelPenaltyValue.Name = "LabelPenaltyValue";
            LabelPenaltyValue.Size = new Size(29, 36);
            LabelPenaltyValue.TabIndex = 7;
            LabelPenaltyValue.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 753);
            Controls.Add(LabelPenaltyValue);
            Controls.Add(LabelPenaltyText);
            Controls.Add(LabelBorrowHistoryList);
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
        private Label LabelBorrowHistoryList;
        private Label LabelPenaltyText;
        private Label LabelPenaltyValue;
    }
}