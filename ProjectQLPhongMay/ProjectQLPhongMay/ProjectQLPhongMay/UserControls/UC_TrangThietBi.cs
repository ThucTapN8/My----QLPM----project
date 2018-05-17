using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectQLPhongMay
{
    public partial class UC_TrangThietBi : UserControl
    {
        private SqlConnection strConnect;
        public ICallBack ICall { get; set; }

        public UC_TrangThietBi(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
            LoadComboBox();
        }
        public void LoadComboBox()
        {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From phongmay", strConnect);
                da.Fill(dt);
                cmb_PhongMay.DataSource = dt;
                cmb_PhongMay.DisplayMember = "ten";
                cmb_PhongMay.ValueMember = "ma";
                cmb_PhongMay.SelectedIndex = -1;
               
        }
        private void grc_TrangThietBi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            string mattb = txt_MaTrangThietBi.Text;
            SP_TimKiemTheoMaTTB(mattb);
            if (grv_ThongTinTrangThietBi.RowCount >= 1 )
            {
                form_CapNhatGhiChu frm_CapNhatGhiChu = new form_CapNhatGhiChu(mattb,strConnect);
                frm_CapNhatGhiChu.Show();
                
            }
            else
            {
                MessageBox.Show("Không tồn tại trang thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SP_HienThiTrangThietBiPhongMay(string mapm) {
            SqlCommand comm = new SqlCommand("SP_HienThiTrangThietBiPhongMay", strConnect);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = "@MaPM";
            pr.Value = mapm;
            comm.Parameters.Add(pr);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            grid_ThongTinTrangThietBi.DataSource = dt1;
            grv_ThongTinTrangThietBi.Columns["matrangtb"].Caption = "Mã trang thiết bị";
            grv_ThongTinTrangThietBi.Columns["tentrangtb"].Caption = "Tên trang thiết bị";
            grv_ThongTinTrangThietBi.Columns["vixuly"].Caption = " Vi xử lý";
            grv_ThongTinTrangThietBi.Columns["diacung"].Caption = " Đĩa cứng";
            grv_ThongTinTrangThietBi.Columns["manhinh"].Caption = " Màn hình";
            grv_ThongTinTrangThietBi.Columns["ram"].Caption = "  Ram";
            grv_ThongTinTrangThietBi.Columns["ghichu"].Caption = "              Ghi chú";
            grv_ThongTinTrangThietBi.Columns["tenphongmay"].Caption = "Tên phòng máy";
            grv_ThongTinTrangThietBi.Columns["dongia"].Caption = "  Đơn giá";

            grv_ThongTinTrangThietBi.Columns["matrangtb"].Width = 170;
            grv_ThongTinTrangThietBi.Columns["tentrangtb"].Width = 180;
            grv_ThongTinTrangThietBi.Columns["vixuly"].Width = 100;
            grv_ThongTinTrangThietBi.Columns["diacung"].Width = 80;
            grv_ThongTinTrangThietBi.Columns["manhinh"].Width = 120;
            grv_ThongTinTrangThietBi.Columns["ram"].Width = 70;
            grv_ThongTinTrangThietBi.Columns["ghichu"].Width = 170;
            grv_ThongTinTrangThietBi.Columns["tenphongmay"].Width = 140;
            grv_ThongTinTrangThietBi.Columns["dongia"].Width = 80;
        }
        private void cmb_PhongMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mapm = cmb_PhongMay.SelectedValue.ToString();
                SP_HienThiTrangThietBiPhongMay(mapm);
            }
            catch { 
            }
                     
        }
        public void SP_HienThiDanhSachCapNhatTrangThietBi(string mattb) {
            SqlCommand comm = new SqlCommand("SP_HienThiDanhSachCapNhatTrangThietBi", strConnect);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = "@MaTTB";
            pr.Value = mattb;
            comm.Parameters.Add(pr);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            grid_DanhsachCapNhatGhiChu.DataSource = dt1;

            grv_ThongKeGhiChu.Columns["ma"].Caption = "                      Mã đánh giá";
            grv_ThongKeGhiChu.Columns["thietbima"].Caption = "  Mã trang thiết bị";
            grv_ThongKeGhiChu.Columns["tinhtrangma"].Caption = "Mã tình trạng";
            grv_ThongKeGhiChu.Columns["nguoidanhgia"].Caption = "Người đánh giá";
            grv_ThongKeGhiChu.Columns["ngaydanhgia"].Caption = "Ngày đánh giá";
            grv_ThongKeGhiChu.Columns["mota"].Caption = "                               Mô tả";

            grv_ThongKeGhiChu.Columns["ma"].Width = 200;
            grv_ThongKeGhiChu.Columns["thietbima"].Width = 100;
            grv_ThongKeGhiChu.Columns["tinhtrangma"].Width = 70;
            grv_ThongKeGhiChu.Columns["nguoidanhgia"].Width = 120;
            grv_ThongKeGhiChu.Columns["ngaydanhgia"].Width = 100;
            grv_ThongKeGhiChu.Columns["mota"].Width = 200;        
        }
        private void grid_ThongTinTrangThietBi_Click(object sender, EventArgs e)
        {
            try
            {

                txt_MaTrangThietBi.Text = grv_ThongTinTrangThietBi.GetRowCellValue(grv_ThongTinTrangThietBi.FocusedRowHandle, "matrangtb").ToString();
            }
            catch {
                txt_MaTrangThietBi.Text = "";
            }
            group_dsCapNhatGhiChu.Visible = true;
            string mattb = txt_MaTrangThietBi.Text;
            SP_HienThiDanhSachCapNhatTrangThietBi(mattb);
            txt_Count.Text = grv_ThongKeGhiChu.RowCount.ToString();
        }

        private void txt_MaTrangThietBi_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txt_MaTrangThietBi.Text.Equals(""))
                {
                    cmb_PhongMay_SelectedIndexChanged(sender, e);
                    if (grv_ThongTinTrangThietBi.RowCount == 0)
                        MessageBox.Show("Bạn chưa chọn phòng máy hoặc điền mã phòng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
                }
                else if (!txt_MaTrangThietBi.Text.Equals(""))
                {
                    SP_TimKiemTheoMaTTB(txt_MaTrangThietBi.Text);
                    if (grv_ThongTinTrangThietBi.RowCount == 0)
                        MessageBox.Show("Không tồn tại trang thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Bạn chưa chọn phòng máy hoặc điền mã phòng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SP_TimKiemTheoMaTTB(string mattb) {
            SqlCommand comm = new SqlCommand("SP_TimKiemTheoMaTTB", strConnect);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = "@MaTTB";
            pr.Value = mattb;
            comm.Parameters.Add(pr);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            grid_ThongTinTrangThietBi.DataSource = dt2;
        }
        public void SP_SoLanCapNhatTrangThai(string mattb) {
            //SqlCommand comm = new SqlCommand("SP_SoLanCapNhatTrangThai", strConnect);
            //comm.CommandType = CommandType.StoredProcedure;
            //SqlParameter pr = new SqlParameter();
            //pr.ParameterName = "@MaTTB";
            //pr.Value = mattb;
            //comm.Parameters.Add(pr);
            //SqlDataAdapter da = new SqlDataAdapter(comm);
            //DataTable dt2 = new DataTable();
            //da.Fill(dt2);
            //txt_Count.Text = dt2;
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string mapm = cmb_PhongMay.SelectedValue.ToString();
                string mattb = txt_MaTrangThietBi.Text;
                SP_HienThiTrangThietBiPhongMay(mapm);
                SP_HienThiDanhSachCapNhatTrangThietBi(mattb);
            }
            catch { }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICall.ClickExit(1);
            this.Dispose();
        }
    }
}
