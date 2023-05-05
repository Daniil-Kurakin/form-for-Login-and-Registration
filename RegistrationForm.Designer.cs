namespace task_tracker
{
    partial class RegistrationForm
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(226, 345);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(284, 61);
            this.RegistrationButton.TabIndex = 0;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(226, 212);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(319, 22);
            this.Email.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(226, 255);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(319, 22);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(226, 121);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(319, 22);
            this.FirstName.TabIndex = 3;
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(226, 167);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(319, 22);
            this.SecondName.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 459);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.RegistrationButton);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SecondName;
    }
}