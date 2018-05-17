using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace ProjectQLPhongMay
{
    public partial class FrmThemMoiSCTB : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection strConnect;
        public FrmThemMoiSCTB(SqlConnection con)
        {
            strConnect = con;
            InitializeComponent();
        }


        private void FrmThemMoiSCTB_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_HIENTHI_PHONGMAY", strConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtPhongMay = new DataTable();
            sqlAdapter.Fill(dtPhongMay);
            cmb_pm.DataSource = dtPhongMay;
            cmb_pm.DisplayMember = "tenphongmay";
            cmb_pm.ValueMember = "maphongmay";

            SqlDataAdapter da = new SqlDataAdapter("select * from hoadonsuachua", strConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_hd.DataSource = dt;
            cmb_hd.DisplayMember = "hienthima";
            cmb_hd.ValueMember = "ma";
        }

        private void cmb_pm_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_HienThiTrangThietBiPhongMay", strConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maPM", SqlDbType.VarChar, 20);
            sqlCommand.Parameters["@maPM"].Value = cmb_pm.SelectedValue.ToString();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtThietBi = new DataTable();
            sqlAdapter.Fill(dtThietBi);
            grC_TTB.DataSource = dtThietBi;
            grV_TTB.Columns["matrangtb"].Caption = "Mã thiết bị";
            grV_TTB.Columns["tentrangtb"].Caption = "Tên thiết bị";
            grV_TTB.Columns["vixuly"].Visible = false;
            grV_TTB.Columns["diacung"].Visible = false;
            grV_TTB.Columns["manhinh"].Visible = false;
            grV_TTB.Columns["ram"].Visible = false;
            grV_TTB.Columns["ghichu"].Caption = "Ghi chú";
            grV_TTB.Columns["tenphongmay"].Caption = "Tên phòng máy";
            grV_TTB.Columns["dongia"].Visible = false;
        }

        private void grV_TTB_Click(object sender, EventArgs e)
        {
            txt_matb.Text = grV_TTB.GetRowCellValue(grV_TTB.FocusedRowHandle, "matrangtb").ToString();
            txt_tentb.Text = grV_TTB.GetRowCellValue(grV_TTB.FocusedRowHandle, "tentrangtb").ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn thêm dữ liệu này?", "Chú ý!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //conn.Open();
                SqlCommand cm = new SqlCommand("SP_THEMMOITHIETBISUACHUA", strConnect);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@hoadonma", SqlDbType.UniqueIdentifier);
                cm.Parameters["@hoadonma"].Value = cmb_hd.SelectedValue;
                cm.Parameters.Add("@thietbima", SqlDbType.VarChar, 50);
                cm.Parameters["@thietbima"].Value = txt_matb.Text;
                cm.Parameters.Add("@ngaysuachua", SqlDbType.DateTime);
                cm.Parameters["@ngaysuachua"].Value = dtp_ngaysc.Text;
                cm.Parameters.Add("@nguoisuachua", SqlDbType.NVarChar, 100);
                cm.Parameters["@nguoisuachua"].Value = txt_nguoisc.Text;
                cm.Parameters.Add("@chitiethong", SqlDbType.NVarChar, 100);
                cm.Parameters["@chitiethong"].Value = txt_cthh.Text;
                cm.Parameters.Add("@ghinhan", SqlDbType.NVarChar, 50);
                if (rBtn_dsc.Checked)
                    cm.Parameters["@ghinhan"].Value = rBtn_dsc.Text;
                else
                    cm.Parameters["@ghinhan"].Value = rBtn_dsdn.Text;
                cm.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //conn.Close();
                this.Dispose();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}