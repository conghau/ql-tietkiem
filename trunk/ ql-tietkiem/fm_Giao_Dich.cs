using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data.Business;
using DevExpress.XtraEditors.Controls;

namespace TIETKIEM
{
    public partial class fm_Giao_Dich : DevExpress.XtraEditors.XtraForm
    {
        public fm_Giao_Dich()
        {
            InitializeComponent();
            
 
        }
        public void DEFAULT()
        {
            txt_Laisuat.Text = "";
            txt_MKH.Text = "";
            txt_MLTK.Text = "";
            txt_MTK.Enabled = true; ;
            txt_SoDu.Text = "";
            txt_SoTienGui.Text = "";
            txt_TenLoaiTietKiem.Text = "";
            txt_TienLai.Text = "";
            txt_Value.Text = "";
            txtTenKH.Text = "";
            date_NgayDaoHanKeTiep.Text = "";
            // date_Ngaygui.Text = "";
            txt_Value.Enabled = true;

        }

        private void txt_MTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MKH.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ma_KH.ToString();
                txt_SoTienGui.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tong_So_Tien_Goi.ToString();
                txt_MLTK.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ma_Loai_TK.ToString();
                //date_Ngaygui.DateTime = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ngay_Mo_So;
                date_NgayDaoHanKeTiep.DateTime = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ngay_Dao_Han_Ke_Tiep;


                txt_TenLoaiTietKiem.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Ten_Loai_TK.ToString();
                txt_Laisuat.Text = Data.Business.BLOAI_TIET_KIEM.SelectByID(txt_MLTK.Text).Lai_Suat.ToString();
                txtTenKH.Text = Data.Business.BKHACH_HANG.SelectByID(txt_MKH.Text).Ten_Khach_Hang.ToString();
                if (radio_bt_GuiThemTien.Checked == true)
                {
                    MessageBox.Show(" Số tiền gửi thêm tối thiểu là : " + Data.Business.BTHAM_SO.Kiem_tra_tien_gui_them().ToString(), "Thông báo");
                    txt_SoDu.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).So_Du_Hien_Co.ToString();
                    txt_TienLai.Text = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tien_Lai_Phat_Sinh.ToString();
                }

