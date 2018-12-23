namespace VP.View
{
    partial class LogInWindow
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
            this.Login = new System.Windows.Forms.Label();
            this.LogInInput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LogInToApp = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 9);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // LogInInput
            // 
            this.LogInInput.Location = new System.Drawing.Point(54, 6);
            this.LogInInput.Name = "LogInInput";
            this.LogInInput.Size = new System.Drawing.Size(175, 20);
            this.LogInInput.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 35);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(36, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Hasło";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(54, 32);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(175, 20);
            this.PasswordInput.TabIndex = 3;
            // 
            // LogInToApp
            // 
            this.LogInToApp.Location = new System.Drawing.Point(154, 58);
            this.LogInToApp.Name = "LogInToApp";
            this.LogInToApp.Size = new System.Drawing.Size(75, 23);
            this.LogInToApp.TabIndex = 4;
            this.LogInToApp.Text = "Zaloguj";
            this.LogInToApp.UseVisualStyleBackColor = true;
            this.LogInToApp.Click += new System.EventHandler(this.LogInToApp_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Location = new System.Drawing.Point(54, 57);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(75, 23);
            this.ShowPassword.TabIndex = 5;
            this.ShowPassword.Text = "Pokaz hasło";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseDown);
            this.ShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseUp);
            // 
            // LogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 92);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LogInToApp);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LogInInput);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInWindow";
            this.Text = "Tomix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LogInInput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LogInToApp;
        private System.Windows.Forms.Button ShowPassword;
    }
}

