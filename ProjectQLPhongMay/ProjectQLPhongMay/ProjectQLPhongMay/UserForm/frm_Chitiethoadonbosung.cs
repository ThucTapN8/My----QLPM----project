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
    public partial class frm_Chitiethoadonbosung : Form
    {
        SqlConnection strConnect;
        string a;
        public frm_Chitiethoadonbosung(SqlConnection strConnect, string a)
        {
            InitializeComponent();
            this.strConnect = strConnect;
            this.a = a;
        }

        private List<Chitietcauhinh> danhsachcauhinh()
        {
            string str_command = "select * from chitietcauhinh";
            SqlDataAdapter da_ctch = new SqlDataAdapter(str_command, strConnect);
            DataTable dt_ctch = new DataTable();
            da_ctch.Fill(dt_ctch);

            DataRowCollection ds = dt_ctch.Rows;
            object[] obj;

            List<Chitietcauhinh> list = new List<Chitietcauhinh>();
            Chitietcauhinh obj_ctch;

            for (int i = 0; i < ds.Count; i++)
            {
                obj = ds[i].ItemArray;
                obj_ctch = new Chitietcauhinh();
                obj_ctch.ma = int.Parse(obj[0].ToString());
                obj_ctch.vixuly = obj[1].ToString();
                obj_ctch.ram = obj[2].ToString();
                obj_ctch.diacung = obj[3].ToString();
                obj_ctch.manhinh = obj[4].ToString();
                obj_ctch.mota = obj[5].ToString();
                list.Add(obj_ctch);
            }
            return list;
        }

        private void btn_themchitiethd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thêm chi tiết hóa đơn bổ sung không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Chitietcauhinh obj_chitietcauhinh = new Chitietcauhinh();
                    if (txt_motatb.Text == "")
                    {
                        obj_chitietcauhinh.vixuly = float.Parse(txt_vixuly.Text).ToString() + " GHz";
                        obj_chitietcauhinh.ram = int.Parse(txt_ram.Text).ToString() + "GB";
                        obj_chitietcauhinh.manhinh = txt_manhinh.Text;
                        obj_chitietcauhinh.diacung = int.Parse(txt_diacung.Text).ToString() + "GB";
                        //obj_chitietcauhinh.mota = txt_motatb.Text;

                        List<Chitietcauhinh> list = danhsachcauhinh();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (obj_chitietcauhinh.Kiemtra(list[i]))
                            {
                                obj_chitietcauhinh.ma = list[i].ma;
                                break;
                            }
                            else
                            {
                                if (i == list.Count - 1)
                                {
                                    obj_chitietcauhinh.ma = list.Count + 1;
                                    SqlCommand str_command = new SqlCommand(@"insert into chitietcauhinh(ma, vixuly, ram, diacung, manhinh) values (@ma, @vixuly, @ram, @diacung, @manhinh)", strConnect);

                                    str_command.Parameters.Add(new SqlParameter("@ma", obj_chitietcauhinh.ma));
                                    str_command.Parameters.Add(new SqlParameter("@vixuly", obj_chitietcauhinh.vixuly));
                                    str_command.Parameters.Add(new SqlParameter("@ram", obj_chitietcauhinh.ram));
                                    str_command.Parameters.Add(new SqlParameter("@diacung", obj_chitietcauhinh.diacung));
                                    str_command.Parameters.Add(new SqlParameter("@manhinh", obj_chitietcauhinh.manhinh));
                                    //str_comand.Parameters.Add(new SqlParameter("@mota", obj_chitietcauhinh.mota));

                                    str_command.ExecuteNonQuery();

                                }
                            }
                        }
                    }
                    else
                    {
                        obj_chitietcauhinh.mota = txt_motatb.Text;

                        SqlCommand str_command = new SqlCommand(@"insert into chitietcauhinh(ma, mota) values (@ma, @mota)", strConnect);
                        str_command.Parameters.Add(new SqlParameter("@ma", obj_chitietcauhinh.ma));
                        str_command.Parameters.Add(new SqlParameter("@mota", obj_chitietcauhinh.mota));

                        str_command.ExecuteNonQuery();

                    }
                   
                    SqlCommand command = new SqlCommand("SP_INSERT_chitiethoadonbosung", strConnect);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ma", txt_sohieutb.Text));
                    command.Parameters.Add(new SqlParameter("@ten", txt_tentb.Text));
                    command.Parameters.Add(new SqlParameter("@dongia", txt_dongia.Text));
                    command.Parameters.Add(new SqlParameter("@cauhinhma", obj_chitietcauhinh.ma));
                    command.Parameters.Add(new SqlParameter("@hoadonma", a));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm chi tiết hóa đơn bổ sung thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_quaylai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
