namespace LearningCommonsGui
{
    partial class FormAddBook
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
            LabelBookTitle = new Label();
            LabelBookAuthor = new Label();
            TxtBookTitle = new TextBox();
            TxtBookAuthor = new TextBox();
            BtnSubmitBook = new Button();
            LabelIsbn = new Label();
            TxtIsbn = new TextBox();
            LabelBookValidation = new Label();
            SuspendLayout();
            // 
            // LabelBookTitle
            // 
            LabelBookTitle.AutoSize = true;
            LabelBookTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBookTitle.Location = new Point(103, 85);
            LabelBookTitle.Name = "LabelBookTitle";
            LabelBookTitle.Size = new Size(96, 48);
            LabelBookTitle.TabIndex = 0;
            LabelBookTitle.Text = "Title:";
            // 
            // LabelBookAuthor
            // 
            LabelBookAuthor.AutoSize = true;
            LabelBookAuthor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBookAuthor.Location = new Point(103, 179);
            LabelBookAuthor.Name = "LabelBookAuthor";
            LabelBookAuthor.Size = new Size(137, 48);
            LabelBookAuthor.TabIndex = 1;
            LabelBookAuthor.Text = "Author:";
            // 
            // TxtBookTitle
            // 
            TxtBookTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBookTitle.Location = new Point(272, 85);
            TxtBookTitle.Name = "TxtBookTitle";
            TxtBookTitle.Size = new Size(418, 55);
            TxtBookTitle.TabIndex = 2;
            // 
            // TxtBookAuthor
            // 
            TxtBookAuthor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBookAuthor.Location = new Point(272, 179);
            TxtBookAuthor.Name = "TxtBookAuthor";
            TxtBookAuthor.Size = new Size(418, 55);
            TxtBookAuthor.TabIndex = 3;
            // 
            // BtnSubmitBook
            // 
            BtnSubmitBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubmitBook.Location = new Point(272, 456);
            BtnSubmitBook.Name = "BtnSubmitBook";
            BtnSubmitBook.Size = new Size(275, 69);
            BtnSubmitBook.TabIndex = 5;
            BtnSubmitBook.Text = "SUBMIT";
            BtnSubmitBook.UseVisualStyleBackColor = true;
            BtnSubmitBook.Click += BtnSubmitBook_Click;
            // 
            // LabelIsbn
            // 
            LabelIsbn.AutoSize = true;
            LabelIsbn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelIsbn.Location = new Point(103, 282);
            LabelIsbn.Name = "LabelIsbn";
            LabelIsbn.Size = new Size(105, 48);
            LabelIsbn.TabIndex = 5;
            LabelIsbn.Text = "ISBN:";
            // 
            // TxtIsbn
            // 
            TxtIsbn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIsbn.Location = new Point(272, 282);
            TxtIsbn.Name = "TxtIsbn";
            TxtIsbn.Size = new Size(418, 55);
            TxtIsbn.TabIndex = 4;
            // 
            // LabelBookValidation
            // 
            LabelBookValidation.AutoSize = true;
            LabelBookValidation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBookValidation.ForeColor = Color.Red;
            LabelBookValidation.Location = new Point(272, 340);
            LabelBookValidation.Name = "LabelBookValidation";
            LabelBookValidation.Size = new Size(173, 32);
            LabelBookValidation.TabIndex = 8;
            LabelBookValidation.Text = "Duplicate ISBN";
            LabelBookValidation.Visible = false;
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 622);
            Controls.Add(LabelBookValidation);
            Controls.Add(TxtIsbn);
            Controls.Add(LabelIsbn);
            Controls.Add(BtnSubmitBook);
            Controls.Add(TxtBookAuthor);
            Controls.Add(TxtBookTitle);
            Controls.Add(LabelBookAuthor);
            Controls.Add(LabelBookTitle);
            Name = "FormAddBook";
            Text = "FormAddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelBookTitle;
        private Label LabelBookAuthor;
        private TextBox TxtBookTitle;
        private TextBox TxtBookAuthor;
        private Button BtnSubmitBook;
        private Label LabelIsbn;
        private TextBox TxtIsbn;
        private Label LabelBookValidation;
    }
}