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
    public partial class fmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public fmQuyDinh()
        {
            InitializeComponent();
            gridView1.GridControl.Hide();
            gridView2.GridControl.Hide();
            QuyDinh_split1.Panel2.Visible = false;
            txt_GuiToiThieu.Text = Data.Business.BTHAM_SO.SelectByID("So_tien_gui_toi_thieu").Gia_Tri.ToString();
            txt_GuiThemToiThieu.Text = Data.Business.BTHAM_SO.SelectByID("So_tien_gui_them_toi_thieu").Gia_Tri.ToString();

        }

        #region//--------------------------------- panel 1 : Thêm/sửa số tiền gửi  ----------------------------------------//

        private void sotienguitoithieu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QuyDinh_split1.Panel2.Visible = true;
            gridView2.GridControl.Hide();
            gridView1.GridControl.Show();
            gridView1.GridControl.Dock = DockStyle.Fill;
            quydinh_split3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            gridView1.GridControl.DataSource = Data.Business.BTHAM_SO.ListAll();

            
           
        }
    
        void Default()
        {
            checkEdit_Gui.Checked = false;
            checkEdit_GuiThem.Checked = false;
            txt_GuiToiThieu.Enabled = false;
            txt_GuiThemToiThieu.Enabled = false;
            bt_Xong.Visible = false ;
        }
      
        private void bt_Xong_Click(object sender, EventArgs e)
        {
            Default();
            Data.Entities.ETHAM_SO Update_TS = new TIETKIEM.Data.Entities.ETHAM_SO();
            //if (checkEdit1.Checked == true)
            {
                Update_TS.Ten_Tham_So = "So_tien_gui_toi_thieu";
                Update_TS.Gia_Tri = double.Parse(txt_GuiToiThieu.Text);
                Data.Business.BTHAM_SO.Update(Update_TS);
            }
            //if (checkEdit2.Checked == true)
            {
                Update_TS.Ten_Tham_So = "So_tien_gui_them_toi_thieu";
                Update_TS.Gia_Tri = double.Parse(txt_GuiThemToiThieu.Text);
                Data.Business.BTHAM_SO.Update(Update_TS);
            }
            Data.Business.BTHAM_SO.Update(Update_TS);
            gridView1.GridControl.DataSource = Data.Business.BTHAM_SO.SelectAll();
            //txt_GuiToiThieu.Text = Data.Business.BTHAM_SO.SelectAll().Rows["So_tien_gui_toi_thieu"]["Gia_Tri"].ToString();
           // txt_GuiThemToiThieu.Text = Data.Business.BTHAM_SO.SelectAll().Rows["So_tien_gui_them_toi_thieu"]["Gia_Tri"].ToString();


        }

        private void checkEdit_Gui_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit_Gui.Checked == true)
            {              
                txt_GuiToiThieu.Enabled = true;
                bt_Xong.Visible = true;
            }
            else
            {
                txt_GuiToiThieu.Enabled = false;
                bt_Xong.Visible = false;
            }
            
        }

        private void checkEdit_GuiThem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit_GuiThem.Checked == true)
            {
                txt_GuiThemToiThieu.Enabled = true;
                bt_Xong.Visible = true;
            }
            else
            { 
                txt_GuiThemToiThieu.Enabled = false; 
                bt_Xong.Visible = false; 
            }

        }
        #endregion

        #region//--------------------------------- panel 2 : Thêm/sửa kỳ hạn ----------------------------------------//

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            QuyDinh_split1.Panel2.Visible = true;
            gridView1.GridControl.Hide();
            gridView2.GridControl.Show();
            gridView2.GridControl.Dock = DockStyle.Fill;
            quydinh_split3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            cb_MLTK.Properties.Items.Clear();
            for (int i = 0; i < Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                cb_MLTK.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ma_Loai_TK"].ToString());
                //cb_diengiai.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ten_Loai_TK"].ToString());

            }
            gridView2.GridControl.DataSource = Data.Business.BLOAI_TIET_KIEM.SelectAll();
            //showdata_gridView_cell();
        }

        private void cb_MLKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Laisuat.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).Lai_Suat.ToString();
            txt_Tenkihan.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).Ten_Loai_TK.ToString();
            txt_KiHan.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).Ky_Han.ToString();
            txt_thoigiantoithieu.Text =Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).So_Ngay_Goi_Toi_Thieu.ToString();
            cb_QD_Gioi_Han.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).QD_So_Tien_Duoc_Rut.ToString();
        }

        void DEFAULT() 
        {
            bt_Hoanthanh.Visible = false;
            bt_Back.Visible = false;
            bt_capnhat.Visible = false;
            bt_them.Visible = true;
            bt_Sua.Visible = true;

            cb_MLTK.Enabled = true;
            cb_QD_Gioi_Han.Enabled = false;
            txt_Tenkihan.Enabled = false;
            txt_thoigiantoithieu.Enabled = false;
            txt_Laisuat.Enabled = false;
            txt_KiHan.Enabled = false;

           
            
        }

