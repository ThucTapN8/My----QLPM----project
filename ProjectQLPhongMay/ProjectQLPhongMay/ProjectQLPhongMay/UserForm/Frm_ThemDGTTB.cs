using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectQLPhongMay
{
    public partial class Frm_ThemDGTTB : Form
    {
        private SqlConnection strConnect;
        public Frm_ThemDGTTB(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        public Frm_ThemDGTTB()
        {
            // TODO: Complete member initialization
        }

        private void btiThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaHienThi.Text.Equals("")|| txtNguoiDanhGia.Text.Equals("") || datNgayDanhGia.Text.Equals("")) {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else{
                //try
                //{
                    SqlCommand command = new SqlCommand("SP_THEMDGTTB", strConnect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", txtMaHienThi.Text.ToString()));
                    command.Parameters.Add(new SqlParameter("@nguoidanhgia", txtNguoiDanhGia.Text.ToString()));
                    command.Parameters.Add(new SqlParameter("@ngaydanhgia",datNgayDanhGia.Value));
                    command.Parameters.Add(new SqlParameter("@mota", txtMoTa.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm vào thành công", "Thông báo", MessageBoxButtons.OK);
                }
                //catch {
                //    MessageBox.Show("Có lỗi xảy ra, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
        }
    }
}
