namespace ProjectQLPhongMay
{
    partial class frm_ThemChiTietDGTTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemChiTietDGTTB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btiCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblMaDanhGia = new System.Windows.Forms.Label();
            this.lblCapChatLuong = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.cboCapChatLuong = new System.Windows.Forms.ComboBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.datThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txtMaDanhGia = new System.Windows.Forms.TextBox();
            this.cboMaThietBi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.barButtonItem1,
            this.btiCapNhat,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiCapNhat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btiCapNhat
            // 
            this.btiCapNhat.Caption = "Cập Nhật";
            this.btiCapNhat.Glyph = global::ProjectQLPhongMay.Properties.Resources.File_List;
            this.btiCapNhat.Id = 1;
            this.btiCapNhat.Name = "btiCapNhat";
            this.btiCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiCapNhat_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đóng";
            this.barButtonItem2.Glyph = global::ProjectQLPhongMay.Properties.Resources.close_delete_2;
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(643, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 304);
            this.barDockControlBottom.Size = new System.Drawing.Size(643, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 257);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(643, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 257);
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(29, 86);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(64, 13);
            this.lblMaThietBi.TabIndex = 4;
            this.lblMaThietBi.Text = "Mã Thiết Bị:";
            // 
            // lblMaDanhGia
            // 
            this.lblMaDanhGia.AutoSize = true;
            this.lblMaDanhGia.Location = new System.Drawing.Point(29, 159);
            this.lblMaDanhGia.Name = "lblMaDanhGia";
            this.lblMaDanhGia.Size = new System.Drawing.Size(68, 13);
            this.lblMaDanhGia.TabIndex = 4;
            this.lblMaDanhGia.Text = "Mã Hiển Thị:";
            // 
            // lblCapChatLuong
            // 
            this.lblCapChatLuong.AutoSize = true;
            this.lblCapChatLuong.Location = new System.Drawing.Point(314, 81);
            this.lblCapChatLuong.Name = "lblCapChatLuong";
            this.lblCapChatLuong.Size = new System.Drawing.Size(87, 13);
            this.lblCapChatLuong.TabIndex = 4;
            this.lblCapChatLuong.Text = "Cấp Chất Lượng:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(314, 155);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(49, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết Quả:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(331, 238);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(56, 13);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "Thời Gian:";
            // 
            // cboCapChatLuong
            // 
            this.cboCapChatLuong.FormattingEnabled = true;
            this.cboCapChatLuong.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.cboCapChatLuong.Location = new System.Drawing.Point(420, 78);
            this.cboCapChatLuong.Name = "cboCapChatLuong";
            this.cboCapChatLuong.Size = new System.Drawing.Size(137, 21);
            this.cboCapChatLuong.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(420, 152);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(200, 20);
            this.txtKetQua.TabIndex = 6;
            // 
            // datThoiGian
            // 
            this.datThoiGian.Location = new System.Drawing.Point(420, 231);
            this.datThoiGian.Name = "datThoiGian";
            this.datThoiGian.Size = new System.Drawing.Size(200, 20);
            this.datThoiGian.TabIndex = 7;
            // 
            // txtMaDanhGia
            // 
            this.txtMaDanhGia.Location = new System.Drawing.Point(112, 155);
            this.txtMaDanhGia.Name = "txtMaDanhGia";
            this.txtMaDanhGia.ReadOnly = true;
            this.txtMaDanhGia.Size = new System.Drawing.Size(170, 20);
            this.txtMaDanhGia.TabIndex = 8;
            // 
            // cboMaThietBi
            // 
            this.cboMaThietBi.FormattingEnabled = true;
            this.cboMaThietBi.Location = new System.Drawing.Point(112, 78);
            this.cboMaThietBi.Name = "cboMaThietBi";
            this.cboMaThietBi.Size = new System.Drawing.Size(170, 21);
            this.cboMaThietBi.TabIndex = 13;
            this.cboMaThietBi.SelectedIndexChanged += new System.EventHandler(this.cboMaThietBi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Đánh Giá:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_ThemChiTietDGTTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 304);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaThietBi);
            this.Controls.Add(this.txtMaDanhGia);
            this.Controls.Add(this.datThoiGian);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.cboCapChatLuong);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblMaDanhGia);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblCapChatLuong);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_ThemChiTietDGTTB";
            this.Text = "frm_ThemChiTietDGTTB";
            this.Load += new System.EventHandler(this.frm_ThemChiTietDGTTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btiCapNhat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblMaDanhGia;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblCapChatLuong;
        private System.Windows.Forms.Label lblMaThietBi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        public System.Windows.Forms.TextBox txtMaDanhGia;
        public System.Windows.Forms.DateTimePicker datThoiGian;
        public System.Windows.Forms.TextBox txtKetQua;
        public System.Windows.Forms.ComboBox cboCapChatLuong;
        public System.Windows.Forms.ComboBox cboMaThietBi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}