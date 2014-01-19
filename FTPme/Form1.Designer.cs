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
            this.TB_Main = new System.Windows.Forms.TabControl();
            this.tab_content = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Padding = new System.Windows.Forms.TextBox();
            this.LB_Filebox_padding = new System.Windows.Forms.Label();
            this.GB_Mode = new System.Windows.Forms.GroupBox();
            this.CB_Keep_Alive = new System.Windows.Forms.CheckBox();
            this.CB_Use_Passive = new System.Windows.Forms.CheckBox();
            this.CB_Use_Binary = new System.Windows.Forms.CheckBox();
            this.TB_Main.SuspendLayout();
            this.tab_content.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GB_Mode.SuspendLayout();
            this.SuspendLayout();
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
            // tab_content
            // 
            this.tab_content.Controls.Add(this.treeView1);
            this.tab_content.Location = new System.Drawing.Point(4, 22);
            this.tab_content.Name = "tab_content";
            this.tab_content.Padding = new System.Windows.Forms.Padding(3);
            this.tab_content.Size = new System.Drawing.Size(736, 401);
            this.tab_content.TabIndex = 0;
            this.tab_content.Text = "Main tab";
            this.tab_content.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 26);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(297, 331);
            this.treeView1.TabIndex = 0;
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
            // TB_Padding
            // 
            this.TB_Padding.Location = new System.Drawing.Point(94, 13);
            this.TB_Padding.Name = "TB_Padding";
            this.TB_Padding.Size = new System.Drawing.Size(38, 20);
            this.TB_Padding.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.TB_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TB_Main.ResumeLayout(false);
            this.tab_content.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_Mode.ResumeLayout(false);
            this.GB_Mode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TB_Main;
        private System.Windows.Forms.TabPage tab_content;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.CheckBox CB_Use_Binary;
        private System.Windows.Forms.GroupBox GB_Mode;
        private System.Windows.Forms.CheckBox CB_Use_Passive;
        private System.Windows.Forms.CheckBox CB_Keep_Alive;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Padding;
        private System.Windows.Forms.Label LB_Filebox_padding;
    }
}

