namespace TsUtil {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() { 
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.poweredByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qOSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hongzhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbt4516tsUtilgitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.White;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Margin = new System.Windows.Forms.Padding(0);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(120, 21);
            this.tb.TabIndex = 0;
            this.tb.Text = "Welcome";
            this.tb.Click += new System.EventHandler(this.tb_Click);
            this.tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.tb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.enterForm);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "tsUTIL";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickTray);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poweredByToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 48);
            // 
            // poweredByToolStripMenuItem
            // 
            this.poweredByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qOSSToolStripMenuItem,
            this.hongzhanToolStripMenuItem,
            this.toolStripMenuItem2,
            this.githubToolStripMenuItem});
            this.poweredByToolStripMenuItem.Name = "poweredByToolStripMenuItem";
            this.poweredByToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.poweredByToolStripMenuItem.Text = "Powered by";
            // 
            // qOSSToolStripMenuItem
            // 
            this.qOSSToolStripMenuItem.Name = "qOSSToolStripMenuItem";
            this.qOSSToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.qOSSToolStripMenuItem.Text = "QOSS";
            // 
            // hongzhanToolStripMenuItem
            // 
            this.hongzhanToolStripMenuItem.Name = "hongzhanToolStripMenuItem";
            this.hongzhanToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.hongzhanToolStripMenuItem.Text = "zyl whz";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "2016-08-21";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbt4516tsUtilgitToolStripMenuItem});
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.githubToolStripMenuItem.Text = "github";
            // 
            // dbt4516tsUtilgitToolStripMenuItem
            // 
            this.dbt4516tsUtilgitToolStripMenuItem.Name = "dbt4516tsUtilgitToolStripMenuItem";
            this.dbt4516tsUtilgitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dbt4516tsUtilgitToolStripMenuItem.Text = "~/dbt4516/tsUtil.git";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(120, 83);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Deactivate += new System.EventHandler(this.lostFocus);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poweredByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qOSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hongzhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbt4516tsUtilgitToolStripMenuItem;
    }
}