///////////////////////////////////////////////////////////////////////

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_capnhat.Visible =true;
            bt_Back.Visible = true;
            bt_them.Visible = false;
            bt_Sua.Visible = false;
                  
            txt_thoigiantoithieu.Enabled = true;
            txt_Laisuat.Enabled = true;
            this.cb_MLTK.SelectedIndexChanged += new System.EventHandler(this.cb_MLKH_SelectedIndexChanged);
            
        }
        
        private void bt_capnhat_Click(object sender, EventArgs e)
        {

            Data.Entities.ELOAI_TIET_KIEM update_ = new TIETKIEM.Data.Entities.ELOAI_TIET_KIEM();
            update_.Ky_Han = Int32.Parse(txt_KiHan.Text);
            update_.Ma_Loai_TK = cb_MLTK.Text;
            update_.Ten_Loai_TK = txt_Tenkihan.Text;
            update_.QD_So_Tien_Duoc_Rut = Data.Business.BLOAI_TIET_KIEM.SelectByID(cb_MLTK.Text).QD_So_Tien_Duoc_Rut.ToString();
            update_.Lai_Suat = double.Parse(txt_Laisuat.Text);
            update_.So_Ngay_Goi_Toi_Thieu = Int32.Parse(txt_thoigiantoithieu.Text);
            Data.Business.BLOAI_TIET_KIEM.Update(update_);
            MessageBox.Show("Cập nhật thành công","Thông Báo", MessageBoxButtons.OK);

            gridView2.GridControl.DataSource = Data.Business.BLOAI_TIET_KIEM.SelectAll();

        }
///////////////////////////////////////////////////////////////////////
        private void bt_Hoanthanh_Click(object sender, EventArgs e)
        {
            Data.Entities.ELOAI_TIET_KIEM Insert_KiHan = new TIETKIEM.Data.Entities.ELOAI_TIET_KIEM();
            Insert_KiHan.Ma_Loai_TK = cb_MLTK.Text;
            Insert_KiHan.Ten_Loai_TK = txt_Tenkihan.Text;
            Insert_KiHan.Lai_Suat = double.Parse(txt_Laisuat.Text);
            Insert_KiHan.So_Ngay_Goi_Toi_Thieu = Int32.Parse(txt_thoigiantoithieu.Text);
            Insert_KiHan.Ky_Han = Int32.Parse(txt_KiHan.Text);
            Insert_KiHan.QD_So_Tien_Duoc_Rut = cb_QD_Gioi_Han.Text;
            Data.Business.BLOAI_TIET_KIEM.Insert(Insert_KiHan);
            cb_MLTK.Properties.Items.Clear();
            for (int i = 0; i < Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                cb_MLTK.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ma_Loai_TK"].ToString());
                //cb_diengiai.Properties.Items.Add(Data.Business.BLOAI_TIET_KIEM.SelectAll().Rows[i]["Ten_Loai_TK"].ToString());

            }
            gridView2.GridControl.DataSource = Data.Business.BLOAI_TIET_KIEM.SelectAll();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            this.cb_MLTK.SelectedIndexChanged -= new System.EventHandler(this.cb_MLKH_SelectedIndexChanged);
            cb_MLTK.Properties.Items.Clear();
            //cb_MLKH.Text = null;
            txt_Tenkihan.Text = null;
            txt_KiHan.Text = null;
            txt_GuiThemToiThieu.Text = null;
            txt_Laisuat.Text = null;
            txt_thoigiantoithieu.Text = null;
             
            bt_Hoanthanh.Visible = true;
            bt_them.Visible = false;
            bt_Back.Visible = true;
            bt_Sua.Visible = false;

            
            cb_MLTK.Enabled = false;
            cb_QD_Gioi_Han.Enabled = true;
            cb_QD_Gioi_Han.Visible = true;
            txt_Tenkihan.Enabled = true;
            txt_thoigiantoithieu.Enabled = true;
            txt_Laisuat.Enabled = true;
            txt_KiHan.Enabled = true;
            cb_MLTK.Text = Data.Business.BLOAI_TIET_KIEM.NextID();
        }

///////////////////////////////////////////////////////////////////////       
        private void bt_Back_Click(object sender, EventArgs e)
        {
            DEFAULT();
           this.cb_MLTK.SelectedIndexChanged += new System.EventHandler(this.cb_MLKH_SelectedIndexChanged);
            //this.gridView2_CustomRowCellEditForEditing -= new System.EventHandler(this.gridView2_CustomRowCellEditForEditing);

        }

        private void txt_Laisuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void showdata_gridView_cell()
        {
            txt_Tenkihan.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Ten_Loai_TK").ToString();
                //gridView2.GetDataRow(gridView2.FocusedRowHandle)["Ten_Loai_TK"].ToString();
        }

        private void gridView2_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            bt_Back.Visible = true;
            bt_capnhat.Visible = true;
            bt_them.Visible = false;
            bt_Sua.Visible = false;
           

            int dong = gridView2.FocusedRowHandle;
            cb_MLTK.Text = gridView2.GetDataRow(dong)["Ma_Loai_TK"].ToString();
            txt_Tenkihan.Text = gridView2.GetDataRow(dong)["Ten_Loai_TK"].ToString();
            txt_Laisuat.Text = gridView2.GetDataRow(dong)["Lai_Suat"].ToString();
            txt_thoigiantoithieu.Text = gridView2.GetDataRow(dong)["So_Ngay_Goi_Toi_Thieu"].ToString();
            txt_KiHan.Text = gridView2.GetDataRow(dong)["Ky_Han"].ToString();
            
           
        }

        #endregion
                      
    }
}