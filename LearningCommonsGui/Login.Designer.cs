namespace LearningCommonsGui
{
    partial class LoginForm
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
            TxtIdNumber = new TextBox();
            LabelIdNumber = new Label();
            LabelLoginForm = new Label();
            LabelValidation = new Label();
            SuspendLayout();
            // 
            // TxtIdNumber
            // 
            TxtIdNumber.AcceptsReturn = true;
            TxtIdNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIdNumber.Location = new Point(406, 342);
            TxtIdNumber.Name = "TxtIdNumber";
            TxtIdNumber.Size = new Size(233, 55);
            TxtIdNumber.TabIndex = 0;
            TxtIdNumber.KeyDown += TxtIdNumber_KeyDown;
            // 
            // LabelIdNumber
            // 
            LabelIdNumber.AutoSize = true;
            LabelIdNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelIdNumber.Location = new Point(196, 342);
            LabelIdNumber.Name = "LabelIdNumber";
            LabelIdNumber.Size = new Size(204, 48);
            LabelIdNumber.TabIndex = 1;
            LabelIdNumber.Text = "ID Number:";
            // 
            // LabelLoginForm
            // 
            LabelLoginForm.AutoSize = true;
            LabelLoginForm.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLoginForm.Location = new Point(206, 129);
            LabelLoginForm.Name = "LabelLoginForm";
            LabelLoginForm.Size = new Size(443, 60);
            LabelLoginForm.TabIndex = 2;
            LabelLoginForm.Text = "Enter your ID number";
            // 
            // LabelValidation
            // 
            LabelValidation.AutoSize = true;
            LabelValidation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelValidation.ForeColor = Color.Crimson;
            LabelValidation.Location = new Point(412, 424);
            LabelValidation.Name = "LabelValidation";
            LabelValidation.Size = new Size(153, 45);
            LabelValidation.TabIndex = 3;
            LabelValidation.Text = "Invalid ID";
            LabelValidation.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 634);
            Controls.Add(LabelValidation);
            Controls.Add(LabelLoginForm);
            Controls.Add(LabelIdNumber);
            Controls.Add(TxtIdNumber);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIdNumber;
        private Label LabelIdNumber;
        private Label LabelLoginForm;
        private Label LabelValidation;
    }
}