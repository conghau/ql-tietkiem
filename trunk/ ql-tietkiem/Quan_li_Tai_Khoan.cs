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
    public partial class Quan_li_Tai_Khoan : DevExpress.XtraEditors.XtraForm
    {
        public Quan_li_Tai_Khoan()
        {
            InitializeComponent();
            gridView1.GridControl.DataSource = Data.Business.BACCOUNT.table_ACC_pHANqUYEN();
            default_button();
        }

        private void checkEdit_ThemTK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit_ThemTK.Checked == true)
            {
                checkEdit_XoaTK.Checked = false;
                cb_TenTK.Enabled = true;
                cb_Ma_quyen.Enabled = true;
                txt_MatKhau.Enabled = true;
                txt_TenQuyen.Enabled = true;
                //simpleButton1.Text = " Thêm tài khoản";
                txt_MatKhau.Properties.UseSystemPasswordChar = false;

                Load_Ma_Quyen();
                
            }
            else
            {
                this.cb_TenTK.SelectedIndexChanged -= new System.EventHandler(this.cb_TenTK_SelectedIndexChanged);
                this.cb_Ma_quyen.SelectedIndexChanged -= new System.EventHandler(this.cb_Ma_quyen_SelectedIndexChanged);
                cb_TenTK.Properties.Items.Clear();
                //simpleButton1.Text = " Hoàn thành";
                txt_MatKhau.Properties.UseSystemPasswordChar = true;
                default_button();
            }
        }

        private void checkEdit_XoaTK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit_XoaTK.Checked == true)
            {
                checkEdit_ThemTK.Checked = false;
                cb_TenTK.Enabled = true;
                Load_ACC();
                
            }
            else
            {
                this.cb_Ma_quyen.SelectedIndexChanged -= new System.EventHandler(this.cb_Ma_quyen_SelectedIndexChanged);
                this.cb_TenTK.SelectedIndexChanged -= new System.EventHandler(this.cb_TenTK_SelectedIndexChanged);
                cb_TenTK.Enabled = false;
                cb_Ma_quyen.Properties.Items.Clear();
                default_button();
            }
        }

        private void default_button()
        {
            cb_Ma_quyen.Enabled = false;
            cb_Ma_quyen.Text = "";
            cb_TenTK.Enabled = false;
            cb_TenTK.Text = "";
            txt_MatKhau.Enabled = false;
            txt_MatKhau.Text = "";
            txt_TenQuyen.Enabled = false;
            txt_TenQuyen.Text = "";
        }
        private void Load_Ma_Quyen() // de them acc
       {
           // Khoa chuc nang selectIndexChanged o cb_TenTK de them TK moi
           this.cb_TenTK.SelectedIndexChanged -= new System.EventHandler(this.cb_TenTK_SelectedIndexChanged);
           cb_TenTK.Properties.Items.Clear();

           for (int i = 0; i < Data.Business.BPHAN_QUYEN.ListAll().Count; i++)
           {
               cb_Ma_quyen.Properties.Items.Add(Data.Business.BPHAN_QUYEN.SelectAll().Rows[i]["Ma_Quyen"].ToString());
           }
           this.cb_Ma_quyen.SelectedIndexChanged += new System.EventHandler(this.cb_Ma_quyen_SelectedIndexChanged);
       }
        private void Load_ACC() // de xoa acc
        {
            
           // Khoa chuc nang select indexChange o cb_Ma_Quyen
           this.cb_Ma_quyen.SelectedIndexChanged -= new System.EventHandler(this.cb_Ma_quyen_SelectedIndexChanged);
           cb_TenTK.Properties.Items.Clear();

           for (int i = 0; i < Data.Business.BACCOUNT.ListAll().Count; i++)
            {
               //Load cac account khong phai la Adminitrator len combobox de chuan bi xoa !
                if (Data.Business.BACCOUNT.SelectAll().Rows[i]["Ma_Quyen"].ToString().Trim()!="MQ01")
                    cb_TenTK.Properties.Items.Add(Data.Business.BACCOUNT.SelectAll().Rows[i]["Account"].ToString());
            }

            this.cb_TenTK.SelectedIndexChanged += new System.EventHandler(this.cb_TenTK_SelectedIndexChanged);

        }

        private void cb_TenTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cb_Ma_quyen.Text = Data.Business.BACCOUNT.SelectByID(cb_TenTK.Text).Ma_Quyen.ToString();
            txt_MatKhau.Text = Data.Business.BACCOUNT.SelectByID(cb_TenTK.Text).Pass.ToString();
            txt_TenQuyen.Text = Data.Business.BPHAN_QUYEN.SelectByID(cb_Ma_quyen.Text).Ten_Quyen.ToString();
        }
        private void cb_Ma_quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TenQuyen.Text = Data.Business.BPHAN_QUYEN.SelectByID(cb_Ma_quyen.Text).Ten_Quyen.ToString();
        }

        private void Xoa_TK()
        {
            try
            {
                Data.Business.BACCOUNT.Delete(cb_TenTK.Text);
                MessageBox.Show(" Đã xóa thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch { MessageBox.Show("Không thể xóa "); }
        }
        private void Insert_TK()
        {
            Data.Entities.EACCOUNT Insert_Account = new TIETKIEM.Data.Entities.EACCOUNT();
            
            Insert_Account.Account = cb_TenTK.Text;
            Insert_Account.Pass = Data.Business.CONTROLLER.MaHoaMD5(txt_MatKhau.Text);
            Insert_Account.Ma_Quyen = cb_Ma_quyen.Text;
            try
            {
                Data.Business.BACCOUNT.Insert(Insert_Account);
                MessageBox.Show(" Đã thêm thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Lỗi , Không thêm được ");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkEdit_ThemTK.Checked == true)
            {
                Insert_TK();
                gridView1.GridControl.DataSource = Data.Business.BACCOUNT.table_ACC_pHANqUYEN();
                checkEdit_ThemTK.Checked = false;
            }
            if (checkEdit_XoaTK.Checked == true)
            {
                Xoa_TK();
                gridView1.GridControl.DataSource = Data.Business.BACCOUNT.table_ACC_pHANqUYEN();
                checkEdit_XoaTK.Checked = false;
            }
            default_button();
            
        }

    }
}