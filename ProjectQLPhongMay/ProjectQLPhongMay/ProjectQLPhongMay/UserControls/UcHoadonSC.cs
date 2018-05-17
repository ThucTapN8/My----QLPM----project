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
    public partial class UcHoadonSC : UserControl
    {
        SqlConnection con;
        public ICallBack ICall { get; set; }
        public UcHoadonSC(SqlConnection connect)
        {
            InitializeComponent();
            con = connect;
        }

        private void UcHoadonSC_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hoadonsuachua", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grC_HoaDon.DataSource = dt;

            grV_hoadon.Columns["ma"].Visible = false;
            grV_hoadon.Columns["hienthima"].Caption = "Mã hóa đơn";
            grV_hoadon.Columns["nguoicap"].Caption = "Người cấp";
            grV_hoadon.Columns["ngaycap"].Caption = "Ngày cấp";
            grV_hoadon.Columns["donvisuachua"].Caption = "Đơn vị sửa chữa";
            grV_hoadon.Columns["mota"].Caption = "Mô tả";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICall.ClickExit(7);
            //con.Close();
            this.Dispose();
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hoadonsuachua", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grC_HoaDon.DataSource = dt;
        }

        private void btnThemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHoaDonSC frm = new FrmHoaDonSC(con, "them","");
            frm.btn_btn.Text = "Thêm mới";
            frm.Show();
        }

        private void btnCapnhatHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHoaDonSC frm = new FrmHoaDonSC(con, "capnhat",grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle,"ma").ToString());
            
            frm.btn_btn.Text = "Cập nhật";

            frm.txtMaHD.Text = grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle, "hienthima").ToString();
            frm.txtNguoicap.Text = grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle, "nguoicap").ToString();
            frm.dtp_ngaycap.Text = grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle, "ngaycap").ToString();
            frm.txt_dvsc.Text = grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle, "donvisuachua").ToString();
            frm.rTxt_mota.Text = grV_hoadon.GetRowCellValue(grV_hoadon.FocusedRowHandle, "mota").ToString();

            frm.Show();
        }
    }
}
