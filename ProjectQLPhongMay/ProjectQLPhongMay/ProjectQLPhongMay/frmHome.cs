using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraTab;

namespace ProjectQLPhongMay
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm, ICallBack
    {
        private SqlConnection strConnect;
        private XtraTabPage xTraPhongMay;
        private XtraTabPage xtraTagPage_chitietSC;
        private XtraTabPage xtraTP_hoadonSC;
        private XtraTabPage xTap_TrangThietBi;
        private XtraTabPage xTap_Bosungttb;
        private XtraTabPage xtraTabPage_UCdieuchuyen;
        private XtraTabPage xtra_danhgiattb;
        //      private XtraTabPage xtraTabPage_UCdieuchuyen;
        private XtraTabPage xtraTabPage_BCSLThietbi;
        private XtraTabPage xtraTabPage_BCThietbi;
        private XtraTabPage xtraTabPage_BCSuachuaCt;
        private XtraTabPage xtraTabPage_BCSuachuaSL;
        private XtraTabPage xtraTabPage_BCSuaChuaCS;
        private XtraTabPage xtraTabPage_BCSuachuaSN;
        private XtraTabPage xtraTabPage_BCDanhgiaCT;
        private XtraTabPage xtraTabPage_BCDanhgiaPm;
        private XtraTabPage xtraTabPage_BCDieuchuyenCt;
        private XtraTabPage xtraTabPage_BCDieuchuyenSl;
        private XtraTabPage xtraTabPage_BCBosungpm;
        private XtraTabPage xtraTabPage_BCBosungtb;
        private XtraTabPage xtraTabPage_BCThanhly;



        private UcDanhGiaTTB uc_danhgiattb;
        private UcSuaChuaTB m_objCTSC;
        private UcHoadonSC m_objHDSC;
        private UC_TrangThietBi m_objTrangThietBi;
        private UC_Bosungtrangthietbi m_objBosungttb;
        private UcDieuChuyen ucDieuchuyen;

        public frmHome()
        {
            InitializeComponent();
            strConnect = new SqlConnection(@"Server =ADMINISTRATOR\SQLEXPRESS ; Database= QUANLYPHONGMAY3; Trusted_Connection = true");
            strConnect.Open();
            FrmDangNhap frmLogin = new FrmDangNhap(strConnect);
            frmLogin.Show();
            frmLogin.ICall = this;

        }

        private void btnPhongMay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (xTabMain.TabPages.Contains(xTraPhongMay))
            {
                xTabMain.TabPages.Remove(xTraPhongMay);
            }

            xTraPhongMay = new XtraTabPage();
            xTabMain.TabPages.Add(xTraPhongMay);
            xTraPhongMay.Text = "Danh sách Phòng máy";
            xTabMain.SelectedTabPage = xTraPhongMay;
            Uc_PhongMay ucPhongMay = new Uc_PhongMay(strConnect);
            ucPhongMay.ICall = this;
            xTraPhongMay.Controls.Add(ucPhongMay);
            ucPhongMay.Dock = DockStyle.Fill;
        }

        private void btnSuaChuaTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xtraTagPage_chitietSC))
            {
                xTabMain.TabPages.Remove(xtraTagPage_chitietSC);
            }
            xtraTagPage_chitietSC = new XtraTabPage();
            xTabMain.TabPages.Add(xtraTagPage_chitietSC);
            xtraTagPage_chitietSC.Text = "Sửa chữa trang thiết bị";
            xTabMain.SelectedTabPage = xtraTagPage_chitietSC;
            m_objCTSC = new UcSuaChuaTB(strConnect);
            m_objCTSC.ICall = this;
            xtraTagPage_chitietSC.Controls.Add(m_objCTSC);
            m_objCTSC.Dock = DockStyle.Fill;
        }

        private void btnHDSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xtraTP_hoadonSC))
            {
                xTabMain.TabPages.Remove(xtraTP_hoadonSC);
            }
            xtraTP_hoadonSC = new XtraTabPage();
            xTabMain.TabPages.Add(xtraTP_hoadonSC);
            xtraTP_hoadonSC.Text = "Hóa đơn sửa chữa";
            xTabMain.SelectedTabPage = xtraTP_hoadonSC;
            m_objHDSC = new UcHoadonSC(strConnect);
            m_objHDSC.ICall = this;
            xtraTP_hoadonSC.Controls.Add(m_objHDSC);
            m_objHDSC.Dock = DockStyle.Fill;
        }

        private void btnTrangTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xTap_TrangThietBi))
            {
                xTabMain.TabPages.Remove(xTap_TrangThietBi);
            }
            xTap_TrangThietBi = new XtraTabPage();
            xTabMain.TabPages.Add(xTap_TrangThietBi);
            xTap_TrangThietBi.Text = "Trang thiết bị";
            xTabMain.SelectedTabPage = xTap_TrangThietBi;
            m_objTrangThietBi = new UC_TrangThietBi(strConnect);
            m_objTrangThietBi.ICall = this;
            xTap_TrangThietBi.Controls.Add(m_objTrangThietBi);
            m_objTrangThietBi.Dock = DockStyle.Fill;
        }

        private void btnHDBoSung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xTap_Bosungttb))
            {
                xTabMain.TabPages.Remove(xTap_Bosungttb);
            }
            xTap_Bosungttb = new XtraTabPage();
            xTabMain.TabPages.Add(xTap_Bosungttb);
            xTap_Bosungttb.Text = "Bổ sung trang thiết bị";
            xTabMain.SelectedTabPage = xTap_Bosungttb;
            m_objBosungttb = new UC_Bosungtrangthietbi(strConnect);
            m_objBosungttb.ICall = this;
            xTap_Bosungttb.Controls.Add(m_objBosungttb);
            m_objBosungttb.Dock = DockStyle.Fill;
        }

        private void btnDieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xtraTabPage_UCdieuchuyen))
            {
                xTabMain.TabPages.Remove(xtraTabPage_UCdieuchuyen);
            }
            xtraTabPage_UCdieuchuyen = new XtraTabPage();
            xTabMain.TabPages.Add(xtraTabPage_UCdieuchuyen);
            xtraTabPage_UCdieuchuyen.Text = "Cấu hình máy tính";
            //xTabMain.Images = imageList1;
            xtraTabPage_UCdieuchuyen.ImageIndex = 0;
            xTabMain.SelectedTabPage = xtraTabPage_UCdieuchuyen;
            ucDieuchuyen = new ProjectQLPhongMay.UcDieuChuyen(strConnect);
            xtraTabPage_UCdieuchuyen.Controls.Add(ucDieuchuyen);
            ucDieuchuyen.Dock = DockStyle.Fill;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnDanhGiaTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xtra_danhgiattb))
            {
                xTabMain.TabPages.Remove(xtra_danhgiattb);
            }
            xtra_danhgiattb = new XtraTabPage();
            xTabMain.TabPages.Add(xtra_danhgiattb);
            xtra_danhgiattb.Text = "Đánh giá trang thiết bị";
            xTabMain.SelectedTabPage = xtra_danhgiattb;
            uc_danhgiattb = new UcDanhGiaTTB(strConnect);
            xtra_danhgiattb.Controls.Add(uc_danhgiattb);
            uc_danhgiattb.Dock = DockStyle.Fill;
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xTabMain.TabPages.Contains(xtraTabPage_BCSLThietbi))
            {
                xTabMain.TabPages.Remove(xtraTabPage_BCSLThietbi);
            }

            xtraTabPage_BCSLThietbi = new XtraTabPage();
            xTabMain.TabPages.Add(xtraTabPage_BCSLThietbi);
            xtraTabPage_BCSLThietbi.Text = "Danh sách tình trang số lượng TTB trong phòng máy";
            xTabMain.SelectedTabPage = xtraTabPage_BCSLThietbi;
            uc.ucTTB_SL sl = new uc.ucTTB_SL(strConnect);
            xtraTabPage_BCSLThietbi.Controls.Add(sl);
            xtraTabPage_BCSLThietbi.Dock = DockStyle.Fill;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCThietbi))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCThietbi);
                }
                xtraTabPage_BCThietbi = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCThietbi);
                xtraTabPage_BCThietbi.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCThietbi.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCThietbi;
                uc.ucTTB_Ct ct = new uc.ucTTB_Ct(strConnect);
                xtraTabPage_BCThietbi.Controls.Add(ct);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCSuachuaCt))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCSuachuaCt);
                }
                xtraTabPage_BCSuachuaCt = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCSuachuaCt);
                xtraTabPage_BCSuachuaCt.Text = "Thông tin chi tiết sửa chữa trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCSuachuaCt.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCSuachuaCt;
                uc.ucSuaChua_Ct sc = new uc.ucSuaChua_Ct(strConnect);
                xtraTabPage_BCSuachuaCt.Controls.Add(sc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCSuachuaSL))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCSuachuaSL);
                }
                xtraTabPage_BCSuachuaSL = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCSuachuaSL);
                xtraTabPage_BCSuachuaSL.Text = "Thông tin số lần sửa chữa trang thiết bị";
                //xTabMain.Images = imageList3;
                //xtraTabPage_BCSuachuaSL.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCSuachuaSL;
                uc.ucSuachua_Sl sl = new uc.ucSuachua_Sl(strConnect);
                xtraTabPage_BCSuachuaSL.Controls.Add(sl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCSuaChuaCS))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCSuaChuaCS);
                }
                xtraTabPage_BCSuaChuaCS = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCSuaChuaCS);
                xtraTabPage_BCSuaChuaCS.Text = "Thông tin chi tiết trang thiết bị chưa sửa lần nào";
                //xTabMain.Images = imageList5;
                //xtraTabPage_BCSuaChuaCS.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCSuaChuaCS;
                uc.ucSuachua_CS cs = new uc.ucSuachua_CS(strConnect);
                xtraTabPage_BCSuaChuaCS.Controls.Add(cs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCSuachuaSN))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCSuachuaSN);
                }
                xtraTabPage_BCSuachuaSN = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCSuachuaSN);
                xtraTabPage_BCSuachuaSN.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList6;
                //xtraTabPage_BCSuachuaSN.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCSuachuaSN;
                uc.ucSuachua_SN sn = new uc.ucSuachua_SN(strConnect);
                xtraTabPage_BCSuachuaSN.Controls.Add(sn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCDieuchuyenCt))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCDieuchuyenCt);
                }
                xtraTabPage_BCDieuchuyenCt = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCDieuchuyenCt);
                xtraTabPage_BCDieuchuyenCt.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDieuchuyenCt.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCDieuchuyenCt;
                uc.ucDieuChuyen_Ct dc = new uc.ucDieuChuyen_Ct(strConnect);
                xtraTabPage_BCDieuchuyenCt.Controls.Add(dc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCDieuchuyenSl))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCDieuchuyenSl);
                }
                xtraTabPage_BCDieuchuyenSl = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCDieuchuyenSl);
                xtraTabPage_BCDieuchuyenSl.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDieuchuyenSl.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCDieuchuyenSl;
                uc.ucDieuChuyen_SL sl = new uc.ucDieuChuyen_SL(strConnect);
                xtraTabPage_BCDieuchuyenSl.Controls.Add(sl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCDanhgiaCT))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCDanhgiaCT);
                }
                xtraTabPage_BCDanhgiaCT = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCDanhgiaCT);
                xtraTabPage_BCDanhgiaCT.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDanhgiaCT.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCDanhgiaCT;
                uc.ucDanhgia_Ct dg = new uc.ucDanhgia_Ct(strConnect);
                xtraTabPage_BCDanhgiaCT.Controls.Add(dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCDanhgiaPm))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCDanhgiaPm);
                }
                xtraTabPage_BCDanhgiaPm = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCDanhgiaPm);
                xtraTabPage_BCDanhgiaPm.Text = "Thông tin chi tiết trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDanhgiaPm.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCDanhgiaPm;
                uc.ucDanhgia_Pc pm = new uc.ucDanhgia_Pc(strConnect);
                xtraTabPage_BCDanhgiaPm.Controls.Add(pm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void xTabMain_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }


        private void btnTkbosungPm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCBosungpm))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCBosungpm);
                }
                xtraTabPage_BCBosungpm = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCBosungpm);
                xtraTabPage_BCBosungpm.Text = "Thông tin bổ sung trang thiết bị vào phòng máy";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDanhgiaPm.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCBosungpm;
                UserControls.uc_Bosung_Pm bspm = new UserControls.uc_Bosung_Pm(strConnect);
                xtraTabPage_BCBosungpm.Controls.Add(bspm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnTkBosungtb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCBosungtb))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCBosungtb);
                }
                xtraTabPage_BCBosungtb = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCBosungtb);
                xtraTabPage_BCBosungtb.Text = "Thông tin bổ sung trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDanhgiaPm.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCBosungtb;
                UserControls.uc_Bosung_Tb bstb = new UserControls.uc_Bosung_Tb(strConnect);
                xtraTabPage_BCBosungtb.Controls.Add(bstb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        public void ClickExit(int iOpt)
        {
            switch (iOpt)
            {
                case 0:
                    {
                        xTabMain.TabPages.Remove(xTraPhongMay);
                        break;
                    }
                case 1:
                    {
                        xTabMain.TabPages.Remove(xTap_TrangThietBi);
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        xTabMain.TabPages.Remove(xtraTabPage_UCdieuchuyen);
                        break;
                    }
                case 4:
                    {
                        xTabMain.TabPages.Remove(xtraTagPage_chitietSC);
                        break;
                    }
                case 5:
                    {
                        xTabMain.TabPages.Remove(xTap_Bosungttb);
                        break;
                    }
                case 6:
                    {
                        
                        break;
                    }
                case 7:
                    {
                        xTabMain.TabPages.Remove(xtraTP_hoadonSC);
                        break;
                    }
                case 8:
                    {
                        xTabMain.TabPages.Remove(xtraTabPage_BCBosungtb);
                        break;
                    }
                    
            }
        }


        public void loginSuccess()
        {
            this.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTabMain.TabPages.Contains(xtraTabPage_BCThanhly))
                {
                    xTabMain.TabPages.Remove(xtraTabPage_BCThanhly);
                }
                xtraTabPage_BCThanhly = new XtraTabPage();
                xTabMain.TabPages.Add(xtraTabPage_BCThanhly);
                xtraTabPage_BCThanhly.Text = "Thông tin bổ sung trang thiết bị";
                //xTabMain.Images = imageList2;
                //xtraTabPage_BCDanhgiaPm.ImageIndex = 0;
                xTabMain.SelectedTabPage = xtraTabPage_BCThanhly;
                UserControls.ucDanhgia_TL tl = new UserControls.ucDanhgia_TL(strConnect);
                xtraTabPage_BCThanhly.Controls.Add(tl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

      

    }

}