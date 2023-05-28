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
            SuspendLayout();
            // 
            // BtnAddBook
            // 
            BtnAddBook.Location = new Point(68, 90);
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(202, 112);
            BtnAddBook.TabIndex = 0;
            BtnAddBook.Text = "Add Book";
            BtnAddBook.UseVisualStyleBackColor = true;
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // BtnShowBooks
            // 
            BtnShowBooks.Location = new Point(322, 90);
            BtnShowBooks.Name = "BtnShowBooks";
            BtnShowBooks.Size = new Size(202, 112);
            BtnShowBooks.TabIndex = 1;
            BtnShowBooks.Text = "Show Books";
            BtnShowBooks.UseVisualStyleBackColor = true;
            BtnShowBooks.Click += BtnShowBooks_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 753);
            Controls.Add(BtnShowBooks);
            Controls.Add(BtnAddBook);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddBook;
        private Button BtnShowBooks;
    }
}