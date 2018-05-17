namespace ProjectQLPhongMay
{
    partial class frm_Chitiethoadonbosung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chitiethoadonbosung));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_quaylai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_themchitiethd = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groc_cthdbs = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ckb_no = new System.Windows.Forms.CheckBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.lb_mahoadon = new System.Windows.Forms.Label();
            this.lb_tentb = new System.Windows.Forms.Label();
            this.lb_sohieutb = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.txt_sohieutb = new System.Windows.Forms.TextBox();
            this.txt_tentb = new System.Windows.Forms.TextBox();
            this.lb_ghinhan = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_ram = new System.Windows.Forms.TextBox();
            this.txt_motatb = new System.Windows.Forms.TextBox();
            this.lb_ram = new System.Windows.Forms.Label();
            this.lb_motatb = new System.Windows.Forms.Label();
            this.txt_diacung = new System.Windows.Forms.TextBox();
            this.txt_vixuly = new System.Windows.Forms.TextBox();
            this.txt_manhinh = new System.Windows.Forms.TextBox();
            this.lb_diacung = new System.Windows.Forms.Label();
            this.lb_vixuly = new System.Windows.Forms.Label();
            this.lb_manhinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groc_cthdbs)).BeginInit();
            this.groc_cthdbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.btn_quaylai,
            this.btn_themchitiethd});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_quaylai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_themchitiethd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Caption = "Quay lại";
            this.btn_quaylai.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Glyph")));
            this.btn_quaylai.Id = 0;
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_quaylai_ItemClick);
            // 
            // btn_themchitiethd
            // 
            this.btn_themchitiethd.Caption = "Thêm chi tiết hóa đơn";
            this.btn_themchitiethd.Glyph = global::ProjectQLPhongMay.Properties.Resources.File_Add;
            this.btn_themchitiethd.Id = 1;
            this.btn_themchitiethd.Name = "btn_themchitiethd";
            this.btn_themchitiethd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_themchitiethd_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(571, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 293);
            this.barDockControlBottom.Size = new System.Drawing.Size(571, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 246);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(571, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 246);
            // 
            // groc_cthdbs
            // 
            this.groc_cthdbs.AutoSize = true;
            this.groc_cthdbs.Controls.Add(this.groupControl2);
            this.groc_cthdbs.Controls.Add(this.groupControl1);
            this.groc_cthdbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groc_cthdbs.Location = new System.Drawing.Point(0, 47);
            this.groc_cthdbs.Name = "groc_cthdbs";
            this.groc_cthdbs.Size = new System.Drawing.Size(571, 246);
            this.groc_cthdbs.TabIndex = 5;
            this.groc_cthdbs.Text = "Chi tiết hóa đơn bổ sung ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ckb_no);
            this.groupControl2.Controls.Add(this.txt_dongia);
            this.groupControl2.Controls.Add(this.lb_mahoadon);
            this.groupControl2.Controls.Add(this.lb_tentb);
            this.groupControl2.Controls.Add(this.lb_sohieutb);
            this.groupControl2.Controls.Add(this.lb_dongia);
            this.groupControl2.Controls.Add(this.txt_mahd);
            this.groupControl2.Controls.Add(this.txt_sohieutb);
            this.groupControl2.Controls.Add(this.txt_tentb);
            this.groupControl2.Controls.Add(this.lb_ghinhan);
            this.groupControl2.Location = new System.Drawing.Point(5, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(264, 213);
            this.groupControl2.TabIndex = 5;
            // 
            // ckb_no
            // 
            this.ckb_no.AutoSize = true;
            this.ckb_no.Location = new System.Drawing.Point(84, 157);
            this.ckb_no.Name = "ckb_no";
            this.ckb_no.Size = new System.Drawing.Size(89, 17);
            this.ckb_no.TabIndex = 3;
            this.ckb_no.Text = "Chưa chuyển";
            this.ckb_no.UseVisualStyleBackColor = true;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(84, 130);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(175, 20);
            this.txt_dongia.TabIndex = 2;
            // 
            // lb_mahoadon
            // 
            this.lb_mahoadon.AutoSize = true;
            this.lb_mahoadon.Location = new System.Drawing.Point(5, 37);
            this.lb_mahoadon.Name = "lb_mahoadon";
            this.lb_mahoadon.Size = new System.Drawing.Size(65, 13);
            this.lb_mahoadon.TabIndex = 6;
            this.lb_mahoadon.Text = "Mã hóa đơn";
            // 
            // lb_tentb
            // 
            this.lb_tentb.AutoSize = true;
            this.lb_tentb.Location = new System.Drawing.Point(5, 104);
            this.lb_tentb.Name = "lb_tentb";
            this.lb_tentb.Size = new System.Drawing.Size(60, 13);
            this.lb_tentb.TabIndex = 2;
            this.lb_tentb.Text = "Tên thiết bị";
            // 
            // lb_sohieutb
            // 
            this.lb_sohieutb.AutoSize = true;
            this.lb_sohieutb.Location = new System.Drawing.Point(5, 71);
            this.lb_sohieutb.Name = "lb_sohieutb";
            this.lb_sohieutb.Size = new System.Drawing.Size(77, 13);
            this.lb_sohieutb.TabIndex = 0;
            this.lb_sohieutb.Text = "Số hiệu thiết bị";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Location = new System.Drawing.Point(5, 133);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(44, 13);
            this.lb_dongia.TabIndex = 2;
            this.lb_dongia.Text = "Đơn giá";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Enabled = false;
            this.txt_mahd.Location = new System.Drawing.Point(84, 34);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(175, 20);
            this.txt_mahd.TabIndex = 1;
            // 
            // txt_sohieutb
            // 
            this.txt_sohieutb.Location = new System.Drawing.Point(84, 67);
            this.txt_sohieutb.Name = "txt_sohieutb";
            this.txt_sohieutb.Size = new System.Drawing.Size(175, 20);
            this.txt_sohieutb.TabIndex = 0;
            // 
            // txt_tentb
            // 
            this.txt_tentb.Location = new System.Drawing.Point(84, 101);
            this.txt_tentb.Name = "txt_tentb";
            this.txt_tentb.Size = new System.Drawing.Size(175, 20);
            this.txt_tentb.TabIndex = 1;
            // 
            // lb_ghinhan
            // 
            this.lb_ghinhan.AutoSize = true;
            this.lb_ghinhan.Location = new System.Drawing.Point(5, 157);
            this.lb_ghinhan.Name = "lb_ghinhan";
            this.lb_ghinhan.Size = new System.Drawing.Size(50, 13);
            this.lb_ghinhan.TabIndex = 2;
            this.lb_ghinhan.Text = "Ghi nhận";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_ram);
            this.groupControl1.Controls.Add(this.txt_motatb);
            this.groupControl1.Controls.Add(this.lb_ram);
            this.groupControl1.Controls.Add(this.lb_motatb);
            this.groupControl1.Controls.Add(this.txt_diacung);
            this.groupControl1.Controls.Add(this.txt_vixuly);
            this.groupControl1.Controls.Add(this.txt_manhinh);
            this.groupControl1.Controls.Add(this.lb_diacung);
            this.groupControl1.Controls.Add(this.lb_vixuly);
            this.groupControl1.Controls.Add(this.lb_manhinh);
            this.groupControl1.Location = new System.Drawing.Point(275, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(287, 213);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chi tiết cấu hình thiết bị";
            // 
            // txt_ram
            // 
            this.txt_ram.Location = new System.Drawing.Point(8, 84);
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.Size = new System.Drawing.Size(125, 20);
            this.txt_ram.TabIndex = 6;
            // 
            // txt_motatb
            // 
            this.txt_motatb.Location = new System.Drawing.Point(8, 133);
            this.txt_motatb.Multiline = true;
            this.txt_motatb.Name = "txt_motatb";
            this.txt_motatb.Size = new System.Drawing.Size(274, 75);
            this.txt_motatb.TabIndex = 8;
            // 
            // lb_ram
            // 
            this.lb_ram.AutoSize = true;
            this.lb_ram.Location = new System.Drawing.Point(5, 68);
            this.lb_ram.Name = "lb_ram";
            this.lb_ram.Size = new System.Drawing.Size(29, 13);
            this.lb_ram.TabIndex = 4;
            this.lb_ram.Text = "Ram";
            // 
            // lb_motatb
            // 
            this.lb_motatb.AutoSize = true;
            this.lb_motatb.Location = new System.Drawing.Point(5, 117);
            this.lb_motatb.Name = "lb_motatb";
            this.lb_motatb.Size = new System.Drawing.Size(95, 13);
            this.lb_motatb.TabIndex = 4;
            this.lb_motatb.Text = "Mô tả thiết bị khác";
            // 
            // txt_diacung
            // 
            this.txt_diacung.Location = new System.Drawing.Point(144, 41);
            this.txt_diacung.Name = "txt_diacung";
            this.txt_diacung.Size = new System.Drawing.Size(138, 20);
            this.txt_diacung.TabIndex = 5;
            // 
            // txt_vixuly
            // 
            this.txt_vixuly.Location = new System.Drawing.Point(5, 41);
            this.txt_vixuly.Name = "txt_vixuly";
            this.txt_vixuly.Size = new System.Drawing.Size(125, 20);
            this.txt_vixuly.TabIndex = 4;
            // 
            // txt_manhinh
            // 
            this.txt_manhinh.Location = new System.Drawing.Point(144, 84);
            this.txt_manhinh.Name = "txt_manhinh";
            this.txt_manhinh.Size = new System.Drawing.Size(138, 20);
            this.txt_manhinh.TabIndex = 7;
            // 
            // lb_diacung
            // 
            this.lb_diacung.AutoSize = true;
            this.lb_diacung.Location = new System.Drawing.Point(141, 25);
            this.lb_diacung.Name = "lb_diacung";
            this.lb_diacung.Size = new System.Drawing.Size(53, 13);
            this.lb_diacung.TabIndex = 2;
            this.lb_diacung.Text = "Đĩa cứng";
            // 
            // lb_vixuly
            // 
            this.lb_vixuly.AutoSize = true;
            this.lb_vixuly.Location = new System.Drawing.Point(5, 25);
            this.lb_vixuly.Name = "lb_vixuly";
            this.lb_vixuly.Size = new System.Drawing.Size(40, 13);
            this.lb_vixuly.TabIndex = 2;
            this.lb_vixuly.Text = "Vi xử lý";
            // 
            // lb_manhinh
            // 
            this.lb_manhinh.AutoSize = true;
            this.lb_manhinh.Location = new System.Drawing.Point(141, 68);
            this.lb_manhinh.Name = "lb_manhinh";
            this.lb_manhinh.Size = new System.Drawing.Size(51, 13);
            this.lb_manhinh.TabIndex = 2;
            this.lb_manhinh.Text = "Màn hình";
            // 
            // frm_Chitiethoadonbosung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 293);
            this.Controls.Add(this.groc_cthdbs);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Chitiethoadonbosung";
            this.Text = "frm_Chitiethoadonbosung";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groc_cthdbs)).EndInit();
            this.groc_cthdbs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_quaylai;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groc_cthdbs;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label lb_mahoadon;
        private System.Windows.Forms.Label lb_tentb;
        private System.Windows.Forms.Label lb_sohieutb;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.TextBox txt_sohieutb;
        private System.Windows.Forms.TextBox txt_tentb;
        private System.Windows.Forms.Label lb_ghinhan;
        private System.Windows.Forms.CheckBox ckb_no;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_ram;
        private System.Windows.Forms.TextBox txt_motatb;
        private System.Windows.Forms.Label lb_ram;
        private System.Windows.Forms.Label lb_motatb;
        private System.Windows.Forms.TextBox txt_diacung;
        private System.Windows.Forms.TextBox txt_vixuly;
        private System.Windows.Forms.TextBox txt_manhinh;
        private System.Windows.Forms.Label lb_diacung;
        private System.Windows.Forms.Label lb_vixuly;
        private System.Windows.Forms.Label lb_manhinh;
        private DevExpress.XtraBars.BarButtonItem btn_themchitiethd;
        public System.Windows.Forms.TextBox txt_mahd;
    }
}