using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevComponents.DotNetBar;
//using TIETKIEM.Data.DataAccess;


namespace TIETKIEM
{
    public partial class fmMain : RibbonForm
    {
        public fmMain()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            InitializeComponent();
            InitSkinGallery();
            SkinHelper.InitSkinPopupMenu(barskin);         
            Login.Enabled = false;
            //Hien ID nguoi dung
            siStatus.Caption = "ID : "+fmLogin.user1 + " | Quyền : " + Data.Business.BPHAN_QUYEN.SelectByID(Data.Business.BACCOUNT.SelectByID(fmLogin.user1.Trim()).Ma_Quyen.ToString()).Ten_Quyen.ToString() ;
            //Bar_MucDoHoanThanh
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        
        private void PHAN_QUYEN()
        {
            string s= Data.Business.BACCOUNT.SelectByID(fmLogin.user1.Trim()).Ma_Quyen.ToString().Trim();
            if (string.Compare(s,"MQ01")==1)
            {
                this.ribbonPage_QUYDINH.Dispose();
                this.QUANLY_ribbonpage.Dispose();
                this.ribbonPage_BieuDo.Dispose();
                this.restore.Enabled = false;
                this.Backup.Enabled = false;
                System.GC.Collect();
            }
            
        }
        private void fmMain_Load(object sender, EventArgs e)
        {
            PHAN_QUYEN();
            
            Data.Business.CONTROLLER.Auto_Update_TienLai();
        }

