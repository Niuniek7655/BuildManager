namespace VP.View
{
    partial class WorkerWindow
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
            this.workerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.priceForHour = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Location = new System.Drawing.Point(12, 12);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(33, 17);
            this.workerName.TabIndex = 0;
            this.workerName.Text = "Imie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 1;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(12, 40);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(67, 17);
            this.surname.TabIndex = 2;
            this.surname.Text = "Nazwisko";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(12, 68);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(56, 17);
            this.phone.TabIndex = 3;
            this.phone.Text = "Telefon";
            // 
            // priceForHour
            // 
            this.priceForHour.AutoSize = true;
            this.priceForHour.Location = new System.Drawing.Point(12, 95);
            this.priceForHour.Name = "priceForHour";
            this.priceForHour.Size = new System.Drawing.Size(126, 17);
            this.priceForHour.TabIndex = 4;
            this.priceForHour.Text = "Stawka za godzinę";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 22);
            this.textBox3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(163, 93);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(201, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // save
            // 
            this.save.Image = global::VP.Properties.Resources.save_16px;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(163, 233);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(201, 27);
            this.save.TabIndex = 8;
            this.save.Text = "Zapisz zmiany";
            this.save.UseVisualStyleBackColor = true;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(163, 121);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(201, 106);
            this.descriptionInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Informacje dodatkowe";
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.save);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.priceForHour);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.workerName);
            this.Name = "WorkerWindow";
            this.Text = "Okno pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label priceForHour;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label4;
    }
}