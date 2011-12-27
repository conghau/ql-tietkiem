using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using System.Configuration;
using TIETKIEM.Data.Connection;
using TIETKIEM.Data.Business;


namespace TIETKIEM
{
    public partial class fmLogin : DevExpress.XtraEditors.XtraForm

    {
        public fmLogin()
        {
            InitializeComponent();

        }
        public static string user1 = "";
        public static string pass1 = "";
      
        private void fmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.Text);
                con.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối tới dữ liệu, xem lại kết nối !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btenter_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TaiKhoan.Focus();
            }
            else if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
            }
            else
            {
                user1 = txt_TaiKhoan.Text;
                pass1 = txt_MatKhau.Text;
                if (Data.Business.BACCOUNT.Kiem_tra_dang_nhap(txt_TaiKhoan.Text,txt_MatKhau.Text) == true)
                {
                    user1 = txt_TaiKhoan.Text;
                    MessageBox.Show("Xin chào !  " + txt_TaiKhoan.Text, "Đăng Nhập Thành Công !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    
                    //Data.Business.BACCOUNT.Show_Fm_Main();
                    fmMain fm = new fmMain();
                    fm.ShowDialog();
                    this.Close();
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }
                txt_TaiKhoan.Focus();
                txt_MatKhau.Focus();
            }

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy đăng nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            btenter_Click(null, null);
        }

       
    }
}