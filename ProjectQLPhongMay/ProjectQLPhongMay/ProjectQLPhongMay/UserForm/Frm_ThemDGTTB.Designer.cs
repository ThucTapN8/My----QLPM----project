namespace ProjectQLPhongMay
{
    partial class Frm_ThemDGTTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThemDGTTB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btiThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btiHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblNguoiDanhGia = new System.Windows.Forms.Label();
            this.lblNgayDanhGia = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtNguoiDanhGia = new System.Windows.Forms.TextBox();
            this.datNgayDanhGia = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMaHienThi = new System.Windows.Forms.Label();
            this.txtMaHienThi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btiThemMoi,
            this.btiHuy});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiThemMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btiThemMoi
            // 
            this.btiThemMoi.Caption = "Thêm Mới";
            this.btiThemMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btiThemMoi.Glyph")));
            this.btiThemMoi.Id = 0;
            this.btiThemMoi.Name = "btiThemMoi";
            this.btiThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiThemMoi_ItemClick);
            // 
            // btiHuy
            // 
            this.btiHuy.Caption = "Hủy";
            this.btiHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btiHuy.Glyph")));
            this.btiHuy.Id = 1;
            this.btiHuy.Name = "btiHuy";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(380, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 384);
            this.barDockControlBottom.Size = new System.Drawing.Size(380, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(380, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // lblNguoiDanhGia
            // 
            this.lblNguoiDanhGia.AutoSize = true;
            this.lblNguoiDanhGia.Location = new System.Drawing.Point(34, 126);
            this.lblNguoiDanhGia.Name = "lblNguoiDanhGia";
            this.lblNguoiDanhGia.Size = new System.Drawing.Size(86, 13);
            this.lblNguoiDanhGia.TabIndex = 4;
            this.lblNguoiDanhGia.Text = "Người Đánh Giá:";
            // 
            // lblNgayDanhGia
            // 
            this.lblNgayDanhGia.AutoSize = true;
            this.lblNgayDanhGia.Location = new System.Drawing.Point(37, 174);
            this.lblNgayDanhGia.Name = "lblNgayDanhGia";
            this.lblNgayDanhGia.Size = new System.Drawing.Size(83, 13);
            this.lblNgayDanhGia.TabIndex = 4;
            this.lblNgayDanhGia.Text = "Ngày Đánh Giá:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(34, 229);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(41, 13);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // txtNguoiDanhGia
            // 
            this.txtNguoiDanhGia.Location = new System.Drawing.Point(132, 123);
            this.txtNguoiDanhGia.Name = "txtNguoiDanhGia";
            this.txtNguoiDanhGia.Size = new System.Drawing.Size(200, 20);
            this.txtNguoiDanhGia.TabIndex = 5;
            // 
            // datNgayDanhGia
            // 
            this.datNgayDanhGia.Location = new System.Drawing.Point(132, 168);
            this.datNgayDanhGia.Name = "datNgayDanhGia";
            this.datNgayDanhGia.Size = new System.Drawing.Size(200, 20);
            this.datNgayDanhGia.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(132, 226);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(200, 117);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblMaHienThi
            // 
            this.lblMaHienThi.AutoSize = true;
            this.lblMaHienThi.Location = new System.Drawing.Point(34, 83);
            this.lblMaHienThi.Name = "lblMaHienThi";
            this.lblMaHienThi.Size = new System.Drawing.Size(68, 13);
            this.lblMaHienThi.TabIndex = 12;
            this.lblMaHienThi.Text = "Mã Hiển Thị:";
            // 
            // txtMaHienThi
            // 
            this.txtMaHienThi.Location = new System.Drawing.Point(132, 80);
            this.txtMaHienThi.Name = "txtMaHienThi";
            this.txtMaHienThi.Size = new System.Drawing.Size(200, 20);
            this.txtMaHienThi.TabIndex = 13;
            // 
            // Frm_ThemDGTTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 384);
            this.Controls.Add(this.txtMaHienThi);
            this.Controls.Add(this.lblMaHienThi);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.datNgayDanhGia);
            this.Controls.Add(this.txtNguoiDanhGia);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblNgayDanhGia);
            this.Controls.Add(this.lblNguoiDanhGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_ThemDGTTB";
            this.Text = "Frm_ThemDGTTB";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btiThemMoi;
        private DevExpress.XtraBars.BarButtonItem btiHuy;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DateTimePicker datNgayDanhGia;
        private System.Windows.Forms.TextBox txtNguoiDanhGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblNgayDanhGia;
        private System.Windows.Forms.Label lblNguoiDanhGia;
        private System.Windows.Forms.Label lblMaHienThi;
        public System.Windows.Forms.TextBox txtMaHienThi;

    }
}