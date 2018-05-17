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
    public partial class frm_Timkiemthietbibosung : Form
    {
        private SqlConnection strConnect;
        public frm_Timkiemthietbibosung(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlCommand command = new SqlCommand("SP_Hienthithietbibosungtheothoigian", strConnect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@time1",  dtp_start.Value));
            command.Parameters.Add(new SqlParameter("@time2", dtp_finish.Value));

            SqlDataAdapter da_timkiem = new SqlDataAdapter(command);
            DataTable dt_timkiem = new DataTable();
            da_timkiem.Fill(dt_timkiem);

            gric_timkiem.DataSource = dt_timkiem;

            dgv_timkiem.Columns["ma"].Caption = "Mã thiết bị";
            dgv_timkiem.Columns["ten"].Caption = "Tên thiết bị";
            dgv_timkiem.Columns["ram"].Caption = "RAM";
            dgv_timkiem.Columns["vixuly"].Caption = "Vi xử lý";
            dgv_timkiem.Columns["manhinh"].Caption = "Màn hình";
            dgv_timkiem.Columns["diacung"].Caption = "Đĩa cứng";
            dgv_timkiem.Columns["dongia"].Caption = "Đơn giá";
            dgv_timkiem.Columns["ghinhan"].Caption = "Ghi nhận";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
