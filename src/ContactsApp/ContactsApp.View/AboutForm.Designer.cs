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
            this.AboutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OKPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.CopyrightListBox = new System.Windows.Forms.ListBox();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NoMailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VLabel = new System.Windows.Forms.Label();
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.AllImagesLabel = new System.Windows.Forms.Label();
            this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AboutTableLayoutPanel.SuspendLayout();
            this.OKPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutTableLayoutPanel
            // 
            this.AboutTableLayoutPanel.ColumnCount = 1;
            this.AboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AboutTableLayoutPanel.Controls.Add(this.OKPanel, 0, 1);
            this.AboutTableLayoutPanel.Controls.Add(this.AboutPanel, 0, 0);
            this.AboutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutTableLayoutPanel.Name = "AboutTableLayoutPanel";
            this.AboutTableLayoutPanel.RowCount = 2;
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.55721F));
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.44279F));
            this.AboutTableLayoutPanel.Size = new System.Drawing.Size(510, 402);
            this.AboutTableLayoutPanel.TabIndex = 0;
            // 
            // OKPanel
            // 
            this.OKPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKPanel.Controls.Add(this.OKButton);
            this.OKPanel.Location = new System.Drawing.Point(3, 359);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(504, 40);
            this.OKPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(420, 8);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.IconsLinkLabel);
            this.AboutPanel.Controls.Add(this.AllImagesLabel);
            this.AboutPanel.Controls.Add(this.CopyrightListBox);
            this.AboutPanel.Controls.Add(this.GithubLinkLabel);
            this.AboutPanel.Controls.Add(this.NoMailLabel);
            this.AboutPanel.Controls.Add(this.NameLabel);
            this.AboutPanel.Controls.Add(this.GithubLabel);
            this.AboutPanel.Controls.Add(this.EmailLabel);
            this.AboutPanel.Controls.Add(this.AuthorLabel);
            this.AboutPanel.Controls.Add(this.VLabel);
            this.AboutPanel.Controls.Add(this.ContactsAppLabel);
            this.AboutPanel.Location = new System.Drawing.Point(3, 3);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(504, 350);
            this.AboutPanel.TabIndex = 1;
            // 
            // CopyrightListBox
            // 
            this.CopyrightListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyrightListBox.FormattingEnabled = true;
            this.CopyrightListBox.Items.AddRange(new object[] {
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
            this.CopyrightListBox.Location = new System.Drawing.Point(14, 211);
            this.CopyrightListBox.Name = "CopyrightListBox";
            this.CopyrightListBox.Size = new System.Drawing.Size(481, 108);
            this.CopyrightListBox.TabIndex = 10;
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(114, 177);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(225, 13);
            this.GithubLinkLabel.TabIndex = 8;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https://github.com/NikitaKEKW/ContactsApp";
            // 
            // NoMailLabel
            // 
            this.NoMailLabel.AutoSize = true;
            this.NoMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoMailLabel.Location = new System.Drawing.Point(114, 138);
            this.NoMailLabel.Name = "NoMailLabel";
            this.NoMailLabel.Size = new System.Drawing.Size(128, 15);
            this.NoMailLabel.TabIndex = 6;
            this.NoMailLabel.Text = "danilik.nikita@no.mail";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(114, 104);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Danilik Nikita";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GithubLabel.Location = new System.Drawing.Point(13, 175);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(46, 15);
            this.GithubLabel.TabIndex = 4;
            this.GithubLabel.Text = "Github:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(13, 138);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 15);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(14, 104);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(45, 15);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // VLabel
            // 
            this.VLabel.AutoSize = true;
            this.VLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VLabel.Location = new System.Drawing.Point(14, 53);
            this.VLabel.Name = "VLabel";
            this.VLabel.Size = new System.Drawing.Size(32, 15);
            this.VLabel.TabIndex = 1;
            this.VLabel.Text = "v 1.0";
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.Location = new System.Drawing.Point(9, 28);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(146, 25);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // AllImagesLabel
            // 
            this.AllImagesLabel.AutoSize = true;
            this.AllImagesLabel.BackColor = System.Drawing.Color.White;
            this.AllImagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllImagesLabel.Location = new System.Drawing.Point(14, 322);
            this.AllImagesLabel.Name = "AllImagesLabel";
            this.AllImagesLabel.Size = new System.Drawing.Size(217, 15);
            this.AllImagesLabel.TabIndex = 11;
            this.AllImagesLabel.Text = "All used images are downloaded from ";
            // 
            // IconsLinkLabel
            // 
            this.IconsLinkLabel.AutoSize = true;
            this.IconsLinkLabel.Location = new System.Drawing.Point(225, 324);
            this.IconsLinkLabel.Name = "IconsLinkLabel";
            this.IconsLinkLabel.Size = new System.Drawing.Size(61, 13);
            this.IconsLinkLabel.TabIndex = 12;
            this.IconsLinkLabel.TabStop = true;
            this.IconsLinkLabel.Text = "icons8.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.AboutTableLayoutPanel);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.AboutTableLayoutPanel.ResumeLayout(false);
            this.OKPanel.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AboutTableLayoutPanel;
        private System.Windows.Forms.Panel OKPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label NoMailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VLabel;
        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.ListBox CopyrightListBox;
        private System.Windows.Forms.LinkLabel IconsLinkLabel;
        private System.Windows.Forms.Label AllImagesLabel;
    }
}