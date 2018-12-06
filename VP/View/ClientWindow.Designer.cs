namespace VP.View
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
            this.companyClientName = new System.Windows.Forms.Label();
            this.companyClientNameInput = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.Label();
            this.clientNameInput = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.clientDescriptionInput = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.clientDescription = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyClientName
            // 
            this.companyClientName.AutoSize = true;
            this.companyClientName.Location = new System.Drawing.Point(12, 9);
            this.companyClientName.Name = "companyClientName";
            this.companyClientName.Size = new System.Drawing.Size(95, 17);
            this.companyClientName.TabIndex = 0;
            this.companyClientName.Text = "Nazwa klienta";
            // 
            // companyClientNameInput
            // 
            this.companyClientNameInput.Location = new System.Drawing.Point(163, 6);
            this.companyClientNameInput.Name = "companyClientNameInput";
            this.companyClientNameInput.Size = new System.Drawing.Size(201, 22);
            this.companyClientNameInput.TabIndex = 1;
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Location = new System.Drawing.Point(12, 37);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(33, 17);
            this.clientName.TabIndex = 2;
            this.clientName.Text = "Imie";
            // 
            // clientNameInput
            // 
            this.clientNameInput.Location = new System.Drawing.Point(163, 34);
            this.clientNameInput.Name = "clientNameInput";
            this.clientNameInput.Size = new System.Drawing.Size(201, 22);
            this.clientNameInput.TabIndex = 3;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(12, 65);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(67, 17);
            this.surname.TabIndex = 4;
            this.surname.Text = "Nazwisko";
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(163, 62);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(201, 22);
            this.surnameInput.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 93);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 17);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(163, 90);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(201, 22);
            this.emailInput.TabIndex = 7;
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(163, 118);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(201, 22);
            this.phoneNumberInput.TabIndex = 8;
            // 
            // clientDescriptionInput
            // 
            this.clientDescriptionInput.Location = new System.Drawing.Point(163, 146);
            this.clientDescriptionInput.Multiline = true;
            this.clientDescriptionInput.Name = "clientDescriptionInput";
            this.clientDescriptionInput.Size = new System.Drawing.Size(201, 106);
            this.clientDescriptionInput.TabIndex = 9;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(12, 121);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(105, 17);
            this.phoneNumber.TabIndex = 10;
            this.phoneNumber.Text = "Numer telefonu";
            // 
            // clientDescription
            // 
            this.clientDescription.AutoSize = true;
            this.clientDescription.Location = new System.Drawing.Point(12, 149);
            this.clientDescription.Name = "clientDescription";
            this.clientDescription.Size = new System.Drawing.Size(145, 17);
            this.clientDescription.TabIndex = 11;
            this.clientDescription.Text = "Informacje dodatkowe";
            // 
            // save
            // 
            this.save.Image = global::VP.Properties.Resources.save_16px;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(163, 258);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(201, 27);
            this.save.TabIndex = 12;
            this.save.Text = "Zapisz zmiany";
            this.save.UseVisualStyleBackColor = true;
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 297);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clientDescription);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.clientDescriptionInput);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.clientNameInput);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.companyClientNameInput);
            this.Controls.Add(this.companyClientName);
            this.Name = "ClientWindow";
            this.Text = "Okno klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyClientName;
        private System.Windows.Forms.TextBox companyClientNameInput;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.TextBox clientNameInput;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.TextBox clientDescriptionInput;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label clientDescription;
        private System.Windows.Forms.Button save;
    }
}