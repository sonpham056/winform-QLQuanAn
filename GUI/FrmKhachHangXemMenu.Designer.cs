
namespace QuanLyQuanAn.GUI
{
    partial class FrmKhachHangXemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHangXemMenu));
            this.flpMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.tvMonAn = new System.Windows.Forms.TreeView();
            this.btnBtn = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMonAn
            // 
            this.flpMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMonAn.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.khachhang;
            this.flpMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpMonAn.Location = new System.Drawing.Point(0, 0);
            this.flpMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpMonAn.Name = "flpMonAn";
            this.flpMonAn.Size = new System.Drawing.Size(1212, 566);
            this.flpMonAn.TabIndex = 0;
            // 
            // tvMonAn
            // 
            this.tvMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMonAn.Location = new System.Drawing.Point(0, 0);
            this.tvMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvMonAn.Name = "tvMonAn";
            this.tvMonAn.Size = new System.Drawing.Size(1212, 566);
            this.tvMonAn.TabIndex = 1;
            // 
            // btnBtn
            // 
            this.btnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBtn.Location = new System.Drawing.Point(0, 572);
            this.btnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBtn.Name = "btnBtn";
            this.btnBtn.Size = new System.Drawing.Size(173, 114);
            this.btnBtn.TabIndex = 2;
            this.btnBtn.Text = "Xem theo nút";
            this.btnBtn.UseVisualStyleBackColor = false;
            this.btnBtn.Click += new System.EventHandler(this.btnBtn_Click);
            // 
            // btnTV
            // 
            this.btnTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTV.Location = new System.Drawing.Point(179, 572);
            this.btnTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(208, 114);
            this.btnTV.TabIndex = 2;
            this.btnTV.Text = "Xem theo Tree view";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // FrmKhachHangXemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 698);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.btnBtn);
            this.Controls.Add(this.tvMonAn);
            this.Controls.Add(this.flpMonAn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKhachHangXemMenu";
            this.Text = "Xem menu";
            this.Load += new System.EventHandler(this.FrmKhachHangXemMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMonAn;
        private System.Windows.Forms.TreeView tvMonAn;
        private System.Windows.Forms.Button btnBtn;
        private System.Windows.Forms.Button btnTV;
    }
}