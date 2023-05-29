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
            LabelLoanPeriod = new Label();
            NumericLoanPeriod = new NumericUpDown();
            LabelBorrowLimitHelpText = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericLoanPeriod).BeginInit();
            SuspendLayout();
            // 
            // ComboSelectedBook
            // 
            ComboSelectedBook.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSelectedBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboSelectedBook.FormattingEnabled = true;
            ComboSelectedBook.Location = new Point(366, 70);
            ComboSelectedBook.Name = "ComboSelectedBook";
            ComboSelectedBook.Size = new Size(550, 56);
            ComboSelectedBook.TabIndex = 0;
            // 
            // LabelSelectedBook
            // 
            LabelSelectedBook.AutoSize = true;
            LabelSelectedBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSelectedBook.Location = new Point(64, 78);
            LabelSelectedBook.Name = "LabelSelectedBook";
            LabelSelectedBook.Size = new Size(109, 48);
            LabelSelectedBook.TabIndex = 1;
            LabelSelectedBook.Text = "Book:";
            // 
            // LabelDateBorrowed
            // 
            LabelDateBorrowed.AutoSize = true;
            LabelDateBorrowed.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDateBorrowed.Location = new Point(64, 172);
            LabelDateBorrowed.Name = "LabelDateBorrowed";
            LabelDateBorrowed.Size = new Size(267, 48);
            LabelDateBorrowed.TabIndex = 2;
            LabelDateBorrowed.Text = "Date Borrowed:";
            // 
            // LabelDateReturned
            // 
            LabelDateReturned.AutoSize = true;
            LabelDateReturned.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDateReturned.Location = new Point(64, 265);
            LabelDateReturned.Name = "LabelDateReturned";
            LabelDateReturned.Size = new Size(257, 48);
            LabelDateReturned.TabIndex = 3;
            LabelDateReturned.Text = "Date Returned:";
            // 
            // DatePickerBorrowDate
            // 
            DatePickerBorrowDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DatePickerBorrowDate.Location = new Point(366, 167);
            DatePickerBorrowDate.Name = "DatePickerBorrowDate";
            DatePickerBorrowDate.Size = new Size(550, 55);
            DatePickerBorrowDate.TabIndex = 4;
            // 
            // DatePickerReturnDate
            // 
            DatePickerReturnDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DatePickerReturnDate.Location = new Point(366, 260);
            DatePickerReturnDate.Name = "DatePickerReturnDate";
            DatePickerReturnDate.Size = new Size(550, 55);
            DatePickerReturnDate.TabIndex = 5;
            // 
            // BtnSubmitBorrow
            // 
            BtnSubmitBorrow.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubmitBorrow.Location = new Point(390, 494);
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
            LabelBorrowValidation.Location = new Point(366, 418);
            LabelBorrowValidation.Name = "LabelBorrowValidation";
            LabelBorrowValidation.Size = new Size(169, 32);
            LabelBorrowValidation.TabIndex = 7;
            LabelBorrowValidation.Text = "Validation Text";
            LabelBorrowValidation.Visible = false;
            // 
            // LabelLoanPeriod
            // 
            LabelLoanPeriod.AutoSize = true;
            LabelLoanPeriod.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLoanPeriod.Location = new Point(64, 341);
            LabelLoanPeriod.Name = "LabelLoanPeriod";
            LabelLoanPeriod.Size = new Size(216, 48);
            LabelLoanPeriod.TabIndex = 8;
            LabelLoanPeriod.Text = "Loan Period:";
            // 
            // NumericLoanPeriod
            // 
            NumericLoanPeriod.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumericLoanPeriod.Location = new Point(366, 339);
            NumericLoanPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericLoanPeriod.Name = "NumericLoanPeriod";
            NumericLoanPeriod.Size = new Size(170, 55);
            NumericLoanPeriod.TabIndex = 9;
            NumericLoanPeriod.TextAlign = HorizontalAlignment.Right;
            NumericLoanPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelBorrowLimitHelpText
            // 
            LabelBorrowLimitHelpText.AutoSize = true;
            LabelBorrowLimitHelpText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBorrowLimitHelpText.Location = new Point(55, 27);
            LabelBorrowLimitHelpText.Name = "LabelBorrowLimitHelpText";
            LabelBorrowLimitHelpText.Size = new Size(415, 28);
            LabelBorrowLimitHelpText.TabIndex = 10;
            LabelBorrowLimitHelpText.Text = "Note: Students can only borrow up to 5 books";
            // 
            // FormBorrowBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 610);
            Controls.Add(LabelBorrowLimitHelpText);
            Controls.Add(NumericLoanPeriod);
            Controls.Add(LabelLoanPeriod);
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
            ((System.ComponentModel.ISupportInitialize)NumericLoanPeriod).EndInit();
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
        private Label LabelLoanPeriod;
        private NumericUpDown NumericLoanPeriod;
        private Label LabelBorrowLimitHelpText;
    }
}