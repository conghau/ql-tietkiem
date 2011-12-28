using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data;

namespace TIETKIEM
{
    public partial class fmMoSoTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public fmMoSoTietKiem()
        {
            InitializeComponent();
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            gridView_MoSoTK.GridControl.DataSource = Data.Business.BSO_TIET_KIEM.SelectAll();
            gridView_MoSoTK.ActiveFilterString = "[Trang_Thai_So] = false ";
            txt_MaSTK.Text = Data.Business.BSO_TIET_KIEM.NextID();
            txt_Ma_KH.Text = TIETKIEM.Data.Business.BKHACH_HANG.NextID();
            date_Ngaygui.DateTime = DateTime.Today;

            for (int i = 0; i < Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                txt_MLTK.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ma_Loai_TK"].ToString());

                //cb_diengiai.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ten_Loai_TK"].ToString());                
            }
            txt_MSGD.Text = Data.Business.BGIAO_DICH.NextID();          
        }
       

        #region Get_Data
        public void get_data_KhachHang(Data.Entities.EKHACH_HANG Insert_KH)
        {

            try
            {
                Insert_KH.Ma_KH = txt_Ma_KH.Text;
                Insert_KH.Ten_Khach_Hang = txt_TenKH.Text;
                Insert_KH.So_CMND = txt_CMND.Text;
                Insert_KH.So_Dien_Thoai = txt_SDT.Text;
                Insert_KH.Dia_Chi = txt_DiaChi.Text;
            }
            catch{}
        }
        public void get_data_SoTietKiem(Data.Entities.ESO_TIET_KIEM Insert_SoTietKiem)
        {

            try
            {
                Insert_SoTietKiem.Ma_TK = txt_MaSTK.Text;
                Insert_SoTietKiem.Ma_KH = txt_Ma_KH.Text;
                Insert_SoTietKiem.Ngay_Mo_So = Convert.ToDateTime(date_Ngaygui.DateTime);
                Insert_SoTietKiem.Ma_Loai_TK = txt_MLTK.Text;
                Insert_SoTietKiem.So_Du_Hien_Co = double.Parse(txt_SoTienGui.Text);
                Insert_SoTietKiem.Tong_So_Tien_Goi = double.Parse(txt_SoTienGui.Text);
                Insert_SoTietKiem.Tien_Lai_Phat_Sinh = 0;
                Insert_SoTietKiem.Tong_So_Tien_Rut = 0;
                Insert_SoTietKiem.Ngay_Tinh_Lai_Gan_Nhat = Convert.ToDateTime(date_Ngaygui.DateTime);
                Insert_SoTietKiem.Ngay_Dao_Han_Ke_Tiep = Convert.ToDateTime(date_Ngaygui.DateTime.AddDays((Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Ky_Han*30)));
                Insert_SoTietKiem.Ngay_Dong_So = "" ;
                Insert_SoTietKiem.Trang_Thai_So = false;
            }
            catch { }
        }
        public void get_data_GiaoDich(Data.Entities.EGIAO_DICH Insert_GiaoDich)
        {
            Insert_GiaoDich.Ma_Loai_GD = "MLGD01";
            Insert_GiaoDich.Ma_So_GD = Data.Business.BGIAO_DICH.NextID();
            Insert_GiaoDich.Ma_TK = txt_MaSTK.Text;
            Insert_GiaoDich.Ngay_GD = Convert.ToDateTime(date_Ngaygui.DateTime);
            Insert_GiaoDich.So_Tien_GD = double.Parse(txt_SoTienGui.Text);

        }
#endregion

