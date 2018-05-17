namespace ProjectQLPhongMay
{
    partial class FrmHoaDonSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonSC));
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNguoicap = new DevExpress.XtraEditors.TextEdit();
            this.txt_dvsc = new DevExpress.XtraEditors.TextEdit();
            this.dtp_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.rTxt_mota = new System.Windows.Forms.RichTextBox();
            this.btn_btn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoicap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dvsc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(99, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(200, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã hóa đơn       :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Người cấp          :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ngày cấp           :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Đơn vị sửa chữa:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Mô tả                 :";
            // 
            // txtNguoicap
            // 
            this.txtNguoicap.Location = new System.Drawing.Point(99, 48);
            this.txtNguoicap.Name = "txtNguoicap";
            this.txtNguoicap.Size = new System.Drawing.Size(200, 20);
            this.txtNguoicap.TabIndex = 0;
            // 
            // txt_dvsc
            // 
            this.txt_dvsc.Location = new System.Drawing.Point(99, 120);
            this.txt_dvsc.Name = "txt_dvsc";
            this.txt_dvsc.Size = new System.Drawing.Size(200, 20);
            this.txt_dvsc.TabIndex = 0;
            // 
            // dtp_ngaycap
            // 
            this.dtp_ngaycap.Location = new System.Drawing.Point(99, 83);
            this.dtp_ngaycap.Name = "dtp_ngaycap";
            this.dtp_ngaycap.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaycap.TabIndex = 2;
            // 
            // rTxt_mota
            // 
            this.rTxt_mota.Location = new System.Drawing.Point(99, 158);
            this.rTxt_mota.Name = "rTxt_mota";
            this.rTxt_mota.Size = new System.Drawing.Size(200, 108);
            this.rTxt_mota.TabIndex = 4;
            this.rTxt_mota.Text = "";
            // 
            // btn_btn
            // 
            this.btn_btn.Image = ((System.Drawing.Image)(resources.GetObject("btn_btn.Image")));
            this.btn_btn.Location = new System.Drawing.Point(12, 272);
            this.btn_btn.Name = "btn_btn";
            this.btn_btn.Size = new System.Drawing.Size(138, 32);
            this.btn_btn.TabIndex = 5;
            this.btn_btn.Click += new System.EventHandler(this.btn_btn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(161, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmHoaDonSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 309);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_btn);
            this.Controls.Add(this.rTxt_mota);
            this.Controls.Add(this.dtp_ngaycap);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_dvsc);
            this.Controls.Add(this.txtNguoicap);
            this.Controls.Add(this.txtMaHD);
            this.Name = "FrmHoaDonSC";
            this.Text = "FrmHoaDonSC";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoicap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dvsc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtNguoicap;
        public DevExpress.XtraEditors.TextEdit txt_dvsc;
        public System.Windows.Forms.DateTimePicker dtp_ngaycap;
        public System.Windows.Forms.RichTextBox rTxt_mota;
        public DevExpress.XtraEditors.SimpleButton btn_btn;
        public DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}