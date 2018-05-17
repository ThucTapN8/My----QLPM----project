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
    public partial class UC_Bosungtrangthietbi : UserControl
    {
        private SqlConnection strConnect;
        public ICallBack ICall { get; set; }
        public UC_Bosungtrangthietbi(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;

        }

        //load dữ liệu lên grid control hoadonmuabosung
        private void UC_Bosungtrangthietbi_Load(object sender, EventArgs e)
        {
            string command = "select * from hoadonmuabosung";
            SqlDataAdapter da_hoadonbs = new SqlDataAdapter(command, strConnect);
            DataTable dt_hoadonbs = new DataTable();
            da_hoadonbs.Fill(dt_hoadonbs);
            gric_hdbs.DataSource = dt_hoadonbs;

            //đặt tên cho các cột
            dgv_hoadonbs.Columns["ma"].Visible = false;
            dgv_hoadonbs.Columns["nguoicap"].Caption = "Người cấp";
            dgv_hoadonbs.Columns["ngaycap"].Caption = "Ngày cấp";
            dgv_hoadonbs.Columns["mota"].Caption = "Mô tả hóa đơn";
            dgv_hoadonbs.Columns["hienthima"].Caption = "Mã hóa đơn";
            dgv_hoadonbs.Columns["soluong"].Caption = "Số lượng";

            //xét size cho các cột
            dgv_hoadonbs.Columns["hienthima"].Width = 80;
            dgv_hoadonbs.Columns["nguoicap"].Width = 100;
            dgv_hoadonbs.Columns["soluong"].Width = 35;
            dgv_hoadonbs.Columns["ngaycap"].Width = 50;
        }

        //Click 1 hóa đơn sẽ hiển thị lên grid control chitiethdbs
        private void dgv_hoadonbs_Click(object sender, EventArgs e)
        {
            btn_capnhathd.Enabled = true;
            string mahoadon = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "ma").ToString();
            gric_chitiethdbs_Load(mahoadon);
        }

        //load dữ liệu ở grid control chitiethdbs
        private void gric_chitiethdbs_Load(String mahoadon)
        {
            SqlCommand command = new SqlCommand("SP_SELECT_chitiethoadonmuabosung", strConnect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ma", mahoadon));
            SqlDataAdapter da_chitiethdbs = new SqlDataAdapter(command);
            DataTable dt_chitiethdbs = new DataTable();
            da_chitiethdbs.Fill(dt_chitiethdbs);
            gric_chitiethdbs.DataSource = dt_chitiethdbs;

            dgv_chitiethdbs.Columns["hienthima"].Caption = "Mã hóa đơn";
            dgv_chitiethdbs.Columns["ma"].Caption = "Mã thiết bị";
            dgv_chitiethdbs.Columns["ten"].Caption = "Tên thiết bị";
            dgv_chitiethdbs.Columns["dongia"].Caption = "Đơn giá";
            dgv_chitiethdbs.Columns["ghinhan"].Caption = "Ghi nhận";
            dgv_chitiethdbs.Columns["diacung"].Caption = "Đĩa cứng";
            dgv_chitiethdbs.Columns["manhinh"].Caption = "Màn hình";
            dgv_chitiethdbs.Columns["ram"].Caption = "Ram";
            dgv_chitiethdbs.Columns["vixuly"].Caption = "Vi xử lý";
            dgv_chitiethdbs.Columns["mota"].Caption = "Mô tả thiết bị";
        }

        //click button thêm sẽ sang frm_hoadonbosung
        private void btn_themhd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Hoadonbosung hdbs = new frm_Hoadonbosung(strConnect);
            hdbs.btn_capnhat.Enabled = false;
            hdbs.Show();
        }

        //click button timkiem sẽ sang frm_timkiemthietbibosung
        private void btn_timkiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm_Timkiemthietbibosung timkiemtbbs = new frm_Timkiemthietbibosung(strConnect);
            timkiemtbbs.Show();
        }

        //click button bosung sẽ sang frm_bosungtrangthietbi thực hiện chức năng bổ sung thiết bị vào phòng máy nào đó
        private void btn_bosungtb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string a = dgv_chitiethdbs.GetRowCellValue(dgv_chitiethdbs.FocusedRowHandle, "ma").ToString();
                string ghinhan = dgv_chitiethdbs.GetRowCellValue(dgv_chitiethdbs.FocusedRowHandle, "ghinhan").ToString();
                bool ghinhan1 = bool.Parse(ghinhan);
                if (ghinhan1 == true)
                {
                    MessageBox.Show("Thiết bị đã được bổ sung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    frm_Bosungtrangthietbi bosungttb = new frm_Bosungtrangthietbi(strConnect);
                    bosungttb.Show();

                    //chuyển dữ liệu sang ô text box matbbossung ở frm_bosungttb
                    bosungttb.txt_matbbosung.Text = dgv_chitiethdbs.GetRowCellValue(dgv_chitiethdbs.FocusedRowHandle, "ma").ToString();
                }

            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn thiết bị bổ sung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //click button sẽ sang frm_chitiethoadonbosung
        private void btn_themchitiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string soluong = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "soluong").ToString();
            int soluong1 = int.Parse(soluong);
            int temp = dgv_chitiethdbs.RowCount;
            if (temp >= soluong1)
            {
                MessageBox.Show("Không thể thêm chi tiết hóa đơn bổ sung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //truyền mã unique sang frm_chitiethoadonbosung
                string a = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "ma").ToString();
                frm_Chitiethoadonbosung cthdbs = new frm_Chitiethoadonbosung(strConnect, a);

                //chuyển dữ liệu sang textbox hiển thị mã hóa đơn theo hienthima
                cthdbs.txt_mahd.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "hienthima").ToString();

                cthdbs.Show();
            }
        }

        //click button sẽ sang frm_hoadonbosung thực hiện chức năng cập nhật hóa đơn
        private void btn_capnhathd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Hoadonbosung hdbs = new frm_Hoadonbosung(strConnect);
            hdbs.Show();

            hdbs.txt_mahienthi.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "hienthima").ToString();
            hdbs.txt_soluong.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "soluong").ToString();
            hdbs.txt_nguoicap.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "nguoicap").ToString();
            hdbs.txt_motahd.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "mota").ToString();
            hdbs.dtp_ngaycap.Text = dgv_hoadonbs.GetRowCellValue(dgv_hoadonbs.FocusedRowHandle, "ngaycap").ToString();

            hdbs.btn_them.Enabled = false;
            hdbs.txt_mahienthi.Enabled = false;
        }

        private void btn_lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_Bosungtrangthietbi_Load(sender, e);
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICall.ClickExit(5);
            this.Dispose();
        }

    }
}
