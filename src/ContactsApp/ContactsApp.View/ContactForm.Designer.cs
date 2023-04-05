namespace ContactsApp.View
{
    partial class ContactForm
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
            this.AddContactLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddContactPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.PlaceHolderPictureBox = new System.Windows.Forms.PictureBox();
            this.AddContactLayoutPanel.SuspendLayout();
            this.AddContactPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceHolderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContactLayoutPanel
            // 
            this.AddContactLayoutPanel.Controls.Add(this.AddContactPanel);
            this.AddContactLayoutPanel.Location = new System.Drawing.Point(-3, -3);
            this.AddContactLayoutPanel.Name = "AddContactLayoutPanel";
            this.AddContactLayoutPanel.Size = new System.Drawing.Size(515, 345);
            this.AddContactLayoutPanel.TabIndex = 0;
            // 
            // AddContactPanel
            // 
            this.AddContactPanel.AccessibleDescription = "";
            this.AddContactPanel.Controls.Add(this.ButtonsPanel);
            this.AddContactPanel.Controls.Add(this.DateOfBirthTimePicker);
            this.AddContactPanel.Controls.Add(this.VKTextBox);
            this.AddContactPanel.Controls.Add(this.VKLabel);
            this.AddContactPanel.Controls.Add(this.DateOfBirthLabel);
            this.AddContactPanel.Controls.Add(this.PhoneNumberTextBox);
            this.AddContactPanel.Controls.Add(this.PhoneNumberLabel);
            this.AddContactPanel.Controls.Add(this.EmailTextBox);
            this.AddContactPanel.Controls.Add(this.EmailLabel);
            this.AddContactPanel.Controls.Add(this.FullNameTextBox);
            this.AddContactPanel.Controls.Add(this.FullNameLabel);
            this.AddContactPanel.Controls.Add(this.AddPhotoButton);
            this.AddContactPanel.Controls.Add(this.PlaceHolderPictureBox);
            this.AddContactPanel.Location = new System.Drawing.Point(3, 3);
            this.AddContactPanel.Name = "AddContactPanel";
            this.AddContactPanel.Size = new System.Drawing.Size(512, 342);
            this.AddContactPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsPanel.Controls.Add(this.CancelButton);
            this.ButtonsPanel.Controls.Add(this.OkButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(-3, 299);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(515, 43);
            this.ButtonsPanel.TabIndex = 13;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(425, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(344, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(118, 191);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthTimePicker.TabIndex = 12;
            this.DateOfBirthTimePicker.Value = new System.DateTime(2000, 3, 6, 0, 0, 0, 0);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(118, 239);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(200, 20);
            this.VKTextBox.TabIndex = 11;
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 223);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 10;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 175);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 143);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneNumberTextBox.TabIndex = 7;
            this.PhoneNumberTextBox.Text = "+7 (999) 654-22-13";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 127);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(118, 92);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(375, 20);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.Text = "osipov@no.mail";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 76);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 42);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(375, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.Text = "Осипов Алексей Даниилович";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 26);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(46, 118);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 1;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // PlaceHolderPictureBox
            // 
            this.PlaceHolderPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PlaceHolderPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PlaceHolderPictureBox.Name = "PlaceHolderPictureBox";
            this.PlaceHolderPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PlaceHolderPictureBox.TabIndex = 0;
            this.PlaceHolderPictureBox.TabStop = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 341);
            this.Controls.Add(this.AddContactLayoutPanel);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.AddContactLayoutPanel.ResumeLayout(false);
            this.AddContactPanel.ResumeLayout(false);
            this.AddContactPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceHolderPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AddContactLayoutPanel;
        private System.Windows.Forms.Panel AddContactPanel;
        private System.Windows.Forms.PictureBox PlaceHolderPictureBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimePicker;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox AddPhotoButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}