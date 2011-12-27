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
    public partial class fm_Doi_Mat_Khau : DevExpress.XtraEditors.XtraForm
    {
        public fm_Doi_Mat_Khau()
        {
            InitializeComponent();
        }

        private void btenter_Click(object sender, EventArgs e)
        {
            if (Data.Business.BACCOUNT.Kiem_tra_dang_nhap(fmLogin.user1, txt_Old_Pass.Text) == true) // kiem tra mật khẩu cũ có đúng không !
            {
                if (String.Compare(txt_New_Pass.Text.Trim(), txt_New_Pass1.Text.Trim()) == 0) // xem thử nhập mật khẩu mới 2 lần có đúng không, 0 :đúng;
                    Data.Business.BACCOUNT.Doi_Mat_Khau(fmLogin.user1, txt_New_Pass1.Text);
                else
                    MessageBox.Show(" Mật khẩu nhập lần 1 và lần 2 không trùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fmMain.ActiveForm.Activate();
                this.Close();
            }
            else
                MessageBox.Show(" Xem lại mật khẩu cũ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txt_New_Pass1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btenter_Click(null, null);
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
            fmMain.ActiveForm.Activate();
        }
    }
}