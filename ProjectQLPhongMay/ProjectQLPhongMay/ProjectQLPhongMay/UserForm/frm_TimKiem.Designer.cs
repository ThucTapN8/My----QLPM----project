namespace ProjectQLPhongMay
{
    partial class frm_TimKiem
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grid_KetQua = new DevExpress.XtraGrid.GridControl();
            this.dgv_TimKiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblChon = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.cboChon = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboNhap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(812, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 330);
            this.barDockControlBottom.Size = new System.Drawing.Size(812, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 330);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(812, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 330);
            // 
            // grid_KetQua
            // 
            this.grid_KetQua.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_KetQua.Location = new System.Drawing.Point(12, 97);
            this.grid_KetQua.MainView = this.dgv_TimKiem;
            this.grid_KetQua.MenuManager = this.barManager1;
            this.grid_KetQua.Name = "grid_KetQua";
            this.grid_KetQua.Size = new System.Drawing.Size(772, 221);
            this.grid_KetQua.TabIndex = 4;
            this.grid_KetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_TimKiem});
            // 
            // dgv_TimKiem
            // 
            this.dgv_TimKiem.GridControl = this.grid_KetQua;
            this.dgv_TimKiem.Name = "dgv_TimKiem";
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(9, 26);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(81, 13);
            this.lblChon.TabIndex = 5;
            this.lblChon.Text = "Tìm Kiếm Theo:";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(257, 26);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(94, 13);
            this.lblNhap.TabIndex = 5;
            this.lblNhap.Text = "Nhập Từ Cần Tìm:";
            // 
            // cboChon
            // 
            this.cboChon.FormattingEnabled = true;
            this.cboChon.Items.AddRange(new object[] {
            "Mã thiết bị",
            "Tên thiết bị",
            "Màn hình",
            "RAM",
            "Vi xử lý",
            "Đĩa cứng"});
            this.cboChon.Location = new System.Drawing.Point(97, 26);
            this.cboChon.Name = "cboChon";
            this.cboChon.Size = new System.Drawing.Size(134, 21);
            this.cboChon.TabIndex = 6;
            this.cboChon.SelectedIndexChanged += new System.EventHandler(this.cboChon_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(563, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 23);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboNhap
            // 
            this.cboNhap.FormattingEnabled = true;
            this.cboNhap.Location = new System.Drawing.Point(367, 23);
            this.cboNhap.Name = "cboNhap";
            this.cboNhap.Size = new System.Drawing.Size(173, 21);
            this.cboNhap.TabIndex = 13;
            // 
            // frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 330);
            this.Controls.Add(this.cboNhap);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboChon);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.grid_KetQua);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_TimKiem";
            this.Text = "frm_TimKiem";
            this.Load += new System.EventHandler(this.frm_TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grid_KetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboChon;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.ComboBox cboNhap;

    }
}