namespace Complexite
{
    partial class cryptageForm
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
            this.keyText = new MetroFramework.Controls.MetroTextBox();
            this.KeyLabel = new MetroFramework.Controls.MetroLabel();
            this.CrypterBtn = new MetroFramework.Controls.MetroButton();
            this.CryptedText = new MetroFramework.Controls.MetroTextBox();
            this.StringCryptedLabel = new MetroFramework.Controls.MetroLabel();
            this.chaineNoCrypteLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.chaineText = new MetroFramework.Controls.MetroTextBox();
            this.rdBtn1 = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtn2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rdBtn3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rdBtn4 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // keyText
            // 
            this.keyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.keyText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.keyText.CustomButton.Image = null;
            this.keyText.CustomButton.Location = new System.Drawing.Point(501, 1);
            this.keyText.CustomButton.Name = "";
            this.keyText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyText.CustomButton.TabIndex = 1;
            this.keyText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyText.CustomButton.UseSelectable = true;
            this.keyText.CustomButton.Visible = false;
            this.keyText.Lines = new string[0];
            this.keyText.Location = new System.Drawing.Point(134, 147);
            this.keyText.MaxLength = 32767;
            this.keyText.Name = "keyText";
            this.keyText.PasswordChar = '*';
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyText.SelectedText = "";
            this.keyText.SelectionLength = 0;
            this.keyText.SelectionStart = 0;
            this.keyText.ShortcutsEnabled = true;
            this.keyText.Size = new System.Drawing.Size(523, 23);
            this.keyText.TabIndex = 1;
            this.keyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyText.UseSelectable = true;
            this.keyText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // KeyLabel
            // 
            this.KeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(134, 125);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(28, 19);
            this.KeyLabel.TabIndex = 1;
            this.KeyLabel.Text = "Clé";
            // 
            // CrypterBtn
            // 
            this.CrypterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CrypterBtn.Location = new System.Drawing.Point(356, 188);
            this.CrypterBtn.Name = "CrypterBtn";
            this.CrypterBtn.Size = new System.Drawing.Size(115, 43);
            this.CrypterBtn.TabIndex = 3;
            this.CrypterBtn.Text = "Crypter";
            this.CrypterBtn.UseSelectable = true;
            this.CrypterBtn.Click += new System.EventHandler(this.CrypterBtn_Click);
            // 
            // CryptedText
            // 
            this.CryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CryptedText.CustomButton.Image = null;
            this.CryptedText.CustomButton.Location = new System.Drawing.Point(375, 1);
            this.CryptedText.CustomButton.Name = "";
            this.CryptedText.CustomButton.Size = new System.Drawing.Size(147, 147);
            this.CryptedText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CryptedText.CustomButton.TabIndex = 1;
            this.CryptedText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CryptedText.CustomButton.UseSelectable = true;
            this.CryptedText.CustomButton.Visible = false;
            this.CryptedText.Lines = new string[0];
            this.CryptedText.Location = new System.Drawing.Point(134, 269);
            this.CryptedText.MaxLength = 32767;
            this.CryptedText.Multiline = true;
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.PasswordChar = '\0';
            this.CryptedText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CryptedText.SelectedText = "";
            this.CryptedText.SelectionLength = 0;
            this.CryptedText.SelectionStart = 0;
            this.CryptedText.ShortcutsEnabled = true;
            this.CryptedText.Size = new System.Drawing.Size(523, 149);
            this.CryptedText.TabIndex = 4;
            this.CryptedText.UseSelectable = true;
            this.CryptedText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CryptedText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StringCryptedLabel
            // 
            this.StringCryptedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StringCryptedLabel.AutoSize = true;
            this.StringCryptedLabel.Location = new System.Drawing.Point(134, 247);
            this.StringCryptedLabel.Name = "StringCryptedLabel";
            this.StringCryptedLabel.Size = new System.Drawing.Size(90, 19);
            this.StringCryptedLabel.TabIndex = 4;
            this.StringCryptedLabel.Text = "Chaine crypté";
            // 
            // chaineNoCrypteLabel
            // 
            this.chaineNoCrypteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chaineNoCrypteLabel.AutoSize = true;
            this.chaineNoCrypteLabel.BackColor = System.Drawing.Color.Transparent;
            this.chaineNoCrypteLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.chaineNoCrypteLabel.ForeColor = System.Drawing.Color.Transparent;
            this.chaineNoCrypteLabel.Location = new System.Drawing.Point(134, 74);
            this.chaineNoCrypteLabel.Name = "chaineNoCrypteLabel";
            this.chaineNoCrypteLabel.Size = new System.Drawing.Size(109, 19);
            this.chaineNoCrypteLabel.TabIndex = 5;
            this.chaineNoCrypteLabel.Text = "Chaine a crypter";
            this.chaineNoCrypteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(16, 74);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(96, 81);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Crypteage";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(17, 182);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(95, 84);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Décryptage";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // chaineText
            // 
            // 
            // 
            // 
            this.chaineText.CustomButton.Image = null;
            this.chaineText.CustomButton.Location = new System.Drawing.Point(501, 1);
            this.chaineText.CustomButton.Name = "";
            this.chaineText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.chaineText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chaineText.CustomButton.TabIndex = 1;
            this.chaineText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chaineText.CustomButton.UseSelectable = true;
            this.chaineText.CustomButton.Visible = false;
            this.chaineText.Lines = new string[0];
            this.chaineText.Location = new System.Drawing.Point(134, 96);
            this.chaineText.MaxLength = 32767;
            this.chaineText.Name = "chaineText";
            this.chaineText.PasswordChar = '\0';
            this.chaineText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chaineText.SelectedText = "";
            this.chaineText.SelectionLength = 0;
            this.chaineText.SelectionStart = 0;
            this.chaineText.ShortcutsEnabled = true;
            this.chaineText.Size = new System.Drawing.Size(523, 23);
            this.chaineText.TabIndex = 8;
            this.chaineText.UseSelectable = true;
            this.chaineText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chaineText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdBtn1.Checked = true;
            this.rdBtn1.Location = new System.Drawing.Point(10, 303);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(73, 15);
            this.rdBtn1.TabIndex = 9;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "Crypter_1";
            this.rdBtn1.UseSelectable = true;
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdBtn2.Location = new System.Drawing.Point(10, 324);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(73, 15);
            this.rdBtn2.TabIndex = 10;
            this.rdBtn2.Text = "Crypter_2";
            this.rdBtn2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 281);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Gril A";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 353);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Gril B";
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Location = new System.Drawing.Point(10, 375);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(73, 15);
            this.rdBtn3.TabIndex = 13;
            this.rdBtn3.Text = "Crypter_3";
            this.rdBtn3.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 399);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Another idea";
            // 
            // rdBtn4
            // 
            this.rdBtn4.AutoSize = true;
            this.rdBtn4.Location = new System.Drawing.Point(10, 421);
            this.rdBtn4.Name = "rdBtn4";
            this.rdBtn4.Size = new System.Drawing.Size(73, 15);
            this.rdBtn4.TabIndex = 15;
            this.rdBtn4.Text = "Crypter_4";
            this.rdBtn4.UseSelectable = true;
            // 
            // cryptageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.rdBtn4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.rdBtn3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rdBtn2);
            this.Controls.Add(this.rdBtn1);
            this.Controls.Add(this.chaineText);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.chaineNoCrypteLabel);
            this.Controls.Add(this.StringCryptedLabel);
            this.Controls.Add(this.CryptedText);
            this.Controls.Add(this.CrypterBtn);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.keyText);
            this.Name = "cryptageForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cryptage";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox keyText;
        private MetroFramework.Controls.MetroLabel KeyLabel;
        private MetroFramework.Controls.MetroButton CrypterBtn;
        private MetroFramework.Controls.MetroTextBox CryptedText;
        private MetroFramework.Controls.MetroLabel StringCryptedLabel;
        private MetroFramework.Controls.MetroLabel chaineNoCrypteLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox chaineText;
        private MetroFramework.Controls.MetroRadioButton rdBtn1;
        private MetroFramework.Controls.MetroRadioButton rdBtn2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton rdBtn3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton rdBtn4;
    }
}

