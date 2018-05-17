using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectQLPhongMay.uc
{
    public partial class ucDieuChuyen_SL : UserControl
    {
        private SqlConnection strconnect;
        public ucDieuChuyen_SL(SqlConnection strconnect)
        {
            InitializeComponent();
            this.strconnect = strconnect;
        }

        private void ucDieuChuyen_SL_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < gridView1.Columns.Count + 1; i++)
                    excel.Cells[1, i] = gridView1.Columns[i - 1].GetTextCaption();
                for (int i = 1; i < gridView1.Columns.Count + 1; i++)
                    for (int j = 1; j < gridView1.RowCount; j++)
                        excel.Cells[j + 1, i] = gridView1.GetRowCellValue(j - 1, gridView1.Columns[i - 1]).ToString();
                excel.ActiveWorkbook.SaveCopyAs("D:\\Danhsachsoluongdieuchuyentb.xlsx");
                excel.ActiveWorkbook.Saved = true;
                MessageBox.Show("Bạn đã xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongke_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlCommand command = new SqlCommand("SP_THONGKESOLUONG_MAYDC", strconnect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@time1", dateTime1.Value));
            command.Parameters.Add(new SqlParameter("@time2", dateTime2.Value));
            SqlDataAdapter da_thongkesoluong_maydc = new SqlDataAdapter(command);
            DataTable dt_thongkesoluong_maydc = new DataTable();
            da_thongkesoluong_maydc.Fill(dt_thongkesoluong_maydc);

            gridCDieuchuyenSl.DataSource = dt_thongkesoluong_maydc;
        }
    }
}
