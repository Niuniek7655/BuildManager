namespace TomUIPrototype
{
    partial class ClientWindow
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
            this.CompanyClientName = new System.Windows.Forms.Label();
            this.CompanyClientNameInput = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientNameInput = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyClientName
            // 
            this.CompanyClientName.AutoSize = true;
            this.CompanyClientName.Location = new System.Drawing.Point(12, 9);
            this.CompanyClientName.Name = "CompanyClientName";
            this.CompanyClientName.Size = new System.Drawing.Size(95, 17);
            this.CompanyClientName.TabIndex = 0;
            this.CompanyClientName.Text = "Nazwa klienta";
            // 
            // CompanyClientNameInput
            // 
            this.CompanyClientNameInput.Location = new System.Drawing.Point(163, 6);
            this.CompanyClientNameInput.Name = "CompanyClientNameInput";
            this.CompanyClientNameInput.Size = new System.Drawing.Size(201, 22);
            this.CompanyClientNameInput.TabIndex = 1;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(12, 39);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(33, 17);
            this.ClientName.TabIndex = 2;
            this.ClientName.Text = "Imie";
            // 
            // ClientNameInput
            // 
            this.ClientNameInput.Location = new System.Drawing.Point(163, 34);
            this.ClientNameInput.Name = "ClientNameInput";
            this.ClientNameInput.Size = new System.Drawing.Size(201, 22);
            this.ClientNameInput.TabIndex = 3;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 65);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(67, 17);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "Nazwisko";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(163, 62);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(201, 22);
            this.SurnameInput.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 93);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(163, 90);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(201, 22);
            this.EmailInput.TabIndex = 7;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(163, 118);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(201, 22);
            this.PhoneNumberInput.TabIndex = 8;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(163, 146);
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(201, 106);
            this.DescriptionInput.TabIndex = 9;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(12, 121);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(105, 17);
            this.PhoneNumber.TabIndex = 10;
            this.PhoneNumber.Text = "Numer telefonu";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 149);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(145, 17);
            this.Description.TabIndex = 11;
            this.Description.Text = "Informacje dodatkowe";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(163, 258);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(201, 25);
            this.Save.TabIndex = 12;
            this.Save.Text = "Zapisz zmiany";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 297);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.SurnameInput);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.ClientNameInput);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.CompanyClientNameInput);
            this.Controls.Add(this.CompanyClientName);
            this.Name = "ClientWindow";
            this.Text = "Okno klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyClientName;
        private System.Windows.Forms.TextBox CompanyClientNameInput;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.TextBox ClientNameInput;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button Save;
    }
}