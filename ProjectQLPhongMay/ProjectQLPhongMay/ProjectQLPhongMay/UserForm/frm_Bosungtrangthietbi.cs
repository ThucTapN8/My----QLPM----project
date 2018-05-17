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
    public partial class frm_Bosungtrangthietbi : Form
    {
        private SqlConnection strConnect;
        public frm_Bosungtrangthietbi(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn bổ sung trang thiết bị không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_Bosungthietbimoi", strConnect);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@phongmayma", cmb_mapmbosung.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@ma", txt_matbbosung.Text));
                    command.Parameters.Add(new SqlParameter("@ngaybosung", dateTngaybosung.Value));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Bổ sung thiết bị thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi bổ sung thiết bị vào phòng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_Bosungtrangthietbi_Load(object sender, EventArgs e)
        {
            string command = "select * from phongmay";
            SqlDataAdapter da_phongmay = new SqlDataAdapter(command, strConnect);
            DataTable dt_phongmay = new DataTable();
            da_phongmay.Fill(dt_phongmay);
            cmb_mapmbosung.DataSource = dt_phongmay;
            cmb_mapmbosung.DisplayMember = "ten";
            cmb_mapmbosung.ValueMember = "ma";
            cmb_mapmbosung.SelectedIndex = -1;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
