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
    public partial class frm_ThemChiTietDGTTB : Form
    {

        private SqlConnection strConnect;
        public string a;
        public frm_ThemChiTietDGTTB(SqlConnection strConnect, string a)
        {
            InitializeComponent();
            this.strConnect = strConnect;
            this.a = a;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboMaThietBi.Text.Equals("") || cboCapChatLuong.Text.Equals("") || txtKetQua.Text.Equals("") || datThoiGian.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {

                    SqlCommand command = new SqlCommand("SP_THEMCTDGTTB", strConnect);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@thietbima", cboMaThietBi.Text.ToString()));
                    command.Parameters.Add(new SqlParameter("@danhgiama", a));
                    command.Parameters.Add(new SqlParameter("@capchatluong", cboCapChatLuong.SelectedItem));
                    command.Parameters.Add(new SqlParameter("@ketqua", txtKetQua.Text));
                    command.Parameters.Add(new SqlParameter("@thoigian", datThoiGian.Value));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void frm_ThemChiTietDGTTB_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
         
            
                SqlDataAdapter da = new SqlDataAdapter("select ma, ten from trangthietbi", strConnect);
                da.Fill(dt);
                cboMaThietBi.DataSource = dt.Copy();
                cboMaThietBi.DisplayMember = "ma";
                cboMaThietBi.ValueMember = "ten";
                //strConnect.Close();
            
        }

        private void btiCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (cboMaThietBi.Text.Equals("") || cboCapChatLuong.Text.Equals("") || txtKetQua.Text.Equals("") || datThoiGian.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật chi tiết đánh giá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {

                    try
                    {
                    SqlCommand command = new SqlCommand("SP_SUACTDGTTB", strConnect);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@thietbima", cboMaThietBi.Text.ToString()));
                        //command.Parameters.Add(new SqlParameter("@danhgiama", new Guid(a)));
                        command.Parameters.Add(new SqlParameter("@capchatluong", cboCapChatLuong.SelectedItem));
                        command.Parameters.Add(new SqlParameter("@ketqua", txtKetQua.Text));
                        command.Parameters.Add(new SqlParameter("@thoigian", datThoiGian.Value));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("CÓ lỗi xảy ra, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cboMaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
