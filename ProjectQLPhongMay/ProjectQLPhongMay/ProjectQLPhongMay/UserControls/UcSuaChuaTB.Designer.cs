namespace ProjectQLPhongMay
{
    partial class UcSuaChuaTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSuaChuaTB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_themmoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_capnhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapnhatdl = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btn_TTB = new DevExpress.XtraBars.BarButtonItem();
            this.btnHD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnUpTTB = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpHD = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_menu2 = new System.Windows.Forms.ComboBox();
            this.cmb_menu1 = new System.Windows.Forms.ComboBox();
            this.grC_sctb = new DevExpress.XtraGrid.GridControl();
            this.grv_sctb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Xem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grC_sctb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_sctb)).BeginInit();
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
            this.btnThem,
            this.btnSua,
            this.btnCapnhatdl,
            this.btnThoat,
            this.barSubItem1,
            this.barButtonItem1,
            this.barSubItem2,
            this.btn_TTB,
            this.btnHD,
            this.barButtonItem2,
            this.barSubItem3,
            this.btnUpTTB,
            this.btnUpHD,
            this.btnLammoi,
            this.btn_dong,
            this.btn_themmoi,
            this.btn_capnhat});
            this.barManager1.MaxItemId = 18;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatSize = new System.Drawing.Size(50, 50);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_themmoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_capnhat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_dong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Caption = "Thêm mới trang thiết bị sửa chữa";
            this.btn_themmoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_themmoi.Glyph")));
            this.btn_themmoi.Id = 16;
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_themmoi_ItemClick);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Caption = "Cập nhật dữ liệu trang thiết bị sửa chữa";
            this.btn_capnhat.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_capnhat.Glyph")));
            this.btn_capnhat.Id = 17;
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_capnhat_ItemClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Caption = "Làm mới";
            this.btnLammoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Glyph")));
            this.btnLammoi.Id = 14;
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoi_ItemClick);
            // 
            // btn_dong
            // 
            this.btn_dong.Caption = "Đóng";
            this.btn_dong.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_dong.Glyph")));
            this.btn_dong.Id = 15;
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(927, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
            this.barDockControlBottom.Size = new System.Drawing.Size(927, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 409);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(927, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 409);
            // 
            // btnThem
            // 
            this.btnThem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            // 
            // btnCapnhatdl
            // 
            this.btnCapnhatdl.Caption = "Cập nhật dữ liệu";
            this.btnCapnhatdl.Id = 2;
            this.btnCapnhatdl.Name = "btnCapnhatdl";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.Name = "btnThoat";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Thêm mới";
            this.barSubItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem2.Glyph")));
            this.barSubItem2.Id = 7;
            this.barSubItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubItem2.LargeGlyph")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_TTB),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHD)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btn_TTB
            // 
            this.btn_TTB.Caption = "Trang thiết bị sửa chữa";
            this.btn_TTB.Id = 8;
            this.btn_TTB.Name = "btn_TTB";
            // 
            // btnHD
            // 
            this.btnHD.Caption = "Hóa đơn sửa chữa";
            this.btnHD.Id = 9;
            this.btnHD.Name = "btnHD";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Chỉnh sửa dữ liệu";
            this.barSubItem3.Id = 11;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpTTB),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpHD)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnUpTTB
            // 
            this.btnUpTTB.Caption = "Trang thiết bị sửa chữa";
            this.btnUpTTB.Id = 12;
            this.btnUpTTB.Name = "btnUpTTB";
            // 
            // btnUpHD
            // 
            this.btnUpHD.Caption = "Hóa đơn sửa chữa";
            this.btnUpHD.Id = 13;
            this.btnUpHD.Name = "btnUpHD";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_menu2);
            this.groupControl1.Controls.Add(this.cmb_menu1);
            this.groupControl1.Controls.Add(this.grC_sctb);
            this.groupControl1.Controls.Add(this.btn_Xem);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(927, 409);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh sách chi tiết thông tin các trang thiết bị được sửa chữa:";
            // 
            // cmb_menu2
            // 
            this.cmb_menu2.FormattingEnabled = true;
            this.cmb_menu2.Location = new System.Drawing.Point(307, 28);
            this.cmb_menu2.Name = "cmb_menu2";
            this.cmb_menu2.Size = new System.Drawing.Size(134, 21);
            this.cmb_menu2.TabIndex = 6;
            // 
            // cmb_menu1
            // 
            this.cmb_menu1.FormattingEnabled = true;
            this.cmb_menu1.Items.AddRange(new object[] {
            "Hóa đơn",
            "Năm"});
            this.cmb_menu1.Location = new System.Drawing.Point(121, 28);
            this.cmb_menu1.Name = "cmb_menu1";
            this.cmb_menu1.Size = new System.Drawing.Size(180, 21);
            this.cmb_menu1.TabIndex = 5;
            this.cmb_menu1.SelectedIndexChanged += new System.EventHandler(this.cmb_menu1_SelectedIndexChanged);
            // 
            // grC_sctb
            // 
            this.grC_sctb.Cursor = System.Windows.Forms.Cursors.Default;
            this.grC_sctb.Location = new System.Drawing.Point(2, 74);
            this.grC_sctb.MainView = this.grv_sctb;
            this.grC_sctb.MenuManager = this.barManager1;
            this.grC_sctb.Name = "grC_sctb";
            this.grC_sctb.Size = new System.Drawing.Size(923, 333);
            this.grC_sctb.TabIndex = 4;
            this.grC_sctb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_sctb});
            // 
            // grv_sctb
            // 
            this.grv_sctb.GridControl = this.grC_sctb;
            this.grv_sctb.Name = "grv_sctb";
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(447, 26);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(75, 23);
            this.btn_Xem.TabIndex = 3;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Xem danh sách theo:";
            // 
            // UcSuaChuaTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UcSuaChuaTB";
            this.Size = new System.Drawing.Size(927, 456);
            this.Load += new System.EventHandler(this.UcSuaChuaTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grC_sctb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_sctb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnCapnhatdl;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem btn_themmoi;
        private DevExpress.XtraBars.BarButtonItem btn_capnhat;
        private DevExpress.XtraBars.BarButtonItem btnLammoi;
        private DevExpress.XtraBars.BarButtonItem btn_dong;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btn_TTB;
        private DevExpress.XtraBars.BarButtonItem btnHD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnUpTTB;
        private DevExpress.XtraBars.BarButtonItem btnUpHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Xem;
        private DevExpress.XtraGrid.GridControl grC_sctb;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_sctb;
        private System.Windows.Forms.ComboBox cmb_menu2;
        private System.Windows.Forms.ComboBox cmb_menu1;
    }
}