        #region Xu ly su kien textbox
        private void txt_MLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
          cb_diengiai.Enabled = false;
          txt_Laisuat.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Lai_Suat.ToString();
          cb_diengiai.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Ten_Loai_TK.ToString();
                 
        }
        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            txt_TenKH.Text = txtTenKH.Text;
        }
        private void txt_SoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region xu li su kien GridView
        private void gridView_MoSoTK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            txt_TenKH.Enabled = false;
            txt_CMND.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            txtTenKH.Enabled = false;
            txt_MLTK.Enabled = false;
            txt_SoTienGui.Enabled = false;
            bt_Hoanthanh.Visible = false;
            bt_Next.Visible = false;
            bt_Huy.Visible = false;
            btExit.Visible = false;
            date_Ngaygui.Enabled = false;



            int dong = gridView_MoSoTK.FocusedRowHandle;
            if (e.RowHandle +1 == gridView_MoSoTK.RowCount)
            {
                bt_sua.Visible = true;
                bt_Update.Visible = true;
            }
            else
            {
                bt_sua.Visible = false;
                bt_Update.Visible = false;
            }
            txt_MaSTK.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_TK"].ToString();
            txt_Ma_KH.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_KH"].ToString();
            txt_MLTK.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_Loai_TK"].ToString();
            txt_SoTienGui.Text = gridView_MoSoTK.GetDataRow(dong)["Tong_So_Tien_Goi"].ToString();
            txtTenKH.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).Ten_Khach_Hang;
            txt_CMND.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).So_CMND;
            txt_DiaChi.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).Dia_Chi;
            txt_SDT.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).So_Dien_Thoai;
            
        }
        private void gridView_MoSoTK_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txt_TenKH.Enabled = false;
            txt_CMND.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            txtTenKH.Enabled = false;
            txt_MLTK.Enabled = false;
            txt_SoTienGui.Enabled = false;
            bt_Hoanthanh.Visible = false;
            bt_Next.Visible = false;
            bt_Huy.Visible = false;
            btExit.Visible = false;
            date_Ngaygui.Enabled = false;
            bt_sua.Visible = true;
            bt_Update.Visible = true;

            int dong = gridView_MoSoTK.FocusedRowHandle;
            txt_MaSTK.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_TK"].ToString();
            txt_Ma_KH.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_KH"].ToString();
            txt_MLTK.Text = gridView_MoSoTK.GetDataRow(dong)["Ma_Loai_TK"].ToString();
            txt_SoTienGui.Text = gridView_MoSoTK.GetDataRow(dong)["Tong_So_Tien_Goi"].ToString();
            txtTenKH.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).Ten_Khach_Hang;
            txt_CMND.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).So_CMND;
            txt_DiaChi.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).Dia_Chi;
            txt_SDT.Text = Data.Business.BKHACH_HANG.SelectByID(txt_Ma_KH.Text).So_Dien_Thoai;
        }
        #endregion

        #region Xu li Button
        private void bt_Hoanthanh_Click(object sender, EventArgs e)
        {
            if (txt_CMND.Text == "" || txt_DiaChi.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Data.Entities.EKHACH_HANG Insert_KH = new TIETKIEM.Data.Entities.EKHACH_HANG();
                    Data.Entities.ESO_TIET_KIEM Insert_SoTietKiem = new TIETKIEM.Data.Entities.ESO_TIET_KIEM();
                    Data.Entities.EGIAO_DICH Insert_GiaoDich = new TIETKIEM.Data.Entities.EGIAO_DICH();
                    this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;

                    get_data_KhachHang(Insert_KH);
                    get_data_GiaoDich(Insert_GiaoDich);
                    get_data_SoTietKiem(Insert_SoTietKiem);


                    Data.Business.BKHACH_HANG.Insert(Insert_KH);
                    Data.Business.BSO_TIET_KIEM.Insert(Insert_SoTietKiem);
                    Data.Business.BGIAO_DICH.Insert(Insert_GiaoDich);
                    gridView_MoSoTK.GridControl.DataSource = Data.Business.BSO_TIET_KIEM.SelectAll();//SelectByID(txt_MaSTK.Text);*/
                    gridView_MoSoTK.ActiveFilterString = "[Trang_Thai_So] = false ";

                    Data.Business.BBAO_CAO_DSHD_NGAY.Kiemtra_Insert_or_Update(txt_MLTK.Text, txt_MLGD.Text, double.Parse(txt_SoTienGui.Text));

                    Data.Business.BBAO_CAO_MO_DONG_SO_THANG.Insert_BAO_CAO_MO_DONG_SO_THANG(txt_MLTK.Text);

                    Data.Business.BCT_BC_MO_DONG_SO_THANG.KiemTra_Insert_Or_Update(txt_MLTK.Text, 1);

                    MessageBox.Show("Đã thêm thành công !", "Thông Báo", MessageBoxButtons.OK);
                    this.gridView_MoSoTK.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_MoSoTK_RowClick);


                    if (MessageBox.Show(" In Phiếu Gửi Tiền ", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpt_GiaoDich InPHieu = new rpt_GiaoDich();
                        InPHieu.ShowDialog();
                    }


                    

                    bt_back.Visible = false;
                    bt_Hoanthanh.Visible = false;
                    bt_Next.Visible = false;
                    bt_Huy.Visible = false;
                    bt_ThemSoMoi.Visible = true;

                    txt_TenKH.Enabled = false; ;
                    txt_CMND.Enabled = false; ;
                    txt_DiaChi.Enabled = false; ;
                    txt_SDT.Enabled = false; ;
                    txtTenKH.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private void bt_Next_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTenKH.Text == "" || txt_SoTienGui.Text == "" || txt_MLTK.Text == "")
                {

                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
                }
                else
                {
                    if (double.Parse(txt_SoTienGui.Text) < Data.Business.BTHAM_SO.check_Tiengui())
                        MessageBox.Show("Số tiền nhỏ hơn quy đinh !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        txt_TenKH.Text = txtTenKH.Text;
                        this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                    }
                }
            }
            catch
            {
                MessageBox.Show(" Nhap chua xong ");
            }


        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            txt_TenKH.Enabled = true;
            txt_CMND.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txtTenKH.Enabled = true;
            //txt_MLTK.Enabled = true;
            //txt_SoTienGui.Enabled = true;
            
           
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {

            Data.Entities.EKHACH_HANG Insert_KH = new TIETKIEM.Data.Entities.EKHACH_HANG();
            get_data_KhachHang(Insert_KH);
            Data.Business.BKHACH_HANG.Update(Insert_KH);

            //Data.Entities.ESO_TIET_KIEM Insert_SoTietKiem = new TIETKIEM.Data.Entities.ESO_TIET_KIEM();
           // get_data_SoTietKiem(Insert_SoTietKiem);
          //  Data.Business.BSO_TIET_KIEM.Update(Insert_SoTietKiem);

            gridView_MoSoTK.GridControl.DataSource = Data.Business.BSO_TIET_KIEM.SelectAll();//SelectByID(txt_MaSTK.Text);*/
            gridView_MoSoTK.ActiveFilterString = "[Trang_Thai_So] = false ";
            MessageBox.Show("Đã sửa thành công !", "Thông Báo", MessageBoxButtons.OK);
            this.gridView_MoSoTK.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_MoSoTK_RowClick);
        }           
        private void bt_ThemSoMoi_Click(object sender, EventArgs e)
        {
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;

            txt_TenKH.Enabled = true;
            txt_CMND.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txtTenKH.Enabled = true;
            txt_MLTK.Enabled = true;
            txt_SoTienGui.Enabled = true;
            date_Ngaygui.Enabled = true;
            txt_SoTienGui.Enabled = true;

            bt_Hoanthanh.Visible = true;
            bt_Next.Visible = true;
            bt_Huy.Visible = true;
            btExit.Visible = true;
            bt_sua.Visible = false;
            bt_Update.Visible = false;
            

            txt_MaSTK.Text = Data.Business.BSO_TIET_KIEM.NextID();
            txt_Ma_KH.Text = TIETKIEM.Data.Business.BKHACH_HANG.NextID();           
            txt_SoTienGui.Text = "";
            txtTenKH.Text = "";
            txt_CMND.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";

            bt_ThemSoMoi.Visible = false;
            
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.split1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }
        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        #endregion
       
        
    }
}