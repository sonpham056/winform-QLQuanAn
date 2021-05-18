
namespace QuanLyQuanAn.GUI
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBànHômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXemBan = new System.Windows.Forms.Button();
            this.btnXemMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.frmMainBackGround;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemMenuToolStripMenuItem,
            this.xemBànToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1261, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemMenuToolStripMenuItem
            // 
            this.xemMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.xemMenuToolStripMenuItem.Image = global::QuanLyQuanAn.Properties.Resources.pen;
            this.xemMenuToolStripMenuItem.Name = "xemMenuToolStripMenuItem";
            this.xemMenuToolStripMenuItem.Size = new System.Drawing.Size(150, 36);
            this.xemMenuToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(248, 36);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(248, 36);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // xemBànToolStripMenuItem
            // 
            this.xemBànToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemBànHômNayToolStripMenuItem,
            this.xemMenuToolStripMenuItem1});
            this.xemBànToolStripMenuItem.Image = global::QuanLyQuanAn.Properties.Resources.glass;
            this.xemBànToolStripMenuItem.Name = "xemBànToolStripMenuItem";
            this.xemBànToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.xemBànToolStripMenuItem.Text = "Xem";
            // 
            // xemBànHômNayToolStripMenuItem
            // 
            this.xemBànHômNayToolStripMenuItem.Name = "xemBànHômNayToolStripMenuItem";
            this.xemBànHômNayToolStripMenuItem.Size = new System.Drawing.Size(300, 36);
            this.xemBànHômNayToolStripMenuItem.Text = "Xem bàn hôm nay";
            this.xemBànHômNayToolStripMenuItem.Click += new System.EventHandler(this.btnXemBan_Click);
            // 
            // xemMenuToolStripMenuItem1
            // 
            this.xemMenuToolStripMenuItem1.Name = "xemMenuToolStripMenuItem1";
            this.xemMenuToolStripMenuItem1.Size = new System.Drawing.Size(300, 36);
            this.xemMenuToolStripMenuItem1.Text = "Xem menu";
            this.xemMenuToolStripMenuItem1.Click += new System.EventHandler(this.btnXemMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTime,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTime
            // 
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(276, 20);
            this.toolStripStatusLabel3.Text = "Hotline: 0931919064 / Zalo: 0704544881";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.frmMainBackGround;
            this.flowLayoutPanel1.Controls.Add(this.btnXemBan);
            this.flowLayoutPanel1.Controls.Add(this.btnXemMenu);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 655);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnXemBan
            // 
            this.btnXemBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemBan.BackgroundImage")));
            this.btnXemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBan.ForeColor = System.Drawing.Color.Red;
            this.btnXemBan.Location = new System.Drawing.Point(3, 2);
            this.btnXemBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemBan.Name = "btnXemBan";
            this.btnXemBan.Size = new System.Drawing.Size(208, 128);
            this.btnXemBan.TabIndex = 0;
            this.btnXemBan.Text = "Xem Bàn hôm nay";
            this.btnXemBan.UseVisualStyleBackColor = true;
            this.btnXemBan.Click += new System.EventHandler(this.btnXemBan_Click);
            // 
            // btnXemMenu
            // 
            this.btnXemMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemMenu.BackgroundImage")));
            this.btnXemMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemMenu.ForeColor = System.Drawing.Color.Red;
            this.btnXemMenu.Location = new System.Drawing.Point(3, 134);
            this.btnXemMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemMenu.Name = "btnXemMenu";
            this.btnXemMenu.Size = new System.Drawing.Size(208, 128);
            this.btnXemMenu.TabIndex = 0;
            this.btnXemMenu.Text = "Xem Menu";
            this.btnXemMenu.UseVisualStyleBackColor = true;
            this.btnXemMenu.Click += new System.EventHandler(this.btnXemMenu_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.khachhang;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 721);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBànToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnXemBan;
        private System.Windows.Forms.Button btnXemMenu;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBànHômNayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemMenuToolStripMenuItem1;
    }
}