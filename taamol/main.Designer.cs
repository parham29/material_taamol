namespace taamol
{
    partial class main
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.img_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblfamily = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltab1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltab2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltab3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gyms_tab = new taamol.GymsTab();
            this.members_tab = new taamol.MembersTab();
            this.financials_tab = new taamol.FinancialsTab();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(186)))));
            this.header.Controls.Add(this.img_exit);
            this.header.Controls.Add(this.lblfamily);
            this.header.Controls.Add(this.lblname);
            this.header.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1225, 135);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // img_exit
            // 
            this.img_exit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.img_exit, BunifuAnimatorNS.DecorationType.None);
            this.img_exit.Image = ((System.Drawing.Image)(resources.GetObject("img_exit.Image")));
            this.img_exit.ImageActive = null;
            this.img_exit.Location = new System.Drawing.Point(1186, 6);
            this.img_exit.Name = "img_exit";
            this.img_exit.Size = new System.Drawing.Size(32, 32);
            this.img_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_exit.TabIndex = 6;
            this.img_exit.TabStop = false;
            this.img_exit.Zoom = 10;
            this.img_exit.Click += new System.EventHandler(this.img_exit_Click);
            // 
            // lblfamily
            // 
            this.bunifuTransition1.SetDecoration(this.lblfamily, BunifuAnimatorNS.DecorationType.None);
            this.lblfamily.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamily.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfamily.Location = new System.Drawing.Point(134, 68);
            this.lblfamily.Name = "lblfamily";
            this.lblfamily.Size = new System.Drawing.Size(184, 22);
            this.lblfamily.TabIndex = 5;
            this.lblfamily.Text = "family";
            // 
            // lblname
            // 
            this.bunifuTransition1.SetDecoration(this.lblname, BunifuAnimatorNS.DecorationType.None);
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(133, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(184, 22);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "name";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbltab1
            // 
            this.lbltab1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab1, BunifuAnimatorNS.DecorationType.None);
            this.lbltab1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbltab1.Location = new System.Drawing.Point(56, 164);
            this.lbltab1.Name = "lbltab1";
            this.lbltab1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbltab1.Size = new System.Drawing.Size(108, 33);
            this.lbltab1.TabIndex = 0;
            this.lbltab1.Text = "Gym(s)";
            this.lbltab1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltab1.Click += new System.EventHandler(this.lbltab1_Click);
            // 
            // lbltab2
            // 
            this.lbltab2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab2, BunifuAnimatorNS.DecorationType.None);
            this.lbltab2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbltab2.Location = new System.Drawing.Point(176, 164);
            this.lbltab2.Name = "lbltab2";
            this.lbltab2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbltab2.Size = new System.Drawing.Size(148, 33);
            this.lbltab2.TabIndex = 2;
            this.lbltab2.Text = "Member(s)";
            this.lbltab2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltab2.Click += new System.EventHandler(this.lbltab2_Click);
            // 
            // lbltab3
            // 
            this.lbltab3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab3, BunifuAnimatorNS.DecorationType.None);
            this.lbltab3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbltab3.Location = new System.Drawing.Point(335, 164);
            this.lbltab3.Name = "lbltab3";
            this.lbltab3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbltab3.Size = new System.Drawing.Size(139, 33);
            this.lbltab3.TabIndex = 3;
            this.lbltab3.Text = "Financial(s)";
            this.lbltab3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltab3.Click += new System.EventHandler(this.lbltab3_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line.LineThickness = 3;
            this.line.Location = new System.Drawing.Point(63, 187);
            this.line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(91, 12);
            this.line.TabIndex = 4;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // gyms_tab
            // 
            this.gyms_tab.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.gyms_tab, BunifuAnimatorNS.DecorationType.None);
            this.gyms_tab.Location = new System.Drawing.Point(54, 216);
            this.gyms_tab.Name = "gyms_tab";
            this.gyms_tab.Size = new System.Drawing.Size(1114, 483);
            this.gyms_tab.TabIndex = 5;
            this.gyms_tab.Load += new System.EventHandler(this.gyms_tab_Load);
            // 
            // members_tab
            // 
            this.members_tab.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.members_tab, BunifuAnimatorNS.DecorationType.None);
            this.members_tab.Location = new System.Drawing.Point(54, 216);
            this.members_tab.Name = "members_tab";
            this.members_tab.Size = new System.Drawing.Size(1114, 483);
            this.members_tab.TabIndex = 6;
            this.members_tab.Load += new System.EventHandler(this.members_tab_Load);
            // 
            // financials_tab
            // 
            this.financials_tab.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.financials_tab, BunifuAnimatorNS.DecorationType.None);
            this.financials_tab.Location = new System.Drawing.Point(54, 216);
            this.financials_tab.Name = "financials_tab";
            this.financials_tab.Size = new System.Drawing.Size(1114, 483);
            this.financials_tab.TabIndex = 7;
            this.financials_tab.Load += new System.EventHandler(this.financials_tab_Load);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 721);
            this.Controls.Add(this.line);
            this.Controls.Add(this.lbltab3);
            this.Controls.Add(this.lbltab2);
            this.Controls.Add(this.lbltab1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.gyms_tab);
            this.Controls.Add(this.members_tab);
            this.Controls.Add(this.financials_tab);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab2;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfamily;
        private Bunifu.Framework.UI.BunifuImageButton img_exit;
        private GymsTab gyms_tab;
        private MembersTab members_tab;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private FinancialsTab financials_tab;
    }
}

