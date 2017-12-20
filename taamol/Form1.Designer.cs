namespace taamol
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblfamily = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltab1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltab2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltab3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.financials1 = new taamol.financials();
            this.tab11 = new taamol.tab1();
            this.addadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyms_ManagmentDataSet2 = new taamol.Gyms_ManagmentDataSet2();
            this.addadminTableAdapter = new taamol.Gyms_ManagmentDataSet2TableAdapters.addadminTableAdapter();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet2)).BeginInit();
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
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.lblfamily);
            this.header.Controls.Add(this.lblname);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.panel2);
            this.header.Controls.Add(this.flowLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1213, 135);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1146, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(23, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblfamily
            // 
            this.bunifuTransition1.SetDecoration(this.lblfamily, BunifuAnimatorNS.DecorationType.None);
            this.lblfamily.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfamily.Location = new System.Drawing.Point(117, 69);
            this.lblfamily.Name = "lblfamily";
            this.lblfamily.Size = new System.Drawing.Size(184, 22);
            this.lblfamily.TabIndex = 5;
            this.lblfamily.Text = "family";
            // 
            // lblname
            // 
            this.bunifuTransition1.SetDecoration(this.lblname, BunifuAnimatorNS.DecorationType.None);
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(117, 40);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(184, 22);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::taamol.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(29, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(41, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 306);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.bunifuTransition1.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 410);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1119, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbltab1
            // 
            this.lbltab1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab1, BunifuAnimatorNS.DecorationType.None);
            this.lbltab1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbltab1.Location = new System.Drawing.Point(41, 173);
            this.lbltab1.Name = "lbltab1";
            this.lbltab1.Size = new System.Drawing.Size(68, 33);
            this.lbltab1.TabIndex = 0;
            this.lbltab1.Text = "gym";
            this.lbltab1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltab1.Click += new System.EventHandler(this.lbltab1_Click);
            // 
            // lbltab2
            // 
            this.lbltab2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab2, BunifuAnimatorNS.DecorationType.None);
            this.lbltab2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbltab2.Location = new System.Drawing.Point(159, 173);
            this.lbltab2.Name = "lbltab2";
            this.lbltab2.Size = new System.Drawing.Size(61, 33);
            this.lbltab2.TabIndex = 2;
            this.lbltab2.Text = "member";
            this.lbltab2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltab2.Click += new System.EventHandler(this.lbltab2_Click);
            // 
            // lbltab3
            // 
            this.lbltab3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.lbltab3, BunifuAnimatorNS.DecorationType.None);
            this.lbltab3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbltab3.Location = new System.Drawing.Point(266, 173);
            this.lbltab3.Name = "lbltab3";
            this.lbltab3.Size = new System.Drawing.Size(67, 33);
            this.lbltab3.TabIndex = 3;
            this.lbltab3.Text = "financial";
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
            this.line.Location = new System.Drawing.Point(48, 194);
            this.line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(52, 12);
            this.line.TabIndex = 4;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // financials1
            // 
            this.financials1.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuTransition1.SetDecoration(this.financials1, BunifuAnimatorNS.DecorationType.None);
            this.financials1.Location = new System.Drawing.Point(54, 216);
            this.financials1.Name = "financials1";
            this.financials1.Size = new System.Drawing.Size(1114, 483);
            this.financials1.TabIndex = 6;
            this.financials1.Load += new System.EventHandler(this.financials1_Load);
            // 
            // tab11
            // 
            this.tab11.BackColor = System.Drawing.Color.Blue;
            this.bunifuTransition1.SetDecoration(this.tab11, BunifuAnimatorNS.DecorationType.None);
            this.tab11.Location = new System.Drawing.Point(54, 216);
            this.tab11.Name = "tab11";
            this.tab11.Size = new System.Drawing.Size(1114, 483);
            this.tab11.TabIndex = 5;
            this.tab11.Load += new System.EventHandler(this.tab11_Load);
            // 
            // addadminBindingSource
            // 
            this.addadminBindingSource.DataMember = "addadmin";
            this.addadminBindingSource.DataSource = this.gyms_ManagmentDataSet2;
            // 
            // gyms_ManagmentDataSet2
            // 
            this.gyms_ManagmentDataSet2.DataSetName = "Gyms_ManagmentDataSet2";
            this.gyms_ManagmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addadminTableAdapter
            // 
            this.addadminTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 721);
            this.Controls.Add(this.financials1);
            this.Controls.Add(this.tab11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.line);
            this.Controls.Add(this.lbltab3);
            this.Controls.Add(this.lbltab2);
            this.Controls.Add(this.lbltab1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab2;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfamily;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private tab1 tab11;
        private financials financials1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Gyms_ManagmentDataSet2 gyms_ManagmentDataSet2;
        private System.Windows.Forms.BindingSource addadminBindingSource;
        private Gyms_ManagmentDataSet2TableAdapters.addadminTableAdapter addadminTableAdapter;
    }
}

