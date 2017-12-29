namespace taamol
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_password = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_username = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txt_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Lbl_header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_login
            // 
            this.Btn_login.ActiveBorderThickness = 1;
            this.Btn_login.ActiveCornerRadius = 20;
            this.Btn_login.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.Btn_login.ActiveForecolor = System.Drawing.SystemColors.WindowText;
            this.Btn_login.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_login.BackgroundImage")));
            this.Btn_login.ButtonText = "Login";
            this.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_login.IdleBorderThickness = 1;
            this.Btn_login.IdleCornerRadius = 20;
            this.Btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Btn_login.IdleForecolor = System.Drawing.Color.White;
            this.Btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Btn_login.Location = new System.Drawing.Point(125, 366);
            this.Btn_login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(200, 47);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_password);
            this.panel1.Controls.Add(this.Lbl_username);
            this.panel1.Controls.Add(this.Txt_password);
            this.panel1.Controls.Add(this.Txt_username);
            this.panel1.Location = new System.Drawing.Point(35, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 276);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_password
            // 
            this.Lbl_password.AutoSize = true;
            this.Lbl_password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_password.Location = new System.Drawing.Point(3, 137);
            this.Lbl_password.Name = "Lbl_password";
            this.Lbl_password.Size = new System.Drawing.Size(88, 21);
            this.Lbl_password.TabIndex = 7;
            this.Lbl_password.Text = "Password";
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_username.Location = new System.Drawing.Point(3, 50);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(93, 21);
            this.Lbl_username.TabIndex = 6;
            this.Lbl_username.Text = "Username";
            // 
            // Txt_password
            // 
            this.Txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Txt_password.BorderColorFocused = System.Drawing.Color.OrangeRed;
            this.Txt_password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Txt_password.BorderColorMouseHover = System.Drawing.Color.OrangeRed;
            this.Txt_password.BorderThickness = 1;
            this.Txt_password.CausesValidation = false;
            this.Txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_password.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Txt_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_password.isPassword = true;
            this.Txt_password.Location = new System.Drawing.Point(-2, 166);
            this.Txt_password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(388, 44);
            this.Txt_password.TabIndex = 2;
            this.Txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_username
            // 
            this.Txt_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_username.BorderColorFocused = System.Drawing.Color.OrangeRed;
            this.Txt_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Txt_username.BorderColorMouseHover = System.Drawing.Color.OrangeRed;
            this.Txt_username.BorderThickness = 1;
            this.Txt_username.CausesValidation = false;
            this.Txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_username.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_username.isPassword = false;
            this.Txt_username.Location = new System.Drawing.Point(-2, 81);
            this.Txt_username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(411, 44);
            this.Txt_username.TabIndex = 1;
            this.Txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Lbl_header
            // 
            this.Lbl_header.AutoSize = true;
            this.Lbl_header.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_header.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_header.Location = new System.Drawing.Point(141, 34);
            this.Lbl_header.Name = "Lbl_header";
            this.Lbl_header.Size = new System.Drawing.Size(156, 23);
            this.Lbl_header.TabIndex = 2;
            this.Lbl_header.Text = "Manager Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(445, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_header);
            this.Controls.Add(this.Btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.Shown += new System.EventHandler(this.login_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_login;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_header;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_username;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_password;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_username;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_password;
    }
}