                if (radio_bt_TatToan.Checked == true)
                {
                    if (MessageBox.Show(" Bạn có chắc chắn muốn tất toán sổ này không", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        double[] a = CONTROLLER.xac_nhan_tien_lai(txt_MTK.Text);
                        MessageBox.Show(" Tiền lãi hiện có : " + a[0].ToString() + "\n Số dư hiện có :" + a[1].ToString());
                        txt_Value.Text = txt_SoDu.Text = a[1].ToString();
                        txt_TienLai.Text = a[0].ToString();

                    }
                    else
                    {
                        DEFAULT();
                        return;
                    }
                }
                if (radio_bt_RutTien.Checked == true)
                {
                    if (MessageBox.Show(" Bạn có chắc chắn muốn rút sổ ngày không", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        double[] a = CONTROLLER.xac_nhan_tien_lai(txt_MTK.Text);
                        MessageBox.Show(" Tiền lãi hiện có : " + a[0].ToString() + "\n Số dư hiện có :" + a[1].ToString());
                        txt_SoDu.Text = a[1].ToString();
                        txt_TienLai.Text = a[0].ToString();

                    }
                    else
                    {
                        DEFAULT();
                        return;
                    }
                }

            }
            catch 
            {
                if (radio_bt_TatToan.Checked == true) MessageBox.Show("Tài khoản này chưa thể tất toán", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (radio_bt_RutTien.Checked == true) MessageBox.Show("Tài khoản này chưa thể rut", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (radio_bt_GuiThemTien.Checked == true) MessageBox.Show("Tài khoản này chưa thể gửi thêm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    
        private void txt_GuiThemTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void fm_Giao_Dich_Load(object sender, EventArgs e)
        {
            if (radio_bt_GuiThemTien.Checked == true)
            {
                txt_Ma_GD.Text = "MLGD01";
            }
           
        }
       
        public void get_GiaoDich(Data.Entities.EGIAO_DICH Insert_GiaoDich)
        {
            Insert_GiaoDich.Ma_So_GD = Data.Business.BGIAO_DICH.NextID();
            Insert_GiaoDich.Ma_TK = txt_MTK.Text;
            Insert_GiaoDich.Ma_Loai_GD = txt_Ma_GD.Text;
            Insert_GiaoDich.Ngay_GD = DateTime.Today;
            Insert_GiaoDich.So_Tien_GD = double.Parse(txt_Value.Text);
        }
        public void get_So_TK(Data.Entities.ESO_TIET_KIEM Update_STK)
        {
            double Tong_tien_gui = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tong_So_Tien_Goi ;
            double Tong_tien_lai = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tien_Lai_Phat_Sinh;
            double Tong_tien_rut = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Tong_So_Tien_Rut ;
            DateTime Ngaygui = Data.Business.BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Ngay_Mo_So;
            double So_du_hien_co;

            Update_STK.Ma_TK = txt_MTK.Text;
            Update_STK.Ma_KH = txt_MKH.Text;          
            Update_STK.Ma_Loai_TK = txt_MLTK.Text;
            Update_STK.Ngay_Mo_So = Ngaygui;
            Update_STK.Ngay_Tinh_Lai_Gan_Nhat = DateTime.Today;
            
            Update_STK.Ngay_Dao_Han_Ke_Tiep = date_NgayDaoHanKeTiep.DateTime;
            
            if(txt_Ma_GD.Text == "MLGD02")// rút tiền
            {
                Tong_tien_rut = Tong_tien_rut + double.Parse(txt_Value.Text);
                Update_STK.Tong_So_Tien_Rut = Tong_tien_rut;
                Update_STK.Tong_So_Tien_Goi = Tong_tien_gui;
                Update_STK.Tien_Lai_Phat_Sinh = double.Parse(txt_TienLai.Text);
            }
            if (txt_Ma_GD.Text == "MLGD01"||radio_bt_GuiThemTien.Checked==true) // gửi thêm tiền
            {
                Tong_tien_gui = Tong_tien_gui + double.Parse(txt_Value.Text);
                Update_STK.Tong_So_Tien_Goi = Tong_tien_gui;
                Update_STK.Tong_So_Tien_Rut = Tong_tien_rut ;
                Update_STK.Tien_Lai_Phat_Sinh = Tong_tien_lai;
            }
           So_du_hien_co = Tong_tien_gui + double.Parse(txt_TienLai.Text) - Tong_tien_rut;
           Update_STK.So_Du_Hien_Co = So_du_hien_co;
           
            if (So_du_hien_co <= 0)
           {
               Update_STK.Trang_Thai_So = true;
               Update_STK.Ngay_Dong_So = DateTime.Today.ToShortDateString();
               
           }
           else if (So_du_hien_co != 0)
           {
               Update_STK.Trang_Thai_So = false;
               Update_STK.Ngay_Dong_So = "";
           }

            
            
        }

        private void bt_HoanThanh_Click(object sender, EventArgs e)
        {
            Hoan_thanh();
        }   
        private void bt_GiaoDichKhac_Click(object sender, EventArgs e)
        {
            DEFAULT();
            bt_GiaoDichKhac.Visible = false;
            bt_HoanThanh.Visible = true;
            if (radio_bt_RutTien.Checked == true)
                load_So_Rut_tien();
            if (radio_bt_TatToan.Checked == true)
                load_So_tat_toan();
            if (radio_bt_GuiThemTien.Checked == true)
                Load_So_gui_tien();
            
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Hoan_thanh()
        {
            if (txt_Value.Text == "")
            {
                MessageBox.Show("Nhập chưa xong", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radio_bt_GuiThemTien.Checked == true)
            {
                if (double.Parse(txt_Value.Text) < BTHAM_SO.Kiem_tra_tien_gui_them())
                {
                    MessageBox.Show(" Số tiền nhỏ hơn quy định ");
                    return;
                }
            }
            if(radio_bt_RutTien.Checked==true || radio_bt_TatToan.Checked == true)          
                if (CONTROLLER.Kiem_tra_so_tien_duoc_rut(txt_MTK.Text, txt_MLTK.Text, txt_Value.Text,double.Parse(txt_SoDu.Text)) == false)
                {
                    MessageBox.Show(" Xem lại so tiền vừa nhâp");
                    return;
                }
            //else
            
                MessageBox.Show(" Bắt đầu giao dịch ");
                try
                {

                    Data.Entities.ESO_TIET_KIEM Update_STK = new TIETKIEM.Data.Entities.ESO_TIET_KIEM();
                    Data.Entities.EGIAO_DICH Insert_GiaoDich = new TIETKIEM.Data.Entities.EGIAO_DICH();
                    //MessageBox.Show(" OK");
                    get_GiaoDich(Insert_GiaoDich); //MessageBox.Show(" xong gd");
                    get_So_TK(Update_STK); //MessageBox.Show(" xong stk");
                    
                    Data.Business.BGIAO_DICH.Insert(Insert_GiaoDich);
                    Data.Business.BSO_TIET_KIEM.Update(Update_STK);
                    MessageBox.Show(" Giao dịch thành công ", "Thông báo");

                    //BBAO_CAO_DSHD_NGAY.Kiemtra_Insert_or_Update(txt_MLTK.Text, txt_Ma_GD.Text, double.Parse(txt_Value.Text));
                    BBAO_CAO_DSHD_NGAY.Kiemtra_Insert_or_Update(txt_MLTK.Text, txt_Ma_GD.Text, double.Parse(txt_Value.Text));
                    if (BSO_TIET_KIEM.SelectByID(txt_MTK.Text).Trang_Thai_So == true)// trang thai đóng sổ
                    {
                        BBAO_CAO_MO_DONG_SO_THANG.Insert_BAO_CAO_MO_DONG_SO_THANG(txt_MLTK.Text);
                        BCT_BC_MO_DONG_SO_THANG.KiemTra_Insert_Or_Update(txt_MLTK.Text, 2);
                    }

                   
                    
                    if (MessageBox.Show(" In Phiếu Gửi Tiền ", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpt_GiaoDich InPHieu = new rpt_GiaoDich();
                        InPHieu.ShowDialog();
                    }

                }
                catch { MessageBox.Show(" Lỗi ", "Thông báo"); }

                bt_GiaoDichKhac.Visible = true;
                bt_HoanThanh.Visible = false;
                txt_MTK.Enabled = false;
                txt_Value.Enabled = false;
            
        }
   
        private void radio_bt_RutTien_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_bt_RutTien.Checked == true)
            {
                txt_Ma_GD.Text = "MLGD02";
                labelControl1.Text = "RÚT TIỀN TIẾT KIỆM";
                labelControl6.Text = "Số tiền rút";
                MessageBox.Show(" RÚT TIỀN");
                load_So_Rut_tien();

            }
            //else
            //txt_Ma_GD.Text = "";
        }
        private void radio_bt_GuiThemTien_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_bt_GuiThemTien.Checked == true)
            {
                txt_Ma_GD.Text = "MLGD01";
                labelControl1.Text = "GỬI THÊM TIỀN";
                labelControl6.Text = " Số tiền gửi thêm";
                MessageBox.Show("Gửi Tiền");
                Load_So_gui_tien();


            }            
        }
        private void radio_bt_TatToan_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_bt_TatToan.Checked == true)
            {
                txt_Ma_GD.Text = "MLGD02";
                labelControl1.Text = "TẤT TOÁN SỔ";
                labelControl6.Text = " Số tiền rút";
                txt_MTK.Properties.Items.Clear();
                load_So_tat_toan();
            }          

        }

        public void load_So_tat_toan()
        {
            txt_MTK.Properties.Items.Clear();
            txt_MTK.Text = "";
            MessageBox.Show("Tat Toan So");
            int j = 0;
            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                if (bool.Parse(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Trang_Thai_So"].ToString()) == false && CONTROLLER.Kiem_tra_Quy_dinh_ngay_rut_toi_thieu(BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString()) == true)
                {

                    txt_MTK.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
                    j++;
                }
            }
            if (j == 0) { MessageBox.Show(" Chưa có sổ nào được tat toan "); txt_MTK.Text = ""; }

        }
        public void load_So_Rut_tien()
        {
            txt_MTK.Properties.Items.Clear();
            txt_MTK.Text = "";
            int j = 0;
            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.SelectAll().Rows.Count; i++)
            {
                if (bool.Parse(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Trang_Thai_So"].ToString()) == false && BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_Loai_TK"].ToString() == "MLTK01" && CONTROLLER.Kiem_tra_Quy_dinh_ngay_rut_toi_thieu(BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString()) == true)
                {

                    txt_MTK.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
                    j++;
                }
            }
            if (j == 0) { MessageBox.Show(" Chưa có sổ nào được rút"); txt_MTK.Text = ""; }
        }
        public void Load_So_gui_tien()
        {
            txt_MTK.Properties.Items.Clear();
            txt_MTK.Text = "";           
            int j = 0;
            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.SelectAll().Rows.Count; i++)

                if (bool.Parse(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Trang_Thai_So"].ToString()) == false && CONTROLLER.KiemTra_GuiThemTien(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString()))
                {

                    txt_MTK.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
                    j++;
                }
            if (j == 0) { MessageBox.Show(" Chưa có sổ nào được gửi thêm");  }

        }

    }
}