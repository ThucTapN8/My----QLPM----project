using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ProjectQLPhongMay
{
    public partial class Uc_PhongMay : DevExpress.XtraEditors.XtraUserControl
    {
        private SqlConnection strConnect;
        public Uc_PhongMay(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
            LoadDataPM();
        }

        public void LoadDataPM()
        {
            SqlCommand sqlCommand = new SqlCommand("SP_HIENTHI_PHONGMAY", strConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtPhongMay = new DataTable();
            sqlAdapter.Fill(dtPhongMay);
            grvPhongMay.DataSource = dtPhongMay;
            dgvPhongMay.Columns["maphongmay"].Caption = "Mã phòng máy";
            dgvPhongMay.Columns["tenphongmay"].Caption = "Tên phòng máy";
            dgvPhongMay.Columns["tenphongmay"].Width = 100;
            dgvPhongMay.Columns["soluongbienche"].Caption = "SL Biên Chế";
            dgvPhongMay.Columns["soluongthucte"].Caption = "SL Thực Tế";

        }

        private void dgvPhongMay_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            edtMaPM.Enabled = false;
            edtSLBienChe.Enabled = false;
            btnThemDL.Enabled = false;
            btnXoaPM.Enabled = true;
            //edtTenPM.Enabled = true;
            edtMaPM.Text = dgvPhongMay.GetRowCellValue(dgvPhongMay.FocusedRowHandle, "maphongmay").ToString();
            edtTenPM.Text = dgvPhongMay.GetRowCellValue(dgvPhongMay.FocusedRowHandle, "tenphongmay").ToString();
            edtSLBienChe.Text = dgvPhongMay.GetRowCellValue(dgvPhongMay.FocusedRowHandle, "soluongbienche").ToString();
            edtSLThucTe.Text = dgvPhongMay.GetRowCellValue(dgvPhongMay.FocusedRowHandle, "soluongthucte").ToString();

            LoadDataThietBi(edtMaPM.Text);
        }

        public void LoadDataThietBi(String maPM)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_HienThiTrangThietBiPhongMay", strConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@maPM", maPM));

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtThietBi = new DataTable();
            sqlAdapter.Fill(dtThietBi);
            grvThietBi.DataSource = dtThietBi;
            dgvThietBi.Columns["matrangtb"].Caption = "Mã thiết bị";
            dgvThietBi.Columns["tentrangtb"].Caption = "Tên thiết bị";
            dgvThietBi.Columns["vixuly"].Caption = "Vi xử lý";
            dgvThietBi.Columns["diacung"].Caption = "Ổ đĩa cứng";
            dgvThietBi.Columns["manhinh"].Caption = "Màn hình";
            dgvThietBi.Columns["ram"].Caption = "Ram";
            dgvThietBi.Columns["ghichu"].Caption = "Ghi chú";
            dgvThietBi.Columns["tenphongmay"].Caption = "Tên phòng máy";
            dgvThietBi.Columns["dongia"].Caption = "Đơn giá";
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataPM();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemDL.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoaPM.Enabled = false;
            edtMaPM.Enabled = true;
            edtMaPM.Text = "";
            edtTenPM.Text = "";
            edtSLBienChe.Text = "";
            edtSLBienChe.Enabled = true;
            edtSLThucTe.Text = "0";
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Đồng ý thêm "+edtTenPM.Text+"?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int soluong = 0;
                try
                {
                    soluong = int.Parse(edtSLBienChe.Text);
                    SqlCommand sqlCommand = new SqlCommand("SP_THEM_PHONGMAY", strConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@ma", edtMaPM.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@ten", edtTenPM.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@soluong", soluong));
                    sqlCommand.ExecuteNonQuery();
                    XtraMessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                   
                    XtraMessageBox.Show("Thêm mới không thành công!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataPM();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnXoaPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Đồng ý xóa "+edtTenPM.Text+"?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("SP_XOA_PHONGMAY", strConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@ma", edtMaPM.Text));
                    sqlCommand.ExecuteNonQuery();
                    XtraMessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Xóa dữ liệu không thành công!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataPM();
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Đồng ý cập nhật "+edtTenPM.Text+"?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("SP_CAPNHAT_PHONGMAY", strConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@MaPM", edtMaPM.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@ten", edtTenPM.Text));
                    sqlCommand.ExecuteNonQuery();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Cập nhật dữ liệu không thành công!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataPM();
        }
    }
}
