namespace LearningCommonsGui
{
    partial class FormBorrowBook
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
            ComboSelectedBook = new ComboBox();
            LabelSelectedBook = new Label();
            LabelDateBorrowed = new Label();
            LabelDateReturned = new Label();
            DatePickerBorrowDate = new DateTimePicker();
            DatePickerReturnDate = new DateTimePicker();
            BtnSubmitBorrow = new Button();
            LabelBorrowValidation = new Label();
            SuspendLayout();
            // 
            // ComboSelectedBook
            // 
            ComboSelectedBook.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSelectedBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboSelectedBook.FormattingEnabled = true;
            ComboSelectedBook.Location = new Point(367, 42);
            ComboSelectedBook.Name = "ComboSelectedBook";
            ComboSelectedBook.Size = new Size(550, 56);
            ComboSelectedBook.TabIndex = 0;
            // 
            // LabelSelectedBook
            // 
            LabelSelectedBook.AutoSize = true;
            LabelSelectedBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSelectedBook.Location = new Point(65, 50);
            LabelSelectedBook.Name = "LabelSelectedBook";
            LabelSelectedBook.Size = new Size(109, 48);
            LabelSelectedBook.TabIndex = 1;
            LabelSelectedBook.Text = "Book:";
            // 
            // LabelDateBorrowed
            // 
            LabelDateBorrowed.AutoSize = true;
            LabelDateBorrowed.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDateBorrowed.Location = new Point(65, 144);
            LabelDateBorrowed.Name = "LabelDateBorrowed";
            LabelDateBorrowed.Size = new Size(267, 48);
            LabelDateBorrowed.TabIndex = 2;
            LabelDateBorrowed.Text = "Date Borrowed:";
            // 
            // LabelDateReturned
            // 
            LabelDateReturned.AutoSize = true;
            LabelDateReturned.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDateReturned.Location = new Point(65, 237);
            LabelDateReturned.Name = "LabelDateReturned";
            LabelDateReturned.Size = new Size(257, 48);
            LabelDateReturned.TabIndex = 3;
            LabelDateReturned.Text = "Date Returned:";
            // 
            // DatePickerBorrowDate
            // 
            DatePickerBorrowDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DatePickerBorrowDate.Location = new Point(367, 139);
            DatePickerBorrowDate.Name = "DatePickerBorrowDate";
            DatePickerBorrowDate.Size = new Size(550, 55);
            DatePickerBorrowDate.TabIndex = 4;
            // 
            // DatePickerReturnDate
            // 
            DatePickerReturnDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DatePickerReturnDate.Location = new Point(367, 232);
            DatePickerReturnDate.Name = "DatePickerReturnDate";
            DatePickerReturnDate.Size = new Size(550, 55);
            DatePickerReturnDate.TabIndex = 5;
            // 
            // BtnSubmitBorrow
            // 
            BtnSubmitBorrow.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubmitBorrow.Location = new Point(384, 421);
            BtnSubmitBorrow.Name = "BtnSubmitBorrow";
            BtnSubmitBorrow.Size = new Size(189, 72);
            BtnSubmitBorrow.TabIndex = 6;
            BtnSubmitBorrow.Text = "SUBMIT";
            BtnSubmitBorrow.UseVisualStyleBackColor = true;
            BtnSubmitBorrow.Click += BtnSubmitBorrow_Click;
            // 
            // LabelBorrowValidation
            // 
            LabelBorrowValidation.AutoSize = true;
            LabelBorrowValidation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBorrowValidation.ForeColor = Color.Red;
            LabelBorrowValidation.Location = new Point(367, 301);
            LabelBorrowValidation.Name = "LabelBorrowValidation";
            LabelBorrowValidation.Size = new Size(169, 32);
            LabelBorrowValidation.TabIndex = 7;
            LabelBorrowValidation.Text = "Validation Text";
            LabelBorrowValidation.Visible = false;
            // 
            // FormBorrowBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 610);
            Controls.Add(LabelBorrowValidation);
            Controls.Add(BtnSubmitBorrow);
            Controls.Add(DatePickerReturnDate);
            Controls.Add(DatePickerBorrowDate);
            Controls.Add(LabelDateReturned);
            Controls.Add(LabelDateBorrowed);
            Controls.Add(LabelSelectedBook);
            Controls.Add(ComboSelectedBook);
            Name = "FormBorrowBook";
            Text = "Borrow Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboSelectedBook;
        private Label LabelSelectedBook;
        private Label LabelDateBorrowed;
        private Label LabelDateReturned;
        private DateTimePicker DatePickerBorrowDate;
        private DateTimePicker DatePickerReturnDate;
        private Button BtnSubmitBorrow;
        private Label LabelBorrowValidation;
    }
}