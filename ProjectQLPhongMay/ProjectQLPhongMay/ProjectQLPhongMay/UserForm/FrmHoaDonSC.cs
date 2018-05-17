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
    public partial class FrmHoaDonSC : Form
    {
        SqlConnection conn;
        public string chon;
        public string idhd;
        public FrmHoaDonSC(SqlConnection connect, string check,string id)
        {
            conn = connect;
            chon = check;
            idhd = id;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Dispose();
        }

        private void btn_btn_Click(object sender, EventArgs e)
        {
            if (chon == "them")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn thêm dữ liệu", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    //conn.Open();
                    SqlCommand cm = new SqlCommand("SP_THEMMOIHOADONSC", conn);
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add("@nguoicap", SqlDbType.NVarChar, 50);
                    cm.Parameters.Add("@mahienthi", SqlDbType.NVarChar, 20);
                    cm.Parameters.Add("@ngaycap", SqlDbType.DateTime);
                    cm.Parameters.Add("@donvisuachua", SqlDbType.NVarChar, 50);
                    cm.Parameters.Add("@mota", SqlDbType.NVarChar);

                    cm.Parameters["@mahienthi"].Value = txtMaHD.Text;
                    cm.Parameters["@nguoicap"].Value = txtNguoicap.Text;
                    cm.Parameters["@ngaycap"].Value = dtp_ngaycap.Text;
                    cm.Parameters["@donvisuachua"].Value = txt_dvsc.Text;
                    cm.Parameters["@mota"].Value = rTxt_mota.Text;

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //conn.Close();
                    this.Dispose();
                }
            }
            else if (chon == "capnhat")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn chỉnh sửa dữ liệu này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    //conn.Open();
                    SqlCommand cm = new SqlCommand("SP_CAPNHATHOADONSC", conn);
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add("@idhd", SqlDbType.UniqueIdentifier);
                    cm.Parameters.Add("@udnguoicap", SqlDbType.NVarChar, 50);
                    cm.Parameters.Add("@udmahienthi", SqlDbType.NVarChar, 20);
                    cm.Parameters.Add("@udngaycap", SqlDbType.DateTime);
                    cm.Parameters.Add("@uddonvisuachua", SqlDbType.NVarChar, 50);
                    cm.Parameters.Add("@udmota", SqlDbType.NVarChar);

                    cm.Parameters["@idhd"].Value = new Guid(idhd);
                    cm.Parameters["@udmahienthi"].Value = txtMaHD.Text;
                    cm.Parameters["@udnguoicap"].Value = txtNguoicap.Text;
                    cm.Parameters["@udngaycap"].Value = dtp_ngaycap.Text;
                    cm.Parameters["@uddonvisuachua"].Value = txt_dvsc.Text;
                    cm.Parameters["@udmota"].Value = rTxt_mota.Text;

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //conn.Close();
                    this.Dispose();
                }
            }
        }

    }
}