        #region menu
        private void Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
            fmLogin.ActiveForm.Close();
            System.GC.Collect();
        }
        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            fmAbout FmA = new fmAbout();
            FmA.ShowDialog();
            System.GC.Collect();
        }
        private void Login_ItemClick(object sender, ItemClickEventArgs e)
        {
            fmLogin fmL = new fmLogin();
            fmL.ShowDialog();
            System.GC.Collect();
        }
        private void change_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.IsAccessible = false;
            fm_Doi_Mat_Khau fmC = new fm_Doi_Mat_Khau();
            fmC.ShowDialog();

        }
        private void logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            fmLogin fmL = new fmLogin();
            fmL.ShowDialog();
            //Login.Enabled = true;
        }
        private void restore_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.InitialDirectory = @"D:\";
                openfile.Filter = "Đuôi tập tin: (*.bak)|*.bak";
                openfile.AddExtension = true;
                openfile.DefaultExt = "bak";
                openfile.RestoreDirectory = true;
                openfile.Title = "Chon duong dan toi file du phong!";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        TIETKIEM.Data.DataAccess.SqlHelper.ExecuteNonQuery(CommandType.Text, "USE MASTER RESTORE DATABASE [QL_TIETKIEM] FROM DISK = N'" + openfile.FileName + "'WITH REPLACE");
                        MessageBox.Show("Database da duoc restore thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch
                    {
                        MessageBox.Show("Thất bại");
                    }
                }    
        }

        private void Backup_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"D:\";
            save.Filter = "Đuôi tập tin: (*.bak)|*.bak";
            save.AddExtension = true;
            save.DefaultExt = "bak";
            save.RestoreDirectory = true;
            save.Title = "Chon duong dan luu file du phong!";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TIETKIEM.Data.DataAccess.SqlHelper.ExecuteNonQuery(CommandType.Text, "BACKUP DATABASE [QL_TIETKIEM] TO DISK = N'" + save.FileName + "' WITH INIT");
                    MessageBox.Show("Sao lưu thành công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
        #endregion

        #region Nghiep vu
        static fmMoSoTietKiem fmNew = null;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fmNew == null || fmNew.IsDisposed)
            {
                fmNew = new fmMoSoTietKiem();
                fmNew.MdiParent = fmMain.ActiveForm;
                fmNew.Show();
            }
            else
                fmNew.Activate();
            System.GC.Collect();
        }
        
        static fm_Giao_Dich fm_GiaoDich = null;
        private void bar_bt_GiaoDich_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fm_GiaoDich == null || fm_GiaoDich.IsDisposed)
            {
               fm_GiaoDich = new fm_Giao_Dich();
               fm_GiaoDich.MdiParent = fmMain.ActiveForm;
               fm_GiaoDich.Show();
            }
            else
               fm_GiaoDich.Activate();
            System.GC.Collect();
        }
        #endregion

        #region Quan li
        static FmQuanly fmQuanli = null;
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fmQuanli == null || fmQuanli.IsDisposed)
            {
                fmQuanli = new FmQuanly();
                fmQuanli.MdiParent = fmMain.ActiveForm;
                fmQuanli.Show();
            }
            else
                fmQuanli.Activate();
            System.GC.Collect();
        }
        static Quan_li_Tai_Khoan fmQLTK = null;
        private void barbt_DS_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fmQLTK == null || fmQLTK.IsDisposed)
            {
                fmQLTK = new Quan_li_Tai_Khoan();
                fmQLTK.MdiParent = fmMain.ActiveForm;
                fmQLTK.Show();
            }
            else
                fmQLTK.Activate();
            System.GC.Collect();
        }
        #endregion            

        #region Quy dinh
        static fmQuyDinh Quydinh = null;
        private void bt_Quydinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Quydinh == null || Quydinh.IsDisposed)
            {
                Quydinh = new fmQuyDinh();
                Quydinh.MdiParent = fmMain.ActiveForm;
                Quydinh.Show();
            }
            else
                Quydinh.Activate();
        }
        #endregion

        #region ThongKe - BaoCao
        static In_DS_KhachHang xtra1 = null;
        private void bt_TheoThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtra1 == null || xtra1.IsDisposed)
            {
                xtra1 = new In_DS_KhachHang();
                xtra1.MdiParent = fmMain.ActiveForm;
                xtra1.Show();
            }
            else
                xtra1.Activate();
        }
               
        static ChiTiet_SoTK chitiet_SoTK = null;
        private void bar_bt_ChiTietSoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (chitiet_SoTK == null || chitiet_SoTK.IsDisposed)
            {
                chitiet_SoTK = new ChiTiet_SoTK();
                chitiet_SoTK.MdiParent = fmMain.ActiveForm;
                chitiet_SoTK.Show();
            }
            else
                chitiet_SoTK.Activate();
        }

        static fm_DS_all_STK DS_All_STK = null;
        private void bt_DS_All_SKT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DS_All_STK == null || DS_All_STK.IsDisposed)
            {
                DS_All_STK = new fm_DS_all_STK();
                DS_All_STK.MdiParent = fmMain.ActiveForm;
                DS_All_STK.Show();
            }
            else
                DS_All_STK.Activate();
        }

        static fm_ChiTiet_GD CT_GD = null;
        private void barbt_ChiTiet_GD_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CT_GD == null || CT_GD.IsDisposed)
            {
                CT_GD = new fm_ChiTiet_GD();
                CT_GD.MdiParent = fmMain.ActiveForm;
                CT_GD.Show();
            }
            else
                CT_GD.Activate();
        }

        fm_BC_DSHD_ngay BC_DSHD_ngay = null;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (BC_DSHD_ngay == null || BC_DSHD_ngay.IsDisposed)
            {
                BC_DSHD_ngay = new fm_BC_DSHD_ngay();
                BC_DSHD_ngay.MdiParent = fmMain.ActiveForm;
                BC_DSHD_ngay.Show();
            }
            else
                BC_DSHD_ngay.Activate();
            

        }
        
        fm_BC_DongMoSoThang BC_mo_dong_so_thang = null;
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (BC_mo_dong_so_thang == null || BC_mo_dong_so_thang.IsDisposed)
            {
                BC_mo_dong_so_thang = new fm_BC_DongMoSoThang();
                BC_mo_dong_so_thang.MdiParent = fmMain.ActiveForm;
                BC_mo_dong_so_thang.Show();
            }
            else
                BC_mo_dong_so_thang.Activate();            
        }

        fm_Chart_BC_DSHD_Thang chart = null;
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (chart == null || chart.IsDisposed)
            {
                chart = new fm_Chart_BC_DSHD_Thang();
                chart.MdiParent = fmMain.ActiveForm;
                chart.Show();
            }
            else
                chart.Activate();
        }

        fm_Chart_Dong_Mo_So_Thang chart1 = null;
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (chart1 == null || chart1.IsDisposed)
            {
                chart1 = new fm_Chart_Dong_Mo_So_Thang();
                chart1.MdiParent = fmMain.ActiveForm;
                chart1.Show();
            }
            else
                chart1.Activate();
        }

        fm_Chart_Doanh_so_Trong_Thang chart2 = null;
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (chart2 == null || chart2.IsDisposed)
            {
                chart2 = new fm_Chart_Doanh_so_Trong_Thang();
                chart2.MdiParent = fmMain.ActiveForm;
                chart2.Show();
            }
            else
                chart2.Activate();
        }

        #endregion

        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "trogiup\\Tro giup_QL_TK.chm");
        }
    }   
}