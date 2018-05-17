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
    public partial class FrmSuaChua : Form
    {
        SqlConnection conn;
        public string idsc;
        public string mahd;
        public string tbma;
        public FrmSuaChua(SqlConnection kn, string id,string mahdsc,string matb)
        {
            InitializeComponent();
            conn = kn;
            idsc = id;
            mahd = mahdsc;
            tbma = matb;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //conn.Close();
            this.Dispose();
        }

        private void btn_btn_Click(object sender, EventArgs e)
        {
            
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn chỉnh sửa dữ liệu này?", "Chú ý!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //conn.Open();
                    SqlCommand cm = new SqlCommand("SP_CAPNHATTHIETBISUACHUA", conn);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@idctsc", SqlDbType.UniqueIdentifier);
                    cm.Parameters["@idctsc"].Value = new Guid(idsc);

                    cm.Parameters.Add("@mahoadon", SqlDbType.UniqueIdentifier);
                    cm.Parameters["@mahoadon"].Value = new Guid(mahd);

                    cm.Parameters.Add("@matb", SqlDbType.VarChar, 50);
                    cm.Parameters["@matb"].Value = tbma;

                    cm.Parameters.Add("@udngaysuachua", SqlDbType.DateTime);
                    cm.Parameters["@udngaysuachua"].Value = dtp_ngaysc.Text;

                    cm.Parameters.Add("@udnguoisuachua", SqlDbType.NVarChar, 100);
                    cm.Parameters["@udnguoisuachua"].Value = txt_nguoisc.Text;

                    cm.Parameters.Add("@honghoc", SqlDbType.NVarChar, 100);
                    cm.Parameters["@honghoc"].Value = txt_cthh.Text;

                    cm.Parameters.Add("@udghinhan", SqlDbType.NVarChar, 50);
                    if (rBtn_dsc.Checked)
                        cm.Parameters["@udghinhan"].Value = rBtn_dsc.Text;
                    else
                        cm.Parameters["@udghinhan"].Value = rBtn_dsdn.Text; 

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //conn.Close();
                    this.Dispose();
            }
        }

    }
}
