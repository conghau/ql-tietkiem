using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TIETKIEM
{
    public partial class Quanlichitiet_qltq : DevExpress.XtraEditors.XtraForm
    {
        public Quanlichitiet_qltq()
        {
            InitializeComponent();
        }
        #region List sổ còn hoạt động


        void Enable_ThongTinSoTietKiem_False()
        {
            txt_MTK.Enabled = false;
            txt_MLTK.Enabled = false;
            txtTenKH.Enabled = false;
            txt_TenLoaiTietKiem.Enabled = false;
            txt_TienLai.Enabled = false;
            txt_SoTienGui.Enabled = false;
            txt_SoDu.Enabled = false;
            txt_SoTienGui.Enabled = false;
            txt_Laisuat.Enabled = false;
            txt_MKH.Enabled = false;
            date_Ngaygui.Enabled = false;
            date_NgayDaoHanKeTiep.Enabled = false;
            checkButton1.Visible = false;
        }

        private void txt_MTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MKH.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ma_KH.ToString();
            txt_SoTienGui.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tong_So_Tien_Goi.ToString();
            txt_MLTK.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ma_Loai_TK.ToString();
            date_Ngaygui.DateTime = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ngay_Mo_So;
            date_NgayDaoHanKeTiep.DateTime = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ngay_Dao_Han_Ke_Tiep;
            txt_SoDu.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).So_Du_Hien_Co.ToString();
            txt_TienLai.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tien_Lai_Phat_Sinh.ToString();

            txt_TenLoaiTietKiem.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Ten_Loai_TK.ToString();
            txt_Laisuat.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Lai_Suat.ToString();
            txtTenKH.Text = Data.Business.BKHACH_HANG.SelectByID(txt_MKH.Text).Ten_Khach_Hang.ToString();
            if (checkButton1.Checked == true)
            {
                txt_MaKH.Text = txt_MKH.Text;
                Get_KhachHang(txt_MKH.Text);
            }
            checkButton1.Visible = true;
            Data.Business.CONTROLLER.Tinh_Tien_Lai(txt_MTK.Text);
        }
      
        public void listAll_LinkClicked()
        {
            labelControl1.Text = " DANH SÁCH SỔ TIẾT KIỆM ";
            txt_MTK.Properties.Items.Clear();
            Trang_Thai_So.ClearFilter();
            Enable_ThongTinSoTietKiem_False();
            gridView2.GridControl.Hide();
            
            gridView1.GridControl.Dock = DockStyle.Fill;
            gridView1.GridControl.Show();
            split2.Visible = true;
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            

            Data.Business.CONTROLLER.Auto_Update_TienLai();
        
            gridView1.GridControl.DataSource = TIETKIEM.Data.Business.BSO_TIET_KIEM.ListAll();
            gridView1.ActiveFilterString = "[Trang_Thai_So] = false ";

            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
               if(bool.Parse(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Trang_Thai_So"].ToString()) == false)// duyet so con hoat dong
                txt_MTK.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
            }
            txt_MTK.Enabled = true;


        }
        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked == true)
            {
                Enable_KhacHang_false();
                checkButton1.Text = " << Ẩn chi tiết ";
                this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                txt_MaKH.Enabled = false;
                txt_MaKH.Text = txt_MKH.Text;
                Get_KhachHang(txt_MaKH.Text);

            }
            else
            {
                checkButton1.Text = " Hiện chi tiết >> ";
                this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int dong = gridView1.FocusedRowHandle;
            txt_MTK.SelectedIndex = dong;


        }

        #endregion

        //------------------------------------------------------------------------------//

        #region Danh sach Khach Hàng
        void Enable_KhacHang_false()
        {
            txt_MaKH.Enabled = true;
            txt_TenKH.Enabled = false;
            txt_SDT.Enabled = false;
            txtCMND.Enabled = false;
            txt_diachi.Enabled = false;

            bt_HoanThanh.Visible = false;
            bt_Huy.Visible = false;
            bt_Sua_p2.Visible = true;

        }
        void Get_KhachHang(string Ma_KH)
        {
            txt_TenKH.Text = Data.Business.BKHACH_HANG.SelectByID(Ma_KH).Ten_Khach_Hang.ToString();
            txtCMND.Text = Data.Business.BKHACH_HANG.SelectByID(Ma_KH).So_CMND.ToString();
            txt_SDT.Text = Data.Business.BKHACH_HANG.SelectByID(Ma_KH).So_Dien_Thoai.ToString();
            txt_diachi.Text = Data.Business.BKHACH_HANG.SelectByID(Ma_KH).Dia_Chi.ToString();

        }
        public void Ds_KH_LinkClicked()
        {
            gridView1.GridControl.Hide();
            
            gridView2.GridControl.Dock = DockStyle.Fill;
            gridView2.GridControl.Show();
            split2.Visible = true;
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            gridView2.GridControl.DataSource = TIETKIEM.Data.Business.BKHACH_HANG.ListAll();
            Enable_KhacHang_false();

            for (int i = 0; i < Data.Business.BKHACH_HANG.SelectAll().Rows.Count; i++)
            {
                txt_MaKH.Properties.Items.Add(Data.Business.BKHACH_HANG.SelectAll().Rows[i]["Ma_KH"].ToString());
            }
            txt_MaKH.Enabled = true;


        }


       
       
    


        private void txt_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_KhachHang(txt_MaKH.Text);
        }

        string[] ALL = new string[4];
        private void bt_Sua_p2_Click(object sender, EventArgs e)
        {
            ALL = get_temp(txt_TenKH.Text, txt_SDT.Text, txtCMND.Text, txt_diachi.Text);

            txt_TenKH.Enabled = true;
            txt_SDT.Enabled = true;
            txtCMND.Enabled = true;
            txt_diachi.Enabled = true;
            bt_Huy.Visible = true;
            bt_HoanThanh.Visible = true;
            bt_Sua_p2.Visible = false;
        }

        private string[] get_temp(string TenKH,string SDT,string CMND,string Diachi)// lưu tạm thông tin khách hàng ;
        {
            string[] All = new string[4];
            All[0] = TenKH ;
            All[1]= SDT ;
            All[2] = CMND;
            All[3]= Diachi ;
            return All;
        }
        private void set_temp(string TenKH, string SDT, string CMND, string Diachi)
        {
            txt_TenKH.Text = TenKH; ;
            txt_SDT.Text = SDT ;
            txtCMND.Text= CMND;
            txt_diachi.Text= Diachi;
        }
        private void bt_Huy_Click(object sender, EventArgs e)
        {
            //string[] all = new string[4];
            //all = ALL;
            set_temp(ALL[0], ALL[1], ALL[2], ALL[3]);
            Enable_KhacHang_false();
            
        }

        private void HoanThanh()
        {
            try
            {
                Data.Entities.EKHACH_HANG Update_KhachHang = new TIETKIEM.Data.Entities.EKHACH_HANG();
                Update_KhachHang.Ma_KH = txt_MaKH.Text;
                Update_KhachHang.Ten_Khach_Hang = txt_TenKH.Text;
                Update_KhachHang.So_Dien_Thoai = txt_SDT.Text;
                Update_KhachHang.So_CMND = txtCMND.Text;
                Update_KhachHang.Dia_Chi = txt_diachi.Text;

                Data.Business.BKHACH_HANG.Update(Update_KhachHang);
                MessageBox.Show(" Đã cập nhập thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show(" Có Lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bt_HoanThanh_Click(object sender, EventArgs e)
        {
            HoanThanh();
            gridView2.GridControl.DataSource = Data.Business.BKHACH_HANG.SelectAll();
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            int dong = gridView2.FocusedRowHandle;// xác đinh vị trí chuột 

            txt_MaKH.SelectedIndex = dong;

        }
        private void gridView2_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            int dong = gridView2.FocusedRowHandle;
            txt_MaKH.SelectedIndex = dong;

        }
        #endregion

        //------------------------------------------------------------------------------//

        #region Sổ Đóng
        public void SoDong_LinkClicked()
        {
            labelControl1.Text = " DANH SÁCH SỔ TIẾT KIỆM ĐÃ ĐÓNG";
            txt_MTK.Properties.Items.Clear();
            Trang_Thai_So.ClearFilter();
            Enable_ThongTinSoTietKiem_False();
            gridView2.GridControl.Hide();

            gridView1.GridControl.Dock = DockStyle.Fill;
            gridView1.GridControl.Show();
            split2.Visible = true;
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;


            Data.Business.CONTROLLER.Auto_Update_TienLai();

            gridView1.GridControl.DataSource = TIETKIEM.Data.Business.BSO_TIET_KIEM.ListAll();
            gridView1.ActiveFilterString ="[Trang_Thai_So] = true";

            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                if (bool.Parse(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Trang_Thai_So"].ToString()) == true)// duyet so con hoat dong
                    txt_MTK.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
            }
            txt_MTK.Enabled = true;


        }

        #endregion




    }
}