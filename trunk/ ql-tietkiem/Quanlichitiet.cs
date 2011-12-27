using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data.Business;
using System.Data.SqlClient;


namespace TIETKIEM
{
    public partial class FmQuanly : DevExpress.XtraEditors.XtraForm
    {
        public FmQuanly()
        {
            InitializeComponent();         

        }
        #region xử lí tab control
        /// <summary>
        /// create tab 
        /// </summary>
        void TabCreating(DevExpress.XtraTab.XtraTabControl tabControl, string Text, string Name, DevExpress.XtraEditors.XtraForm form, int imageIndex)
        {
            int index = KiemTraTonTai(tabControl, Name);
            if (index >= 0)
            {
                tabControl.SelectedTabPage = tabControl.TabPages[index];
                tabControl.SelectedTabPage.Text = Text;
            }
            else
            {
                DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage { Text = Text, Name = Name, ImageIndex = imageIndex };
                tabControl.TabPages.Add(tabpage);
                tabControl.SelectedTabPage = tabpage;

                form.TopLevel = false;
                form.Parent = tabpage;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Kiểm tra tabpage có tồn tại hay không.
        /// </summary>
        /// <param name="tabControlName">Tên tabControl để kiểm tra.</param>
        /// <param name="tabName">Tên tabpage cần kiểm tra.</param>
        /// <returns></returns>
        static int KiemTraTonTai(DevExpress.XtraTab.XtraTabControl tabControlName, string tabName)
        {
            int re = -1;
            for (int i = 0; i < tabControlName.TabPages.Count; i++)
            {
                if (tabControlName.TabPages[i].Name == tabName)
                {
                    re = i;
                    break;
                }
            }
            return re;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
           
                    
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            if (xtab.Name == "xtraTabPage1") return;
            if (xtab.SelectedTabPageIndex == -1) return;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i - 1;

        }

        #endregion

        #region xư lí sự kiện press button
        private void listAll_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Quanlichitiet_qltq danhsach_STK = new Quanlichitiet_qltq();
            TabCreating(xtraTabControl1, danhsach_STK.Text, danhsach_STK.Text, danhsach_STK, 8);
            danhsach_STK.listAll_LinkClicked();
        }
        private void Ds_KH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Quanlichitiet_qltq danhsach_STK = new Quanlichitiet_qltq();
            TabCreating(xtraTabControl1, Ds_KH.Caption, Ds_KH.Caption, danhsach_STK, 8);
            danhsach_STK.Ds_KH_LinkClicked();
        }
        private void ds_So_Dong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Quanlichitiet_qltq danhsach_STK1 = new Quanlichitiet_qltq();
            TabCreating(xtraTabControl1, ds_So_Dong.Caption, ds_So_Dong.Caption, danhsach_STK1, -1);
            danhsach_STK1.SoDong_LinkClicked();
        }

        private void nav_DoanhSoTrongNam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fm_Chart_BC_DSHD_Thang DoanhSoTrongNam = new fm_Chart_BC_DSHD_Thang();
            TabCreating(xtraTabControl1, "Doanh Số trong năm", "Doanh số trong năm", DoanhSoTrongNam, -1);
           // DoanhSoTrongNam.Get_Doanh_So_Trong_Nam();
        }
        private void nav_DoanhThuTrongThang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fm_Chart_Doanh_so_Trong_Thang doanhsotrongthang = new fm_Chart_Doanh_so_Trong_Thang();
            TabCreating(xtraTabControl1, " Doanh số trong tháng", "Doanh số trong tháng", doanhsotrongthang, -1);
        }
        private void nav_So_Dong_Mo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fm_Chart_Dong_Mo_So_Thang So_DongMo = new fm_Chart_Dong_Mo_So_Thang();
            TabCreating(xtraTabControl1, "Số sổ Đóng/Mở ", "Số sổ Đóng/Mở ", So_DongMo, -1);
        }
        #endregion
    }
}