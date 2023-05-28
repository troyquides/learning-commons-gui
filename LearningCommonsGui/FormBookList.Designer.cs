namespace LearningCommonsGui
{
    partial class FormBookList
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
            DataGridBookList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridBookList).BeginInit();
            SuspendLayout();
            // 
            // DataGridBookList
            // 
            DataGridBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBookList.Location = new Point(12, 12);
            DataGridBookList.Name = "DataGridBookList";
            DataGridBookList.RowHeadersWidth = 62;
            DataGridBookList.RowTemplate.Height = 33;
            DataGridBookList.Size = new Size(919, 763);
            DataGridBookList.TabIndex = 0;
            // 
            // FormBookList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 787);
            Controls.Add(DataGridBookList);
            Name = "FormBookList";
            Text = "BookList";
            ((System.ComponentModel.ISupportInitialize)DataGridBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridBookList;
    }
}