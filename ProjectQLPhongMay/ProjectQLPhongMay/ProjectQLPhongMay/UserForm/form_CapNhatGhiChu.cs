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
    public partial class form_CapNhatGhiChu : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection strConnect;
        private string mattb;
        public form_CapNhatGhiChu(string a,SqlConnection strConnect)
        {
            mattb = a;
            InitializeComponent();
            this.strConnect = strConnect;
        }
        private void form_CapNhatGhiChu_Load(object sender, EventArgs e)
        {
            txt_MaTrangThietBi.Text = mattb;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From phancaptinhtrang", strConnect);
            da.Fill(dt);
            cmb_TinhTrang.DataSource = dt;
            cmb_TinhTrang.DisplayMember = "tinhtrang";
            cmb_TinhTrang.ValueMember = "ma";
            cmb_TinhTrang.SelectedIndex = -1;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_NguoiDanhGia.Text.Equals("") || richEditControl1.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn cập nhật không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    try
                    {                        
                        SqlCommand comm = new SqlCommand("SP_UpdateTinhTrangThietBi", strConnect);
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.Add(new SqlParameter("@thietbima", txt_MaTrangThietBi.Text));

                        comm.Parameters.Add(new SqlParameter("@tinhtrangma", int.Parse(cmb_TinhTrang.SelectedValue.ToString())));
                        
                        comm.Parameters.Add(new SqlParameter("@ngaydanhgia",Convert.ToDateTime(dtP_NgayDanhGia.Text).ToString("MM/dd/yyyy")));

                        comm.Parameters.Add(new SqlParameter("@nguoidanhgia",txt_NguoiDanhGia.Text));                        

                        comm.Parameters.Add(new SqlParameter("@mota",richEditControl1.Text));                       

                        //comm.ExecuteReader();
                        comm.ExecuteNonQuery();                     
                        
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Dispose();                      
                        
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_NguoiDanhGia.Text = "";
            rich_MoTa.Text = "";
            cmb_TinhTrang.Text = "";
        }
    }
}