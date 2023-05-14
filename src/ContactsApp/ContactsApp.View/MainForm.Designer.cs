namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListBoxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FullDataPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdaySurnameLabel = new System.Windows.Forms.Label();
            this.TodaysBirthdayLabel = new System.Windows.Forms.Label();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.DeleteContactButton = new System.Windows.Forms.PictureBox();
            this.EditContactButton = new System.Windows.Forms.PictureBox();
            this.AddContactButton = new System.Windows.Forms.PictureBox();
            this.RandomContactsButton = new System.Windows.Forms.PictureBox();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.Button();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ListBoxTableLayoutPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.FullDataPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomContactsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxTableLayoutPanel
            // 
            this.ListBoxTableLayoutPanel.ColumnCount = 2;
            this.ListBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.ListBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListBoxTableLayoutPanel.Controls.Add(this.ContactsPanel, 0, 0);
            this.ListBoxTableLayoutPanel.Controls.Add(this.FullDataPanel, 1, 0);
            this.ListBoxTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ListBoxTableLayoutPanel.Name = "ListBoxTableLayoutPanel";
            this.ListBoxTableLayoutPanel.RowCount = 1;
            this.ListBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.ListBoxTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.ListBoxTableLayoutPanel.TabIndex = 0;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.Controls.Add(this.ContactsListBox);
            this.ContactsPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ContactsPanel.Controls.Add(this.FindLabel);
            this.ContactsPanel.Controls.Add(this.FindTextBox);
            this.ContactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsPanel.Location = new System.Drawing.Point(3, 3);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(244, 444);
            this.ContactsPanel.TabIndex = 0;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Items.AddRange(new object[] {
            "Агапова Майя Савельевна",
            "Осипов Алексей Даниилович",
            "Голубева Амина Никитична",
            "Кожевников Вадим Алексеевич",
            "Субботин Виктор Романович",
            "Васильев Мирон Матвеевич",
            "Орехов Всеволод Артемьевич",
            "Жукова Вероника Андреевна",
            "Панова София Матвеевна",
            "Пономарев Александр Даниэльевич",
            "Казакова Александра Данииловна",
            "Мальцева Евгения Алексеевна",
            "Князева Ульяна Ивановна",
            "Андреева Ксения Ивановна",
            "Маслов Кирилл Дмитриевич"});
            this.ContactsListBox.Location = new System.Drawing.Point(3, 38);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 366);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 4;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.DeleteContactButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RandomContactsButton, 3, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 404);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(37, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(204, 20);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FullDataPanel
            // 
            this.FullDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullDataPanel.Controls.Add(this.BirthdayPanel);
            this.FullDataPanel.Controls.Add(this.VKTextBox);
            this.FullDataPanel.Controls.Add(this.VKLabel);
            this.FullDataPanel.Controls.Add(this.DateOfBirthTextBox);
            this.FullDataPanel.Controls.Add(this.DateOfBirthLabel);
            this.FullDataPanel.Controls.Add(this.PhoneNumberTextBox);
            this.FullDataPanel.Controls.Add(this.PhoneNumberLabel);
            this.FullDataPanel.Controls.Add(this.EmailTextBox);
            this.FullDataPanel.Controls.Add(this.EmailLabel);
            this.FullDataPanel.Controls.Add(this.FullNameTextBox);
            this.FullDataPanel.Controls.Add(this.FullNameLabel);
            this.FullDataPanel.Controls.Add(this.PhotoPictureBox);
            this.FullDataPanel.Location = new System.Drawing.Point(253, 3);
            this.FullDataPanel.Name = "FullDataPanel";
            this.FullDataPanel.Size = new System.Drawing.Size(544, 444);
            this.FullDataPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.BirthdaySurnameLabel);
            this.BirthdayPanel.Controls.Add(this.TodaysBirthdayLabel);
            this.BirthdayPanel.Controls.Add(this.InfoPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(4, 373);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(537, 68);
            this.BirthdayPanel.TabIndex = 12;
            // 
            // BirthdaySurnameLabel
            // 
            this.BirthdaySurnameLabel.AutoSize = true;
            this.BirthdaySurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdaySurnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnameLabel.Location = new System.Drawing.Point(80, 35);
            this.BirthdaySurnameLabel.Name = "BirthdaySurnameLabel";
            this.BirthdaySurnameLabel.Size = new System.Drawing.Size(216, 13);
            this.BirthdaySurnameLabel.TabIndex = 2;
            this.BirthdaySurnameLabel.Text = "Осипов, Агапова, Пономарев и др.";
            // 
            // TodaysBirthdayLabel
            // 
            this.TodaysBirthdayLabel.AutoSize = true;
            this.TodaysBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodaysBirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.TodaysBirthdayLabel.Location = new System.Drawing.Point(80, 18);
            this.TodaysBirthdayLabel.Name = "TodaysBirthdayLabel";
            this.TodaysBirthdayLabel.Size = new System.Drawing.Size(146, 13);
            this.TodaysBirthdayLabel.TabIndex = 1;
            this.TodaysBirthdayLabel.Text = "Today is the Birthday of:";
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(110, 219);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(150, 20);
            this.VKTextBox.TabIndex = 11;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(110, 203);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 10;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(110, 170);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(150, 20);
            this.DateOfBirthTextBox.TabIndex = 9;
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(110, 154);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(110, 121);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.PhoneNumberTextBox.TabIndex = 7;
            this.PhoneNumberTextBox.Text = "+79996542213";
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(110, 105);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(110, 72);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(431, 20);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.Text = "osipov@no.mail";
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(110, 56);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(111, 23);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(430, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.Text = "Осипов Алексей Даниилович";
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(110, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.DeleteContactButton.Location = new System.Drawing.Point(121, 3);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteContactButton.Size = new System.Drawing.Size(53, 29);
            this.DeleteContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DeleteContactButton.TabIndex = 0;
            this.DeleteContactButton.TabStop = false;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            this.DeleteContactButton.MouseEnter += new System.EventHandler(this.DeleteContactButton_MouseEnter);
            this.DeleteContactButton.MouseLeave += new System.EventHandler(this.DeleteContactButton_MouseLeave);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(62, 3);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(53, 29);
            this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.TabStop = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(3, 3);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(53, 29);
            this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.TabStop = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            // 
            // RandomContactsButton
            // 
            this.RandomContactsButton.Image = global::ContactsApp.View.Properties.Resources.random_contact_32x32_gray;
            this.RandomContactsButton.Location = new System.Drawing.Point(180, 3);
            this.RandomContactsButton.Name = "RandomContactsButton";
            this.RandomContactsButton.Size = new System.Drawing.Size(55, 29);
            this.RandomContactsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RandomContactsButton.TabIndex = 3;
            this.RandomContactsButton.TabStop = false;
            this.RandomContactsButton.Click += new System.EventHandler(this.RandomContactsButton_Click);
            this.RandomContactsButton.MouseEnter += new System.EventHandler(this.RandomContactsButton_MouseEnter);
            this.RandomContactsButton.MouseLeave += new System.EventHandler(this.RandomContactsButton_MouseLeave);
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(499, 3);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.TabIndex = 3;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPictureBox.Location = new System.Drawing.Point(3, 2);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(71, 64);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoPictureBox.TabIndex = 0;
            this.InfoPictureBox.TabStop = false;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(4, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 1;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ListBoxTableLayoutPanel.ResumeLayout(false);
            this.ContactsPanel.ResumeLayout(false);
            this.ContactsPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.FullDataPanel.ResumeLayout(false);
            this.FullDataPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomContactsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ListBoxTableLayoutPanel;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Panel FullDataPanel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BirthdaySurnameLabel;
        private System.Windows.Forms.Label TodaysBirthdayLabel;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.Button BirthdayPanelCloseButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.PictureBox DeleteContactButton;
        private System.Windows.Forms.PictureBox EditContactButton;
        private System.Windows.Forms.PictureBox AddContactButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.PictureBox RandomContactsButton;
    }
}

