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
    public partial class UcDanhGiaTTB : UserControl
    {
        private SqlConnection strConnect;
        private SqlDataAdapter da_danhgiattb;
        private DataTable dt_danhgiattb;
        public UcDanhGiaTTB(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        private void UcDanhGiaTTB_Load(object sender, EventArgs e)
        {
            da_danhgiattb = new SqlDataAdapter("select * from danhgiatrangthietbi", strConnect);
            dt_danhgiattb = new DataTable();
            da_danhgiattb.Fill(dt_danhgiattb);
            gric_danhgiattb.DataSource = dt_danhgiattb;

            dgv_danhgiattb.Columns["ma"].Visible = true;
        }

        private void btiHienCHiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sad = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ma").ToString();
            string l = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "hienthima").ToString();
            string m = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ngaydanhgia").ToString();
            string n = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "capchatluong").ToString();
            string p = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "ketqua").ToString();
            string o = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "thietbima").ToString();
            frm_ThemChiTietDGTTB add = new frm_ThemChiTietDGTTB(strConnect, sad);
            add.Show();
            add.textBox1.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "hienthima").ToString();
            add.cboCapChatLuong.Text = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "capchatluong").ToString();
            add.txtKetQua.Text = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "ketqua").ToString();
            add.cboMaThietBi.Text = dgv_chitietdanhgiattb.GetRowCellValue(dgv_chitietdanhgiattb.FocusedRowHandle, "thietbima").ToString();
            //add.txtMaDanhGia.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ma").ToString();
            add.datThoiGian.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ngaydanhgia").ToString();
        }

        private void gridControl1_Load( String madanhgia)
        {
            SqlCommand command = new SqlCommand("SP_HIENTHI_CHITIETDGTTB", strConnect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ma",new Guid( madanhgia)));
            SqlDataAdapter da_danhgiatrangthietbi = new SqlDataAdapter(command);
            DataTable dt_danhgaitrangthietbi = new DataTable();
            da_danhgiatrangthietbi.Fill(dt_danhgaitrangthietbi);
            gridControl1.DataSource = dt_danhgaitrangthietbi;
        }

        private void btiThemChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sad = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ma").ToString();
            string m = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ngaydanhgia").ToString();
            frm_ThemChiTietDGTTB ctdgttb = new frm_ThemChiTietDGTTB(strConnect, sad);
            ctdgttb.txtMaDanhGia.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "hienthima").ToString();
            ctdgttb.datThoiGian.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ngaydanhgia").ToString();
            ctdgttb.Show();
        }

        private void btiThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string sdf = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ma").ToString();
            Frm_ThemDGTTB dgttb = new Frm_ThemDGTTB(strConnect);
            //dgttb.txtMaHienThi.Text = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "hienthima").ToString();
            dgttb.Show();
        }

       

        private void gric_danhgiattb_Click(object sender, EventArgs e)
        {

        }

        private void dgv_danhgiattb_Click(object sender, EventArgs e)
        {
            string madanhgia = dgv_danhgiattb.GetRowCellValue(dgv_danhgiattb.FocusedRowHandle, "ma").ToString();
            gridControl1_Load(madanhgia);
        }



        public string asd { get; set; }

        private void btiTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TimKiem tk = new frm_TimKiem(strConnect);
            tk.Show();
        }

        private void btiLamTuoi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //UcDanhGiaTTB_Load(sender, e);
            da_danhgiattb = new SqlDataAdapter("select * from danhgiatrangthietbi", strConnect);
            dt_danhgiattb = new DataTable();
            da_danhgiattb.Fill(dt_danhgiattb);
            gric_danhgiattb.DataSource = dt_danhgiattb;

            dgv_danhgiattb.Columns["ma"].Visible = false;
        }
    }
}
