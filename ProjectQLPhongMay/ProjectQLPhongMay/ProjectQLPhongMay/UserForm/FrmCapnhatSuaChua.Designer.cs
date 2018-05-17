namespace ProjectQLPhongMay
{
    partial class FrmSuaChua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaChua));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_ngaysc = new System.Windows.Forms.DateTimePicker();
            this.txt_cthh = new DevExpress.XtraEditors.TextEdit();
            this.txt_nguoisc = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rBtn_dsc = new System.Windows.Forms.RadioButton();
            this.rBtn_dsdn = new System.Windows.Forms.RadioButton();
            this.btn_btn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtHoadon = new DevExpress.XtraEditors.TextEdit();
            this.txtTB = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cthh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nguoisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hóa đơn              :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thiết bị                :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày sửa chữa   :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chi tiết hỏng hóc:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Người sửa chữa  :";
            // 
            // dtp_ngaysc
            // 
            this.dtp_ngaysc.Location = new System.Drawing.Point(115, 87);
            this.dtp_ngaysc.Name = "dtp_ngaysc";
            this.dtp_ngaysc.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysc.TabIndex = 2;
            // 
            // txt_cthh
            // 
            this.txt_cthh.Location = new System.Drawing.Point(116, 121);
            this.txt_cthh.Name = "txt_cthh";
            this.txt_cthh.Size = new System.Drawing.Size(200, 20);
            this.txt_cthh.TabIndex = 3;
            // 
            // txt_nguoisc
            // 
            this.txt_nguoisc.Location = new System.Drawing.Point(114, 158);
            this.txt_nguoisc.Name = "txt_nguoisc";
            this.txt_nguoisc.Size = new System.Drawing.Size(200, 20);
            this.txt_nguoisc.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rBtn_dsc);
            this.groupControl1.Controls.Add(this.rBtn_dsdn);
            this.groupControl1.Location = new System.Drawing.Point(22, 196);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 67);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Ghi nhận";
            // 
            // rBtn_dsc
            // 
            this.rBtn_dsc.AutoSize = true;
            this.rBtn_dsc.Location = new System.Drawing.Point(149, 24);
            this.rBtn_dsc.Name = "rBtn_dsc";
            this.rBtn_dsc.Size = new System.Drawing.Size(98, 17);
            this.rBtn_dsc.TabIndex = 0;
            this.rBtn_dsc.TabStop = true;
            this.rBtn_dsc.Text = "Đang sửa chữa";
            this.rBtn_dsc.UseVisualStyleBackColor = true;
            // 
            // rBtn_dsdn
            // 
            this.rBtn_dsdn.AutoSize = true;
            this.rBtn_dsdn.Location = new System.Drawing.Point(13, 24);
            this.rBtn_dsdn.Name = "rBtn_dsdn";
            this.rBtn_dsdn.Size = new System.Drawing.Size(103, 17);
            this.rBtn_dsdn.TabIndex = 0;
            this.rBtn_dsdn.TabStop = true;
            this.rBtn_dsdn.Text = "Đã sửa-Đã nhận";
            this.rBtn_dsdn.UseVisualStyleBackColor = true;
            // 
            // btn_btn
            // 
            this.btn_btn.Image = ((System.Drawing.Image)(resources.GetObject("btn_btn.Image")));
            this.btn_btn.Location = new System.Drawing.Point(22, 269);
            this.btn_btn.Name = "btn_btn";
            this.btn_btn.Size = new System.Drawing.Size(141, 33);
            this.btn_btn.TabIndex = 5;
            this.btn_btn.Text = "CẬP NHẬT";
            this.btn_btn.Click += new System.EventHandler(this.btn_btn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(174, 269);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(141, 33);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txtHoadon
            // 
            this.txtHoadon.Enabled = false;
            this.txtHoadon.Location = new System.Drawing.Point(116, 9);
            this.txtHoadon.Name = "txtHoadon";
            this.txtHoadon.Size = new System.Drawing.Size(199, 20);
            this.txtHoadon.TabIndex = 6;
            // 
            // txtTB
            // 
            this.txtTB.Enabled = false;
            this.txtTB.Location = new System.Drawing.Point(114, 48);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(199, 20);
            this.txtTB.TabIndex = 6;
            // 
            // FrmSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 314);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtHoadon);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_btn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txt_nguoisc);
            this.Controls.Add(this.txt_cthh);
            this.Controls.Add(this.dtp_ngaysc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSuaChua";
            this.Text = "FrmSuaChua";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cthh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nguoisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public System.Windows.Forms.DateTimePicker dtp_ngaysc;
        public DevExpress.XtraEditors.TextEdit txt_cthh;
        public DevExpress.XtraEditors.TextEdit txt_nguoisc;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.RadioButton rBtn_dsc;
        public System.Windows.Forms.RadioButton rBtn_dsdn;
        public DevExpress.XtraEditors.SimpleButton btn_btn;
        public DevExpress.XtraEditors.SimpleButton btn_thoat;
        public DevExpress.XtraEditors.TextEdit txtHoadon;
        public DevExpress.XtraEditors.TextEdit txtTB;
    }
}