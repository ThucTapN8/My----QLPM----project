namespace ProjectQLPhongMay
{
    partial class frmDieuchuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgTH = new System.Windows.Forms.TextBox();
            this.cbnPmden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbnPMDi = new System.Windows.Forms.ComboBox();
            this.dtpNgayDC = new System.Windows.Forms.DateTimePicker();
            this.txtMaHT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hiển thị";
            // 
            // txtNgTH
            // 
            this.txtNgTH.Location = new System.Drawing.Point(131, 51);
            this.txtNgTH.Name = "txtNgTH";
            this.txtNgTH.Size = new System.Drawing.Size(158, 20);
            this.txtNgTH.TabIndex = 1;
            // 
            // cbnPmden
            // 
            this.cbnPmden.FormattingEnabled = true;
            this.cbnPmden.Location = new System.Drawing.Point(131, 130);
            this.cbnPmden.Name = "cbnPmden";
            this.cbnPmden.Size = new System.Drawing.Size(158, 21);
            this.cbnPmden.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người điều chuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày điều chuyển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phòng máy đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng máy đi";
            // 
            // cbnPMDi
            // 
            this.cbnPMDi.FormattingEnabled = true;
            this.cbnPMDi.Location = new System.Drawing.Point(131, 174);
            this.cbnPMDi.Name = "cbnPMDi";
            this.cbnPMDi.Size = new System.Drawing.Size(158, 21);
            this.cbnPMDi.TabIndex = 2;
            // 
            // dtpNgayDC
            // 
            this.dtpNgayDC.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDC.Location = new System.Drawing.Point(131, 88);
            this.dtpNgayDC.Name = "dtpNgayDC";
            this.dtpNgayDC.Size = new System.Drawing.Size(158, 20);
            this.dtpNgayDC.TabIndex = 3;
            // 
            // txtMaHT
            // 
            this.txtMaHT.Location = new System.Drawing.Point(131, 15);
            this.txtMaHT.Name = "txtMaHT";
            this.txtMaHT.Size = new System.Drawing.Size(158, 20);
            this.txtMaHT.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDieuchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNgayDC);
            this.Controls.Add(this.cbnPMDi);
            this.Controls.Add(this.cbnPmden);
            this.Controls.Add(this.txtMaHT);
            this.Controls.Add(this.txtNgTH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDieuchuyen";
            this.Text = "frmDieuchuyen";
            this.Load += new System.EventHandler(this.frmDieuchuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNgTH;
        public System.Windows.Forms.ComboBox cbnPmden;
        public System.Windows.Forms.ComboBox cbnPMDi;
        public System.Windows.Forms.DateTimePicker dtpNgayDC;
        public System.Windows.Forms.TextBox txtMaHT;
    }
}