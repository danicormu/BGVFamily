namespace BSFamilyProject.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PositionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.UsernameTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.CloseBtn);
            this.HeaderPanel.Controls.Add(this.PositionLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(843, 44);
            this.HeaderPanel.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(801, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PositionLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(14, 10);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(64, 24);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.PasswordTxt);
            this.panel1.Controls.Add(this.UsernameTxt);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(192, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 245);
            this.panel1.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PasswordTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTxt.BackgroundImage")));
            this.PasswordTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.White;
            this.PasswordTxt.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordTxt.Icon")));
            this.PasswordTxt.Location = new System.Drawing.Point(77, 86);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(318, 59);
            this.PasswordTxt.TabIndex = 3;
            this.PasswordTxt.text = "Contraseña";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.UsernameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsernameTxt.BackgroundImage")));
            this.UsernameTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsernameTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.Color.White;
            this.UsernameTxt.Icon = ((System.Drawing.Image)(resources.GetObject("UsernameTxt.Icon")));
            this.UsernameTxt.Location = new System.Drawing.Point(77, 19);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(318, 59);
            this.UsernameTxt.TabIndex = 2;
            this.UsernameTxt.text = "Nombre de usuario";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.BorderRadius = 0;
            this.LoginBtn.ButtonText = "Ingresar";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Iconimage")));
            this.LoginBtn.Iconimage_right = null;
            this.LoginBtn.Iconimage_right_Selected = null;
            this.LoginBtn.Iconimage_Selected = null;
            this.LoginBtn.IconMarginLeft = 0;
            this.LoginBtn.IconMarginRight = 0;
            this.LoginBtn.IconRightVisible = true;
            this.LoginBtn.IconRightZoom = 0D;
            this.LoginBtn.IconVisible = true;
            this.LoginBtn.IconZoom = 90D;
            this.LoginBtn.IsTab = false;
            this.LoginBtn.Location = new System.Drawing.Point(143, 166);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LoginBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.LoginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginBtn.selected = false;
            this.LoginBtn.Size = new System.Drawing.Size(178, 53);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Ingresar";
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBtn.Textcolor = System.Drawing.Color.White;
            this.LoginBtn.TextFont = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(843, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel PositionLabel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox UsernameTxt;
        private Bunifu.Framework.UI.BunifuTextbox PasswordTxt;
        private Bunifu.Framework.UI.BunifuFlatButton LoginBtn;
    }
}