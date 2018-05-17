using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProjectQLPhongMay
{
    public partial class UcDieuChuyen : UserControl
    {
        private SqlConnection Cns;
        public UcDieuChuyen(SqlConnection ConnS)
        {
            InitializeComponent();
            this.Cns = ConnS;

        }
        void selectRow()
        {

        }
        void dieuchuyen_Load()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SP_LayhoadonDieuchuyen", Cns);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                data.Fill(table);
                sqlCommand.ExecuteNonQuery();
                gridControl1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex);
            }
        }

        void chitietdieuchuyen_Load()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SP_LaychitietDieuchuyen", Cns);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                data.Fill(table);
                sqlCommand.ExecuteNonQuery();
                gridControl2.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex);
            }
        }
        private void UcDieuChuyen_Load(object sender, EventArgs e)
        {
            dieuchuyen_Load();
            chitietdieuchuyen_Load();
            loadcombobox();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDieuchuyen frm = new frmDieuchuyen(Cns);
            frm.opt = 0;
            frm.ShowDialog();
            dieuchuyen_Load();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDieuchuyen frm = new frmDieuchuyen(Cns);
                frm.opt = 1;
                frm.ma = Guid.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ma").ToString());
                frm.txtMaHT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hienthima").ToString();
                frm.txtNgTH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nguoidieuchuyen").ToString();
                frm.dtpNgayDC.Value = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngaydieuchuyen").ToString());
                frm.cbnPmden.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "phongdenma").ToString();
                frm.cbnPMDi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "phongdima").ToString();
                frm.ShowDialog();
                dieuchuyen_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex);
            }
            
            
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Guid ma = Guid.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ma").ToString());
                DialogResult dialog = MessageBox.Show("bạn chắc muốn xóa đi không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("SP_XoahoadonDieuchuyen", Cns);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", ma));
                    command.ExecuteNonQuery();
                    dieuchuyen_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex);
            }
            
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dieuchuyen_Load();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                lbmahienthi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hienthima").ToString();
                lbNguoiDC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nguoidieuchuyen").ToString();
                lbngaydieuchuyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngaydieuchuyen").ToString();
                lbphongdieuden.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "phongdenma").ToString();
                lbphongdieudi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "phongdima").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi:" + ex);
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
                SqlCommand command = new SqlCommand("SP_INSERTANDUPDATECHITIETDIEUCHUYEN", Cns);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@thietbima", cbnmathietbi.SelectedItem.ToString()));
                command.Parameters.Add(new SqlParameter("@dondcma", cbnmahoadon.SelectedValue.ToString()));
                command.Parameters.Add(new SqlParameter("@danhgiama", cbnmadanhgia.SelectedValue.ToString()));
                command.Parameters.Add(new SqlParameter("@ngaydieuchuyen", dtpngaydieuchuyen.Value));
                command.ExecuteNonQuery();
                MessageBox.Show("bạn có chắc chắn muốn thêm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //} catch(Exception ex)
            //{
            //    MessageBox.Show("lỗi:" + ex);
            //}
            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn chắc muốn xóa đi không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("SP_Xoachitietdieuchuyen", Cns);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ma", gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ma").ToString()));
                command.ExecuteNonQuery();
                chitietdieuchuyen_Load();
            }
        }
        void loadcombobox()
        {
            SqlCommand command1 = new SqlCommand("select * from dieuchuyentrangthietbi", Cns);
            SqlDataAdapter data1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            data1.Fill(table1);
            cbnmahoadon.DataSource=table1;
            cbnmahoadon.DisplayMember="hienthima";
            cbnmahoadon.ValueMember="ma";
            SqlCommand command2 = new SqlCommand("select * from tinhtrangthietbi", Cns);
            SqlDataAdapter data2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();
            data2.Fill(table2);
            cbnmadanhgia.DataSource = table2;
            cbnmadanhgia.ValueMember = "ma"; 
            SqlCommand command3 = new SqlCommand("select * from trangthietbi", Cns);
            SqlDataAdapter data3 = new SqlDataAdapter(command3);
            DataTable table3 = new DataTable();
            data3.Fill(table3);
            foreach (DataRow dtr in table3.Rows)
            {
                cbnmathietbi.Items.Add(dtr["ma"]);
            }
        }
       
    }
}
