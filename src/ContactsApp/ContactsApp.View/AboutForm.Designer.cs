namespace ContactsApp.View
{
    partial class AboutForm
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
            this.AboutLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MyEmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ImagesLabel = new System.Windows.Forms.Label();
            this.LicenseListBox = new System.Windows.Forms.ListBox();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.AboutLayoutPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutLayoutPanel
            // 
            this.AboutLayoutPanel.Controls.Add(this.AboutPanel);
            this.AboutLayoutPanel.Location = new System.Drawing.Point(-5, -2);
            this.AboutLayoutPanel.Name = "AboutLayoutPanel";
            this.AboutLayoutPanel.Size = new System.Drawing.Size(518, 405);
            this.AboutLayoutPanel.TabIndex = 0;
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.GithubLinkLabel);
            this.AboutPanel.Controls.Add(this.MyEmailLabel);
            this.AboutPanel.Controls.Add(this.NameLabel);
            this.AboutPanel.Controls.Add(this.IconsLinkLabel);
            this.AboutPanel.Controls.Add(this.ImagesLabel);
            this.AboutPanel.Controls.Add(this.LicenseListBox);
            this.AboutPanel.Controls.Add(this.GithubLabel);
            this.AboutPanel.Controls.Add(this.EmailLabel);
            this.AboutPanel.Controls.Add(this.AuthorLabel);
            this.AboutPanel.Controls.Add(this.VersionLabel);
            this.AboutPanel.Controls.Add(this.ContactsAppLabel);
            this.AboutPanel.Controls.Add(this.ButtonPanel);
            this.AboutPanel.Location = new System.Drawing.Point(3, 3);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(515, 405);
            this.AboutPanel.TabIndex = 0;
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.LinkVisited = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(139, 181);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(225, 13);
            this.GithubLinkLabel.TabIndex = 11;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https://github.com/NikitaKEKW/ContactsApp";
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // MyEmailLabel
            // 
            this.MyEmailLabel.AutoSize = true;
            this.MyEmailLabel.Location = new System.Drawing.Point(139, 151);
            this.MyEmailLabel.Name = "MyEmailLabel";
            this.MyEmailLabel.Size = new System.Drawing.Size(109, 13);
            this.MyEmailLabel.TabIndex = 10;
            this.MyEmailLabel.Text = "nikita.danilik@no.mail";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(139, 122);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Nikita Danilik";
            // 
            // IconsLinkLabel
            // 
            this.IconsLinkLabel.AutoSize = true;
            this.IconsLinkLabel.LinkVisited = true;
            this.IconsLinkLabel.Location = new System.Drawing.Point(202, 327);
            this.IconsLinkLabel.Name = "IconsLinkLabel";
            this.IconsLinkLabel.Size = new System.Drawing.Size(61, 13);
            this.IconsLinkLabel.TabIndex = 8;
            this.IconsLinkLabel.TabStop = true;
            this.IconsLinkLabel.Text = "icons8.com";
            this.IconsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconsLinkLabel_LinkClicked);
            // 
            // ImagesLabel
            // 
            this.ImagesLabel.AutoSize = true;
            this.ImagesLabel.Location = new System.Drawing.Point(23, 327);
            this.ImagesLabel.Name = "ImagesLabel";
            this.ImagesLabel.Size = new System.Drawing.Size(182, 13);
            this.ImagesLabel.TabIndex = 7;
            this.ImagesLabel.Text = "All used images are downloaded from";
            // 
            // LicenseListBox
            // 
            this.LicenseListBox.FormattingEnabled = true;
            this.LicenseListBox.Items.AddRange(new object[] {
            "Copyright (c) 2023 Nikita Danilik",
            "",
            "Permission is hereby granted, free of charge, to any person obtaining a copy of t" +
                "his",
            "software and associated documentation files (the \"Software\"), to deal in the ",
            "Software without restriction, including without limitation the rights to use, cop" +
                "y, ",
            "modify, merge, publish, distribute, sublicense, and/or sell copies of the Softwar" +
                "e, ",
            "and to permit persons to whom the Software is furnished to do so, subject to the " +
                "",
            "following conditions:",
            "",
            "The above copyright notice and this permission notice shall be included in all co" +
                "pies",
            "or substantial portions of the Software.",
            "",
            "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND,",
            "EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF ",
            "MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND ",
            "NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS ",
            "BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ",
            "ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN ",
            "CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE ",
            "SOFTWARE. "});
            this.LicenseListBox.Location = new System.Drawing.Point(23, 212);
            this.LicenseListBox.Name = "LicenseListBox";
            this.LicenseListBox.Size = new System.Drawing.Size(477, 108);
            this.LicenseListBox.TabIndex = 6;
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(20, 181);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(41, 13);
            this.GithubLabel.TabIndex = 5;
            this.GithubLabel.Text = "Github:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(20, 151);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(20, 122);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(20, 83);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "v 1.0";
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.Location = new System.Drawing.Point(14, 48);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(171, 31);
            this.ContactsAppLabel.TabIndex = 1;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonPanel.Controls.Add(this.OKButton);
            this.ButtonPanel.Location = new System.Drawing.Point(-3, 353);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(518, 49);
            this.ButtonPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(428, 14);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.AboutLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.AboutLayoutPanel.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AboutLayoutPanel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.Label MyEmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.LinkLabel IconsLinkLabel;
        private System.Windows.Forms.Label ImagesLabel;
        private System.Windows.Forms.ListBox LicenseListBox;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Button OKButton;
    }
}