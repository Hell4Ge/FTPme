namespace FTPme
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
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.GB_Mode = new System.Windows.Forms.GroupBox();
            this.CB_Use_Binary = new System.Windows.Forms.CheckBox();
            this.CB_Use_Passive = new System.Windows.Forms.CheckBox();
            this.CB_Keep_Alive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Filebox_padding = new System.Windows.Forms.Label();
            this.TB_Padding = new System.Windows.Forms.TextBox();
            this.tab_content = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.fastDataListView1 = new BrightIdeasSoftware.FastDataListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvHardLinks = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRights = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvOG = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TB_Main = new System.Windows.Forms.TabControl();
            this.tab_settings.SuspendLayout();
            this.GB_Mode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastDataListView1)).BeginInit();
            this.TB_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.groupBox1);
            this.tab_settings.Controls.Add(this.GB_Mode);
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(736, 401);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // GB_Mode
            // 
            this.GB_Mode.Controls.Add(this.CB_Keep_Alive);
            this.GB_Mode.Controls.Add(this.CB_Use_Passive);
            this.GB_Mode.Controls.Add(this.CB_Use_Binary);
            this.GB_Mode.Location = new System.Drawing.Point(6, 6);
            this.GB_Mode.Name = "GB_Mode";
            this.GB_Mode.Size = new System.Drawing.Size(102, 109);
            this.GB_Mode.TabIndex = 1;
            this.GB_Mode.TabStop = false;
            this.GB_Mode.Text = "Mode";
            // 
            // CB_Use_Binary
            // 
            this.CB_Use_Binary.AutoSize = true;
            this.CB_Use_Binary.Location = new System.Drawing.Point(6, 19);
            this.CB_Use_Binary.Name = "CB_Use_Binary";
            this.CB_Use_Binary.Size = new System.Drawing.Size(76, 17);
            this.CB_Use_Binary.TabIndex = 0;
            this.CB_Use_Binary.Text = "Use binary";
            this.CB_Use_Binary.UseVisualStyleBackColor = true;
            // 
            // CB_Use_Passive
            // 
            this.CB_Use_Passive.AutoSize = true;
            this.CB_Use_Passive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CB_Use_Passive.Location = new System.Drawing.Point(7, 43);
            this.CB_Use_Passive.Name = "CB_Use_Passive";
            this.CB_Use_Passive.Size = new System.Drawing.Size(85, 17);
            this.CB_Use_Passive.TabIndex = 1;
            this.CB_Use_Passive.Text = "Use Passive";
            this.CB_Use_Passive.UseVisualStyleBackColor = true;
            // 
            // CB_Keep_Alive
            // 
            this.CB_Keep_Alive.AutoSize = true;
            this.CB_Keep_Alive.Location = new System.Drawing.Point(7, 67);
            this.CB_Keep_Alive.Name = "CB_Keep_Alive";
            this.CB_Keep_Alive.Size = new System.Drawing.Size(76, 17);
            this.CB_Keep_Alive.TabIndex = 2;
            this.CB_Keep_Alive.Text = "Keep alive";
            this.CB_Keep_Alive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Padding);
            this.groupBox1.Controls.Add(this.LB_Filebox_padding);
            this.groupBox1.Location = new System.Drawing.Point(114, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display settings";
            // 
            // LB_Filebox_padding
            // 
            this.LB_Filebox_padding.AutoSize = true;
            this.LB_Filebox_padding.Location = new System.Drawing.Point(7, 20);
            this.LB_Filebox_padding.Name = "LB_Filebox_padding";
            this.LB_Filebox_padding.Size = new System.Drawing.Size(81, 13);
            this.LB_Filebox_padding.TabIndex = 0;
            this.LB_Filebox_padding.Text = "Filebox padding";
            // 
            // TB_Padding
            // 
            this.TB_Padding.Location = new System.Drawing.Point(94, 13);
            this.TB_Padding.Name = "TB_Padding";
            this.TB_Padding.Size = new System.Drawing.Size(38, 20);
            this.TB_Padding.TabIndex = 1;
            // 
            // tab_content
            // 
            this.tab_content.Controls.Add(this.fastDataListView1);
            this.tab_content.Controls.Add(this.button1);
            this.tab_content.Location = new System.Drawing.Point(4, 22);
            this.tab_content.Name = "tab_content";
            this.tab_content.Padding = new System.Windows.Forms.Padding(3);
            this.tab_content.Size = new System.Drawing.Size(736, 401);
            this.tab_content.TabIndex = 0;
            this.tab_content.Text = "Main tab";
            this.tab_content.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fastDataListView1
            // 
            this.fastDataListView1.AllColumns.Add(this.olvName);
            this.fastDataListView1.AllColumns.Add(this.olvSize);
            this.fastDataListView1.AllColumns.Add(this.olvHardLinks);
            this.fastDataListView1.AllColumns.Add(this.olvRights);
            this.fastDataListView1.AllColumns.Add(this.olvOG);
            this.fastDataListView1.CausesValidation = false;
            this.fastDataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvSize,
            this.olvHardLinks,
            this.olvRights,
            this.olvOG});
            this.fastDataListView1.DataSource = null;
            this.fastDataListView1.Location = new System.Drawing.Point(16, 87);
            this.fastDataListView1.Name = "fastDataListView1";
            this.fastDataListView1.ShowGroups = false;
            this.fastDataListView1.Size = new System.Drawing.Size(403, 294);
            this.fastDataListView1.TabIndex = 2;
            this.fastDataListView1.UseCompatibleStateImageBehavior = false;
            this.fastDataListView1.View = System.Windows.Forms.View.Details;
            this.fastDataListView1.VirtualMode = true;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.CellPadding = null;
            this.olvName.Text = "Name";
            // 
            // olvSize
            // 
            this.olvSize.AspectName = "Size";
            this.olvSize.CellPadding = null;
            this.olvSize.Text = "Size";
            // 
            // olvHardLinks
            // 
            this.olvHardLinks.AspectName = "HL";
            this.olvHardLinks.CellPadding = null;
            this.olvHardLinks.Text = "Hard links";
            // 
            // olvRights
            // 
            this.olvRights.AspectName = "Rights";
            this.olvRights.CellPadding = null;
            this.olvRights.Text = "Rights";
            // 
            // olvOG
            // 
            this.olvOG.AspectName = "GID";
            this.olvOG.CellPadding = null;
            this.olvOG.Text = "Owner / group";
            this.olvOG.Width = 88;
            // 
            // TB_Main
            // 
            this.TB_Main.Controls.Add(this.tab_content);
            this.TB_Main.Controls.Add(this.tab_settings);
            this.TB_Main.Location = new System.Drawing.Point(12, 12);
            this.TB_Main.Name = "TB_Main";
            this.TB_Main.SelectedIndex = 0;
            this.TB_Main.Size = new System.Drawing.Size(744, 427);
            this.TB_Main.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.TB_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_settings.ResumeLayout(false);
            this.GB_Mode.ResumeLayout(false);
            this.GB_Mode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastDataListView1)).EndInit();
            this.TB_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Padding;
        private System.Windows.Forms.Label LB_Filebox_padding;
        private System.Windows.Forms.GroupBox GB_Mode;
        private System.Windows.Forms.CheckBox CB_Keep_Alive;
        private System.Windows.Forms.CheckBox CB_Use_Passive;
        private System.Windows.Forms.CheckBox CB_Use_Binary;
        private System.Windows.Forms.TabPage tab_content;
        public BrightIdeasSoftware.FastDataListView fastDataListView1;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvSize;
        private BrightIdeasSoftware.OLVColumn olvHardLinks;
        private BrightIdeasSoftware.OLVColumn olvRights;
        private BrightIdeasSoftware.OLVColumn olvOG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TB_Main;


    }
}

