namespace Complexite
{
    partial class decryptageForm
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
            this.crSLbl = new MetroFramework.Controls.MetroLabel();
            this.crsText = new MetroFramework.Controls.MetroTextBox();
            this.keylbl = new MetroFramework.Controls.MetroLabel();
            this.keyText = new MetroFramework.Controls.MetroTextBox();
            this.decBtn = new MetroFramework.Controls.MetroButton();
            this.decSlbl = new MetroFramework.Controls.MetroLabel();
            this.decStext = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.openFileBtn = new MetroFramework.Controls.MetroButton();
            this.OpenFileBtn1 = new MetroFramework.Controls.MetroButton();
            this.rdBtn1 = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtn2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rdBtn3 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // crSLbl
            // 
            this.crSLbl.AutoSize = true;
            this.crSLbl.Location = new System.Drawing.Point(137, 60);
            this.crSLbl.Name = "crSLbl";
            this.crSLbl.Size = new System.Drawing.Size(121, 19);
            this.crSLbl.TabIndex = 0;
            this.crSLbl.Text = "Chiane a decrypter";
            // 
            // crsText
            // 
            // 
            // 
            // 
            this.crsText.CustomButton.Image = null;
            this.crsText.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.crsText.CustomButton.Name = "";
            this.crsText.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.crsText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.crsText.CustomButton.TabIndex = 1;
            this.crsText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.crsText.CustomButton.UseSelectable = true;
            this.crsText.CustomButton.Visible = false;
            this.crsText.Lines = new string[0];
            this.crsText.Location = new System.Drawing.Point(134, 89);
            this.crsText.MaxLength = 32767;
            this.crsText.Name = "crsText";
            this.crsText.PasswordChar = '\0';
            this.crsText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.crsText.SelectedText = "";
            this.crsText.SelectionLength = 0;
            this.crsText.SelectionStart = 0;
            this.crsText.ShortcutsEnabled = true;
            this.crsText.Size = new System.Drawing.Size(544, 29);
            this.crsText.TabIndex = 1;
            this.crsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.crsText.UseSelectable = true;
            this.crsText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.crsText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keylbl
            // 
            this.keylbl.AutoSize = true;
            this.keylbl.Location = new System.Drawing.Point(137, 156);
            this.keylbl.Name = "keylbl";
            this.keylbl.Size = new System.Drawing.Size(28, 19);
            this.keylbl.TabIndex = 2;
            this.keylbl.Text = "Clé";
            // 
            // keyText
            // 
            // 
            // 
            // 
            this.keyText.CustomButton.Image = null;
            this.keyText.CustomButton.Location = new System.Drawing.Point(515, 2);
            this.keyText.CustomButton.Name = "";
            this.keyText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.keyText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyText.CustomButton.TabIndex = 1;
            this.keyText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyText.CustomButton.UseSelectable = true;
            this.keyText.CustomButton.Visible = false;
            this.keyText.Lines = new string[0];
            this.keyText.Location = new System.Drawing.Point(137, 187);
            this.keyText.MaxLength = 32767;
            this.keyText.Name = "keyText";
            this.keyText.PasswordChar = '*';
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyText.SelectedText = "";
            this.keyText.SelectionLength = 0;
            this.keyText.SelectionStart = 0;
            this.keyText.ShortcutsEnabled = true;
            this.keyText.Size = new System.Drawing.Size(541, 28);
            this.keyText.TabIndex = 3;
            this.keyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyText.UseSelectable = true;
            this.keyText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(336, 255);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(152, 48);
            this.decBtn.TabIndex = 4;
            this.decBtn.Text = "Décrypter";
            this.decBtn.UseSelectable = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // decSlbl
            // 
            this.decSlbl.AutoSize = true;
            this.decSlbl.Location = new System.Drawing.Point(137, 284);
            this.decSlbl.Name = "decSlbl";
            this.decSlbl.Size = new System.Drawing.Size(112, 19);
            this.decSlbl.TabIndex = 5;
            this.decSlbl.Text = "Chaine decryptée";
            // 
            // decStext
            // 
            // 
            // 
            // 
            this.decStext.CustomButton.Image = null;
            this.decStext.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.decStext.CustomButton.Name = "";
            this.decStext.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.decStext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.decStext.CustomButton.TabIndex = 1;
            this.decStext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.decStext.CustomButton.UseSelectable = true;
            this.decStext.CustomButton.Visible = false;
            this.decStext.Lines = new string[0];
            this.decStext.Location = new System.Drawing.Point(134, 316);
            this.decStext.MaxLength = 32767;
            this.decStext.Name = "decStext";
            this.decStext.PasswordChar = '\0';
            this.decStext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.decStext.SelectedText = "";
            this.decStext.SelectionLength = 0;
            this.decStext.SelectionStart = 0;
            this.decStext.ShortcutsEnabled = true;
            this.decStext.Size = new System.Drawing.Size(544, 109);
            this.decStext.TabIndex = 6;
            this.decStext.UseSelectable = true;
            this.decStext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.decStext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(13, 69);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(101, 80);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Cryptage";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(12, 172);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(102, 82);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Décryptage";
            this.metroTile2.UseSelectable = true;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(560, 133);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(94, 23);
            this.openFileBtn.TabIndex = 9;
            this.openFileBtn.Text = "Ouvrir fichier...";
            this.openFileBtn.UseSelectable = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // OpenFileBtn1
            // 
            this.OpenFileBtn1.Location = new System.Drawing.Point(560, 224);
            this.OpenFileBtn1.Name = "OpenFileBtn1";
            this.OpenFileBtn1.Size = new System.Drawing.Size(94, 30);
            this.OpenFileBtn1.TabIndex = 10;
            this.OpenFileBtn1.Text = "Ouvrir fichier...";
            this.OpenFileBtn1.UseSelectable = true;
            this.OpenFileBtn1.Click += new System.EventHandler(this.OpenFileBtn1_Click);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Checked = true;
            this.rdBtn1.Location = new System.Drawing.Point(13, 316);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(85, 15);
            this.rdBtn1.TabIndex = 11;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "Decrypter_1";
            this.rdBtn1.UseSelectable = true;
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(12, 363);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(85, 15);
            this.rdBtn2.TabIndex = 12;
            this.rdBtn2.Text = "Decrypter_2";
            this.rdBtn2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 294);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Selon Gril A";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 341);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Selon Gril B";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 393);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Another idea";
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Location = new System.Drawing.Point(12, 415);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(85, 15);
            this.rdBtn3.TabIndex = 16;
            this.rdBtn3.Text = "Decrypter_3";
            this.rdBtn3.UseSelectable = true;
            // 
            // decryptageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.rdBtn3);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rdBtn2);
            this.Controls.Add(this.rdBtn1);
            this.Controls.Add(this.OpenFileBtn1);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.decStext);
            this.Controls.Add(this.decSlbl);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.keylbl);
            this.Controls.Add(this.crsText);
            this.Controls.Add(this.crSLbl);
            this.Name = "decryptageForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Décryptage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel crSLbl;
        private MetroFramework.Controls.MetroTextBox crsText;
        private MetroFramework.Controls.MetroLabel keylbl;
        private MetroFramework.Controls.MetroTextBox keyText;
        private MetroFramework.Controls.MetroButton decBtn;
        private MetroFramework.Controls.MetroLabel decSlbl;
        private MetroFramework.Controls.MetroTextBox decStext;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton openFileBtn;
        private MetroFramework.Controls.MetroButton OpenFileBtn1;
        private MetroFramework.Controls.MetroRadioButton rdBtn1;
        private MetroFramework.Controls.MetroRadioButton rdBtn2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton rdBtn3;
    }
}