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
            this.AddDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddDataPanel = new System.Windows.Forms.Panel();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AddDataTableLayoutPanel.SuspendLayout();
            this.AddDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDataTableLayoutPanel
            // 
            this.AddDataTableLayoutPanel.ColumnCount = 1;
            this.AddDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddDataTableLayoutPanel.Controls.Add(this.AddDataPanel, 0, 0);
            this.AddDataTableLayoutPanel.Controls.Add(this.ButtonsPanel, 0, 1);
            this.AddDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AddDataTableLayoutPanel.Name = "AddDataTableLayoutPanel";
            this.AddDataTableLayoutPanel.RowCount = 2;
            this.AddDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.51026F));
            this.AddDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48974F));
            this.AddDataTableLayoutPanel.Size = new System.Drawing.Size(509, 341);
            this.AddDataTableLayoutPanel.TabIndex = 0;
            // 
            // AddDataPanel
            // 
            this.AddDataPanel.Controls.Add(this.AddPhotoButton);
            this.AddDataPanel.Controls.Add(this.DateTimePicker);
            this.AddDataPanel.Controls.Add(this.VKTextBox);
            this.AddDataPanel.Controls.Add(this.VKLabel);
            this.AddDataPanel.Controls.Add(this.DateOfBirthLabel);
            this.AddDataPanel.Controls.Add(this.PhoneNumberTextBox);
            this.AddDataPanel.Controls.Add(this.PhoneNumberLabel);
            this.AddDataPanel.Controls.Add(this.EmailTextBox);
            this.AddDataPanel.Controls.Add(this.EmailLabel);
            this.AddDataPanel.Controls.Add(this.FullNameTextBox);
            this.AddDataPanel.Controls.Add(this.FullNameLabel);
            this.AddDataPanel.Controls.Add(this.PhotoPictureBox);
            this.AddDataPanel.Location = new System.Drawing.Point(3, 3);
            this.AddDataPanel.Name = "AddDataPanel";
            this.AddDataPanel.Size = new System.Drawing.Size(503, 289);
            this.AddDataPanel.TabIndex = 0;
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(42, 115);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.TabIndex = 12;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            this.AddPhotoButton.MouseHover += new System.EventHandler(this.AddPhotoButton_MouseHover);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(118, 191);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.DateTimePicker.TabIndex = 11;
            this.DateTimePicker.Value = new System.DateTime(2023, 3, 27, 0, 0, 0, 0);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(118, 241);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(183, 20);
            this.VKTextBox.TabIndex = 10;
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 225);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 175);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 142);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(183, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 126);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(118, 89);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(376, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 73);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 36);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(376, 20);
            this.FullNameTextBox.TabIndex = 2;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 20);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(9, 9);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsPanel.Controls.Add(this.CancelButton);
            this.ButtonsPanel.Controls.Add(this.OKButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 298);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(503, 40);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(419, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(338, 8);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 341);
            this.Controls.Add(this.AddDataTableLayoutPanel);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.AddDataTableLayoutPanel.ResumeLayout(false);
            this.AddDataPanel.ResumeLayout(false);
            this.AddDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddDataTableLayoutPanel;
        private System.Windows.Forms.Panel AddDataPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.PictureBox AddPhotoButton;
    }
}