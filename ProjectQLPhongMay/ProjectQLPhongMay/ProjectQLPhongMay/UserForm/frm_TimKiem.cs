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
    public partial class frm_TimKiem : Form
    {
        private SqlConnection strConnect;
        public frm_TimKiem(SqlConnection strConnect)
        {
            InitializeComponent();
            this.strConnect = strConnect;
        }

        private void cboChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChon.SelectedItem == "Mã thiết bị")
            {
                SqlDataAdapter da = new SqlDataAdapter("select ma from trangthietbi", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "ma";
                cboNhap.ValueMember = "ma";
                //strConnect.Close();
            }
            else if (cboChon.SelectedItem == "Tên thiết bị") {
                SqlDataAdapter da = new SqlDataAdapter("select ten from trangthietbi", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "ten";
                cboNhap.ValueMember = "ten";
            }
            else if (cboChon.SelectedItem == "Màn hình") {
                SqlDataAdapter da = new SqlDataAdapter("select manhinh from chitietcauhinh", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "manhinh";
                cboNhap.ValueMember = "manhinh";
            }
            else if (cboChon.SelectedItem == "RAM") {
                SqlDataAdapter da = new SqlDataAdapter("select ram from chitietcauhinh", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "ram";
                cboNhap.ValueMember = "ram";
            }
            else if (cboChon.SelectedItem == "Vi xử lý") {
                SqlDataAdapter da = new SqlDataAdapter("select vixuly from chitietcauhinh", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "vixuly";
                cboNhap.ValueMember = "vixuly";
            }
            else if (cboChon.SelectedItem == "Đĩa cứng") {
                SqlDataAdapter da = new SqlDataAdapter("select diacung from chitietcauhinh", strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNhap.DataSource = dt;
                cboNhap.DisplayMember = "diacung";
                cboNhap.ValueMember = "diacung";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboChon.SelectedItem == "Mã thiết bị" || cboChon.SelectedItem == "Tên thiết bị")
            {
                SqlCommand command = new SqlCommand("SP_HIENTHIDG", strConnect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ma", cboNhap.Text.ToString()));
                command.Parameters.Add(new SqlParameter("@ten", cboNhap.Text.ToString()));
                SqlDataAdapter da_TK = new SqlDataAdapter(command);
                DataTable dt_TK = new DataTable();
                da_TK.Fill(dt_TK);

                grid_KetQua.DataSource = dt_TK;
                dgv_TimKiem.Columns["mathietbi"].Caption = "Mã thiết bị";
                dgv_TimKiem.Columns["tenmay"].Caption = "Tên thiết bị";
                dgv_TimKiem.Columns["ram"].Caption = "RAM";
                dgv_TimKiem.Columns["diacung"].Caption = "Đĩa Cứng";
                dgv_TimKiem.Columns["vixuly"].Caption = "Vi Xử Lý";
                dgv_TimKiem.Columns["manhinh"].Caption = "Màn Hình";
                dgv_TimKiem.Columns["dongia"].Caption = "Đơn Giá";
                dgv_TimKiem.Columns["tenphongmay"].Caption = "Tên phòng máy";
                dgv_TimKiem.Columns["ghichu"].Caption = "Ghi chú";
            }
            else if (cboChon.SelectedItem == "Màn hình" || cboChon.SelectedItem == "Vi xử lý" || cboChon.SelectedItem == "RAM" || cboChon.SelectedItem == "Đĩa cứng") {
                SqlCommand command = new SqlCommand("SP_HIENTHI_THIETBI_CAUHINH", strConnect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@manhinh", cboNhap.Text.ToString()));
                command.Parameters.Add(new SqlParameter("@ram", cboNhap.Text.ToString()));
                command.Parameters.Add(new SqlParameter("@vixuly", cboNhap.Text.ToString()));
                command.Parameters.Add(new SqlParameter("@diacung", cboNhap.Text.ToString()));
                SqlDataAdapter da_TK = new SqlDataAdapter(command);
                DataTable dt_TK = new DataTable();
                da_TK.Fill(dt_TK);

                grid_KetQua.DataSource = dt_TK;
                dgv_TimKiem.Columns["tenmay"].Caption = "Tên máy";
                dgv_TimKiem.Columns["manhinh"].Caption = "Màn hình";
                dgv_TimKiem.Columns["diacung"].Caption = "Đĩa cứng";
                dgv_TimKiem.Columns["vixuly"].Caption = "Vi xử lý";
                dgv_TimKiem.Columns["ram"].Caption = "RAM";
            }
        }

        private void frm_TimKiem_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
