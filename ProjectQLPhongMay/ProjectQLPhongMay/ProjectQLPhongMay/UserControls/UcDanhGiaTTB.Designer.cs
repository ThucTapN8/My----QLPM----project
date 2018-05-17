namespace ProjectQLPhongMay
{
    partial class UcDanhGiaTTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDanhGiaTTB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btiThem = new DevExpress.XtraBars.BarButtonItem();
            this.btiThemChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.btiSua1 = new DevExpress.XtraBars.BarButtonItem();
            this.btiLamTuoi1 = new DevExpress.XtraBars.BarButtonItem();
            this.btiTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btiSua = new DevExpress.XtraBars.BarButtonItem();
            this.btiDOng = new DevExpress.XtraBars.BarButtonItem();
            this.gric_danhgiattb = new DevExpress.XtraGrid.GridControl();
            this.dgv_danhgiattb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgv_chitietdanhgiattb = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gric_danhgiattb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhgiattb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdanhgiattb)).BeginInit();
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
            this.btiThem,
            this.btiSua,
            this.btiThemChiTiet,
            this.btiDOng,
            this.btiSua1,
            this.btiLamTuoi1,
            this.btiTimKiem,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiThemChiTiet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiSua1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiLamTuoi1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btiTimKiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btiThem
            // 
            this.btiThem.Caption = "Thêm Đánh Giá";
            this.btiThem.Glyph = global::ProjectQLPhongMay.Properties.Resources.Add;
            this.btiThem.Id = 0;
            this.btiThem.Name = "btiThem";
            this.btiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiThem_ItemClick);
            // 
            // btiThemChiTiet
            // 
            this.btiThemChiTiet.Caption = "Thêm Chi Tiết Đánh Giá";
            this.btiThemChiTiet.Glyph = ((System.Drawing.Image)(resources.GetObject("btiThemChiTiet.Glyph")));
            this.btiThemChiTiet.Id = 2;
            this.btiThemChiTiet.Name = "btiThemChiTiet";
            this.btiThemChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiThemChiTiet_ItemClick);
            // 
            // btiSua1
            // 
            this.btiSua1.Caption = "Sửa";
            this.btiSua1.Glyph = global::ProjectQLPhongMay.Properties.Resources.File_List;
            this.btiSua1.Id = 4;
            this.btiSua1.Name = "btiSua1";
            this.btiSua1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiHienCHiTiet_ItemClick);
            // 
            // btiLamTuoi1
            // 
            this.btiLamTuoi1.Caption = "Làm Tươi";
            this.btiLamTuoi1.Glyph = global::ProjectQLPhongMay.Properties.Resources.refresh;
            this.btiLamTuoi1.Id = 5;
            this.btiLamTuoi1.Name = "btiLamTuoi1";
            this.btiLamTuoi1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiLamTuoi1_ItemClick);
            // 
            // btiTimKiem
            // 
            this.btiTimKiem.Caption = "Tìm Kiếm";
            this.btiTimKiem.Glyph = ((System.Drawing.Image)(resources.GetObject("btiTimKiem.Glyph")));
            this.btiTimKiem.Id = 6;
            this.btiTimKiem.Name = "btiTimKiem";
            this.btiTimKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiTimKiem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đóng";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 423);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 376);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 376);
            // 
            // btiSua
            // 
            this.btiSua.Caption = "Sửa";
            this.btiSua.Glyph = global::ProjectQLPhongMay.Properties.Resources.File_List;
            this.btiSua.Id = 1;
            this.btiSua.Name = "btiSua";
            // 
            // btiDOng
            // 
            this.btiDOng.Caption = "Đóng";
            this.btiDOng.Id = 3;
            this.btiDOng.Name = "btiDOng";
            // 
            // gric_danhgiattb
            // 
            this.gric_danhgiattb.Cursor = System.Windows.Forms.Cursors.Default;
            this.gric_danhgiattb.Dock = System.Windows.Forms.DockStyle.Left;
            this.gric_danhgiattb.Location = new System.Drawing.Point(0, 47);
            this.gric_danhgiattb.MainView = this.dgv_danhgiattb;
            this.gric_danhgiattb.MenuManager = this.barManager1;
            this.gric_danhgiattb.Name = "gric_danhgiattb";
            this.gric_danhgiattb.Size = new System.Drawing.Size(377, 376);
            this.gric_danhgiattb.TabIndex = 4;
            this.gric_danhgiattb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_danhgiattb});
            this.gric_danhgiattb.Click += new System.EventHandler(this.gric_danhgiattb_Click);
            // 
            // dgv_danhgiattb
            // 
            this.dgv_danhgiattb.GridControl = this.gric_danhgiattb;
            this.dgv_danhgiattb.Name = "dgv_danhgiattb";
            this.dgv_danhgiattb.Click += new System.EventHandler(this.dgv_danhgiattb_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(377, 47);
            this.gridControl1.MainView = this.dgv_chitietdanhgiattb;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(423, 376);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_chitietdanhgiattb});
            // 
            // dgv_chitietdanhgiattb
            // 
            this.dgv_chitietdanhgiattb.GridControl = this.gridControl1;
            this.dgv_chitietdanhgiattb.Name = "dgv_chitietdanhgiattb";
            // 
            // UcDanhGiaTTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gric_danhgiattb);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UcDanhGiaTTB";
            this.Size = new System.Drawing.Size(800, 423);
            this.Load += new System.EventHandler(this.UcDanhGiaTTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gric_danhgiattb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhgiattb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdanhgiattb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btiThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btiSua;
        private DevExpress.XtraBars.BarButtonItem btiThemChiTiet;
        private DevExpress.XtraBars.BarButtonItem btiDOng;
        private DevExpress.XtraBars.BarButtonItem btiSua1;
        private DevExpress.XtraBars.BarButtonItem btiLamTuoi1;
        private DevExpress.XtraGrid.GridControl gric_danhgiattb;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_danhgiattb;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_chitietdanhgiattb;
        private DevExpress.XtraBars.BarButtonItem btiTimKiem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
