using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProjectQLPhongMay
{
    public partial class frmDieuchuyen : Form
    {
        private SqlConnection cnn;
        public short opt;
        public Guid ma;
        public frmDieuchuyen(SqlConnection CNNs)
        {
            InitializeComponent();
            cnn = CNNs;
        }
        void load_comboBox()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from phongmay", cnn);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                data.Fill(table);
                foreach (DataRow dtr in table.Rows)
                {
                    cbnPmden.Items.Add(dtr["ma"]);
                    cbnPMDi.Items.Add(dtr["ma"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex);
            }
            
        }
        private void frmDieuchuyen_Load(object sender, EventArgs e)
        {
            load_comboBox();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opt == 0)
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_ThemhoadonDieuchuyen", cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@hienthima", txtMaHT.Text));
                    command.Parameters.Add(new SqlParameter("@nguoidieuchuyen", txtNgTH.Text));
                    command.Parameters.Add(new SqlParameter("@ngaydieuchuyen", dtpNgayDC.Value));
                    command.Parameters.Add(new SqlParameter("@phongdima", cbnPMDi.SelectedItem.ToString()));
                    command.Parameters.Add(new SqlParameter("@phongdenma", cbnPmden.SelectedItem.ToString()));
                    command.ExecuteNonQuery();
                    MessageBox.Show("bạn có chắc chắn muốn thêm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }
                
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_SuahoadonDieuchuyen", cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ma", ma);
                    command.Parameters.Add(new SqlParameter("@hienthima", txtMaHT.Text));
                    command.Parameters.Add(new SqlParameter("@nguoidieuchuyen", txtNgTH.Text));
                    command.Parameters.Add(new SqlParameter("@ngaydieuchuyen", dtpNgayDC.Value));
                    command.Parameters.Add(new SqlParameter("@phongdima", cbnPMDi.Text));
                    command.Parameters.Add(new SqlParameter("@phongdenma", cbnPmden.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("bạn có chắc chắn muốn thêm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }
            }
        }
    }
}
