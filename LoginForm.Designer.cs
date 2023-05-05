namespace task_tracker
{
    partial class LoginForm
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(151, 374);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(200, 52);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            //this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 537);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
    }
}