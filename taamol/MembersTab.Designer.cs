namespace taamol
{
    partial class MembersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersTab));
            this.fapzadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyms_ManagmentDataSet = new taamol.Gyms_ManagmentDataSet();
            this.fapz_adminTableAdapter = new taamol.Gyms_ManagmentDataSetTableAdapters.fapz_adminTableAdapter();
            this.gyms_ManagmentDataSet1 = new taamol.Gyms_ManagmentDataSet1();
            this.fapzadminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fapz_adminTableAdapter1 = new taamol.Gyms_ManagmentDataSet1TableAdapters.fapz_adminTableAdapter();
            this.Dgv_allmembers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line_member = new Bunifu.Framework.UI.BunifuSeparator();
            this.Img_editmember = new Bunifu.Framework.UI.BunifuImageButton();
            this.Img_deletemember = new Bunifu.Framework.UI.BunifuImageButton();
            this.Img_addmember = new Bunifu.Framework.UI.BunifuImageButton();
            this.Txt_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.Img_extendmember = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.fapzadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapzadminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_allmembers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_editmember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_deletemember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_addmember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_extendmember)).BeginInit();
            this.SuspendLayout();
            // 
            // fapzadminBindingSource
            // 
            this.fapzadminBindingSource.DataMember = "fapz_admin";
            this.fapzadminBindingSource.DataSource = this.gyms_ManagmentDataSet;
            // 
            // gyms_ManagmentDataSet
            // 
            this.gyms_ManagmentDataSet.DataSetName = "Gyms_ManagmentDataSet";
            this.gyms_ManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fapz_adminTableAdapter
            // 
            this.fapz_adminTableAdapter.ClearBeforeFill = true;
            // 
            // gyms_ManagmentDataSet1
            // 
            this.gyms_ManagmentDataSet1.DataSetName = "Gyms_ManagmentDataSet1";
            this.gyms_ManagmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fapzadminBindingSource1
            // 
            this.fapzadminBindingSource1.DataMember = "fapz_admin";
            this.fapzadminBindingSource1.DataSource = this.gyms_ManagmentDataSet1;
            // 
            // fapz_adminTableAdapter1
            // 
            this.fapz_adminTableAdapter1.ClearBeforeFill = true;
            // 
            // Dgv_allmembers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_allmembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_allmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_allmembers.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_allmembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_allmembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_allmembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_allmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_allmembers.DoubleBuffered = true;
            this.Dgv_allmembers.EnableHeadersVisualStyles = false;
            this.Dgv_allmembers.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_allmembers.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.Dgv_allmembers.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.Dgv_allmembers.Location = new System.Drawing.Point(3, 95);
            this.Dgv_allmembers.MultiSelect = false;
            this.Dgv_allmembers.Name = "Dgv_allmembers";
            this.Dgv_allmembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_allmembers.RowTemplate.Height = 24;
            this.Dgv_allmembers.Size = new System.Drawing.Size(1110, 408);
            this.Dgv_allmembers.TabIndex = 0;
            this.Dgv_allmembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_allmembers_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.line_member);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 30);
            this.panel1.TabIndex = 8;
            // 
            // line_member
            // 
            this.line_member.BackColor = System.Drawing.Color.Transparent;
            this.line_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line_member.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line_member.LineThickness = 3;
            this.line_member.Location = new System.Drawing.Point(357, 20);
            this.line_member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line_member.Name = "line_member";
            this.line_member.Size = new System.Drawing.Size(91, 12);
            this.line_member.TabIndex = 5;
            this.line_member.Transparency = 255;
            this.line_member.Vertical = false;
            // 
            // Img_editmember
            // 
            this.Img_editmember.BackColor = System.Drawing.Color.Transparent;
            this.Img_editmember.Image = ((System.Drawing.Image)(resources.GetObject("Img_editmember.Image")));
            this.Img_editmember.ImageActive = null;
            this.Img_editmember.Location = new System.Drawing.Point(800, 3);
            this.Img_editmember.Name = "Img_editmember";
            this.Img_editmember.Size = new System.Drawing.Size(61, 50);
            this.Img_editmember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_editmember.TabIndex = 12;
            this.Img_editmember.TabStop = false;
            this.Img_editmember.Zoom = 10;
            this.Img_editmember.Click += new System.EventHandler(this.Img_editmember_Click);
            // 
            // Img_deletemember
            // 
            this.Img_deletemember.BackColor = System.Drawing.Color.Transparent;
            this.Img_deletemember.Image = ((System.Drawing.Image)(resources.GetObject("Img_deletemember.Image")));
            this.Img_deletemember.ImageActive = null;
            this.Img_deletemember.Location = new System.Drawing.Point(718, 3);
            this.Img_deletemember.Name = "Img_deletemember";
            this.Img_deletemember.Size = new System.Drawing.Size(61, 50);
            this.Img_deletemember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_deletemember.TabIndex = 11;
            this.Img_deletemember.TabStop = false;
            this.Img_deletemember.Zoom = 10;
            this.Img_deletemember.Click += new System.EventHandler(this.Img_deletemember_Click);
            // 
            // Img_addmember
            // 
            this.Img_addmember.BackColor = System.Drawing.Color.Transparent;
            this.Img_addmember.Image = ((System.Drawing.Image)(resources.GetObject("Img_addmember.Image")));
            this.Img_addmember.ImageActive = null;
            this.Img_addmember.Location = new System.Drawing.Point(637, 3);
            this.Img_addmember.Name = "Img_addmember";
            this.Img_addmember.Size = new System.Drawing.Size(61, 50);
            this.Img_addmember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_addmember.TabIndex = 10;
            this.Img_addmember.TabStop = false;
            this.Img_addmember.Zoom = 10;
            this.Img_addmember.Click += new System.EventHandler(this.Img_addmember_Click);
            // 
            // Txt_search
            // 
            this.Txt_search.BackColor = System.Drawing.Color.White;
            this.Txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_search.BackgroundImage")));
            this.Txt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Txt_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt_search.Icon = ((System.Drawing.Image)(resources.GetObject("Txt_search.Icon")));
            this.Txt_search.Location = new System.Drawing.Point(3, 0);
            this.Txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_search.Name = "Txt_search";
            this.Txt_search.Size = new System.Drawing.Size(617, 52);
            this.Txt_search.TabIndex = 9;
            this.Txt_search.text = "";
            this.Txt_search.OnTextChange += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Img_extendmember
            // 
            this.Img_extendmember.BackColor = System.Drawing.Color.Transparent;
            this.Img_extendmember.Image = ((System.Drawing.Image)(resources.GetObject("Img_extendmember.Image")));
            this.Img_extendmember.ImageActive = null;
            this.Img_extendmember.Location = new System.Drawing.Point(886, 2);
            this.Img_extendmember.Name = "Img_extendmember";
            this.Img_extendmember.Size = new System.Drawing.Size(61, 50);
            this.Img_extendmember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_extendmember.TabIndex = 13;
            this.Img_extendmember.TabStop = false;
            this.Img_extendmember.Zoom = 10;
            this.Img_extendmember.Click += new System.EventHandler(this.Img_extendmember_Click);
            // 
            // MembersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Img_extendmember);
            this.Controls.Add(this.Img_editmember);
            this.Controls.Add(this.Img_deletemember);
            this.Controls.Add(this.Img_addmember);
            this.Controls.Add(this.Txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_allmembers);
            this.Name = "MembersTab";
            this.Size = new System.Drawing.Size(1116, 548);
            this.Load += new System.EventHandler(this.MembersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fapzadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyms_ManagmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapzadminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_allmembers)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_editmember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_deletemember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_addmember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_extendmember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fapzadminBindingSource;
        private Gyms_ManagmentDataSet gyms_ManagmentDataSet;
        private Gyms_ManagmentDataSetTableAdapters.fapz_adminTableAdapter fapz_adminTableAdapter;
        private System.Windows.Forms.BindingSource fapzadminBindingSource1;
        private Gyms_ManagmentDataSet1 gyms_ManagmentDataSet1;
        private Gyms_ManagmentDataSet1TableAdapters.fapz_adminTableAdapter fapz_adminTableAdapter1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_allmembers;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox Txt_search;
        private Bunifu.Framework.UI.BunifuImageButton Img_addmember;
        private Bunifu.Framework.UI.BunifuImageButton Img_deletemember;
        private Bunifu.Framework.UI.BunifuImageButton Img_editmember;
        private Bunifu.Framework.UI.BunifuImageButton Img_extendmember;
        private Bunifu.Framework.UI.BunifuSeparator line_member;
    }
}
