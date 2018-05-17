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
    public partial class UcSuaChuaTB : UserControl
    {
        public ICallBack ICall { get; set; }
        SqlConnection con;
        public UcSuaChuaTB(SqlConnection connect)
        {
            InitializeComponent();
            con = connect;
            //con.Open();
        }

        private void UcSuaChuaTB_Load(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand("SP_THONGTINTHIETBISUACHUA", con);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            grC_sctb.DataSource = tb;

            grv_sctb.Columns["ma"].Visible = false;
            grv_sctb.Columns["mahd"].Visible = false;
            grv_sctb.Columns["hienthima"].Caption = "Mã hóa đơn";
            grv_sctb.Columns["thietbima"].Caption = "Mã thiết bị";
            grv_sctb.Columns["ten"].Caption = "Thiết bị";
            grv_sctb.Columns["ngaysuachua"].Caption = "Ngày sửa chữa";
            grv_sctb.Columns["nguoisuachua"].Caption = "Người sửa chữa";
            grv_sctb.Columns["chitiethonghoc"].Caption = "Chi tiết hỏng hóc";
            grv_sctb.Columns["ghinhan"].Caption = "Ghi nhận";
        }

        private void btn_themmoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThemMoiSCTB frm = new FrmThemMoiSCTB(con);
            frm.rBtn_dsc.Checked = true;
            frm.Show();
        }

        private void btn_capnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmSuaChua frm = new FrmSuaChua(con, grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "ma").ToString(), grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "mahd").ToString(),grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "thietbima").ToString());
            frm.btn_btn.Text = "CẬP NHẬT";
            frm.txtHoadon.Text = grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "hienthima").ToString();
            frm.txtTB.Text = grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "ten").ToString();
            frm.dtp_ngaysc.Text = grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "ngaysuachua").ToString();
            frm.txt_nguoisc.Text = grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "nguoisuachua").ToString();
            frm.txt_cthh.Text = grv_sctb.GetRowCellValue(grv_sctb.FocusedRowHandle, "chitiethonghoc").ToString();
            frm.Show();
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlCommand cm = new SqlCommand("SP_THONGTINTHIETBISUACHUA", con);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            grC_sctb.DataSource = tb;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICall.ClickExit(4);
            //con.Close();
            this.Dispose();
        }

        private void cmb_menu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_menu1.SelectedIndex == 0)
            {
                cmb_menu2.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from hoadonsuachua", con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                cmb_menu2.DataSource = tb;
                cmb_menu2.DisplayMember = "hienthima";
                cmb_menu2.ValueMember = "ma";
            }
            else if (cmb_menu1.SelectedIndex == 1)
            {
                cmb_menu2.DataSource = null;
                for (int i = 1960; i <= DateTime.Today.Year; i++)
                {
                    cmb_menu2.Items.Add(i.ToString());
                }
            }
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (cmb_menu1.SelectedIndex == 0)
            {
                //con.Open();
                SqlCommand cm = new SqlCommand("SP_DANHSACHTBSCTRONGHOADON", con);
                cm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                
                cm.Parameters.Add("@hoadonma", SqlDbType.UniqueIdentifier);
                cm.Parameters["@hoadonma"].Value = cmb_menu2.SelectedValue;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);

                grC_sctb.DataSource = dt;
                //con.Close();
            }
            else if (cmb_menu1.SelectedIndex == 1)
            {
                //con.Open();
                SqlCommand cm = new SqlCommand("SP_DANHSACHTBSCTRONGNAM", con);
                cm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                cm.Parameters.Add("@theyear", SqlDbType.Int);
                cm.Parameters["@theyear"].Value = int.Parse(cmb_menu2.SelectedItem.ToString());
                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);

                grC_sctb.DataSource = dt;
                //con.Close();
            }
        }
    }
}
