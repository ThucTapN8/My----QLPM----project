namespace ProjectQLPhongMay
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbLossPW = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtAcc = new DevExpress.XtraEditors.TextEdit();
            this.checkSavePW = new DevExpress.XtraEditors.CheckEdit();
            this.lbNoAcc = new DevExpress.XtraEditors.LabelControl();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.errID = new System.Windows.Forms.ErrorProvider();
            this.errPassWord = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSavePW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbLossPW);
            this.groupControl1.Controls.Add(this.txtPass);
            this.groupControl1.Controls.Add(this.txtAcc);
            this.groupControl1.Controls.Add(this.checkSavePW);
            this.groupControl1.Controls.Add(this.lbNoAcc);
            this.groupControl1.Controls.Add(this.btnDangNhap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(573, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đăng nhập chương trình";
            // 
            // lbLossPW
            // 
            this.lbLossPW.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLossPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLossPW.Location = new System.Drawing.Point(461, 147);
            this.lbLossPW.Name = "lbLossPW";
            this.lbLossPW.Size = new System.Drawing.Size(78, 13);
            this.lbLossPW.TabIndex = 7;
            this.lbLossPW.Text = "Quên tài khoản?";
            this.lbLossPW.Click += new System.EventHandler(this.lbLossPW_Click);
            this.lbLossPW.MouseLeave += new System.EventHandler(this.lbLossPW_MouseLeave);
            this.lbLossPW.MouseHover += new System.EventHandler(this.lbLossPW_MouseHover);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(334, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(205, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.ToolTip = "Nhập mật khẩu";
            this.txtPass.EditValueChanged += new System.EventHandler(this.txtPass_EditValueChanged);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(334, 53);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAcc.Properties.Appearance.Options.UseFont = true;
            this.txtAcc.Size = new System.Drawing.Size(205, 22);
            this.txtAcc.TabIndex = 0;
            this.txtAcc.ToolTip = "Nhập tên tài khoản";
            this.txtAcc.EditValueChanged += new System.EventHandler(this.txtAcc_EditValueChanged);
            this.txtAcc.Leave += new System.EventHandler(this.txtAcc_Leave);
            // 
            // checkSavePW
            // 
            this.checkSavePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSavePW.Location = new System.Drawing.Point(334, 143);
            this.checkSavePW.Name = "checkSavePW";
            this.checkSavePW.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.checkSavePW.Properties.Appearance.Options.UseFont = true;
            this.checkSavePW.Properties.Caption = "Lưu mật khẩu";
            this.checkSavePW.Size = new System.Drawing.Size(120, 21);
            this.checkSavePW.TabIndex = 2;
            // 
            // lbNoAcc
            // 
            this.lbNoAcc.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline);
            this.lbNoAcc.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbNoAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNoAcc.Location = new System.Drawing.Point(211, 199);
            this.lbNoAcc.Name = "lbNoAcc";
            this.lbNoAcc.Size = new System.Drawing.Size(119, 17);
            this.lbNoAcc.TabIndex = 6;
            this.lbNoAcc.Text = "Chưa có tài khoản?";
            this.lbNoAcc.Click += new System.EventHandler(this.lbNoAcc_Click);
            this.lbNoAcc.MouseLeave += new System.EventHandler(this.lbNoAcc_MouseLeave);
            this.lbNoAcc.MouseHover += new System.EventHandler(this.lbNoAcc_MouseHover);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Image = global::ProjectQLPhongMay.Properties.Resources.ic_login__2_1;
            this.btnDangNhap.Location = new System.Drawing.Point(407, 189);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 35);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(211, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên tài khoản";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(211, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mật khẩu";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEdit1.EditValue = global::ProjectQLPhongMay.Properties.Resources.ic_users;
            this.pictureEdit1.Location = new System.Drawing.Point(5, 24);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Size = new System.Drawing.Size(172, 221);
            this.pictureEdit1.TabIndex = 0;
            // 
            // errID
            // 
            this.errID.ContainerControl = this;
            this.errID.Icon = ((System.Drawing.Icon)(resources.GetObject("errID.Icon")));
            // 
            // errPassWord
            // 
            this.errPassWord.ContainerControl = this;
            this.errPassWord.Icon = ((System.Drawing.Icon)(resources.GetObject("errPassWord.Icon")));
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 250);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDangNhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSavePW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkSavePW;
        private DevExpress.XtraEditors.LabelControl lbNoAcc;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtAcc;
        private DevExpress.XtraEditors.LabelControl lbLossPW;
        private System.Windows.Forms.ErrorProvider errID;
        private System.Windows.Forms.ErrorProvider errPassWord;

    }
}