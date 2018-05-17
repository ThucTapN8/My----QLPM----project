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
    public partial class frm_Hoadonbosung : Form
    {
        private SqlConnection strConnect;

        public frm_Hoadonbosung(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_mahienthi.Text.Equals("") || txt_nguoicap.Text.Equals("") || txt_soluong.Text.Equals("") || dtp_ngaycap.Text.Equals("") || txt_motahd.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("SP_INSERT_hoadonmuabosung", strConnect);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@hienthima", txt_mahienthi.Text));
                        command.Parameters.Add(new SqlParameter("@nguoicap", txt_nguoicap.Text));
                        command.Parameters.Add(new SqlParameter("@ngaycap", Convert.ToDateTime(dtp_ngaycap.Text).ToString("dd/MM/yyyy")));
                        command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txt_soluong.Text).ToString()));
                        command.Parameters.Add(new SqlParameter("@mota", txt_motahd.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_capnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_mahienthi.Text.Equals("") || txt_nguoicap.Text.Equals("") || txt_soluong.Text.Equals("") || dtp_ngaycap.Text.Equals("") || txt_motahd.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("SP_UPDATE_hoadonmuabosung", strConnect);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@mahienthi", txt_mahienthi.Text));
                        command.Parameters.Add(new SqlParameter("@nguoicap", txt_nguoicap.Text));
                        command.Parameters.Add(new SqlParameter("@ngaycap", Convert.ToDateTime(dtp_ngaycap.Text).ToString("dd/MM/yyyy")));
                        command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txt_soluong.Text)));
                        command.Parameters.Add(new SqlParameter("@mota", txt_motahd.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_quaylai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
