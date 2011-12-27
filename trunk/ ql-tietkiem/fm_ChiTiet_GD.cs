using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data.DataAccess;
using System.Data.SqlClient;
using TIETKIEM.report;

namespace TIETKIEM
{
    public partial class fm_ChiTiet_GD : DevExpress.XtraEditors.XtraForm
    {
        public fm_ChiTiet_GD()
        {
            InitializeComponent();
        }

        public static string MLGD = "";

        private void xuli()
        {
            if (Data.Business.BGIAO_DICH.row_In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD) ==0)
             {MessageBox.Show(" Không tìm thấy","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error); return;}
            if (Data.Business.BGIAO_DICH.row_In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD)>1)
            {
                for (int i = 0; i < Data.Business.BGIAO_DICH.row_In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD); i++)
                    listBoxControl1.Items.Add(Data.Business.BGIAO_DICH.In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD).Rows[i]["Ma_So_GD"].ToString());
                listBoxControl1.Visible = true;
                label_Listbox.Visible = true;
                this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            }
            else
            {
                listBoxControl1.Visible = false;
                label_Listbox.Visible = false;
                this.listBoxControl1.SelectedIndexChanged -= new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            }
        }

        private void bt_KetQua_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBoxControl1.SelectedIndexChanged -= new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
                listBoxControl1.Items.Clear();
                xuli();
                if (Data.Business.BGIAO_DICH.row_In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD) == 0) return;
                if (Data.Business.BGIAO_DICH.row_In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD) == 1)
                {
                    Xtra_rpt_Phieu_GiaoDich xtr = new Xtra_rpt_Phieu_GiaoDich();
                    DataTable InPhieuAs = new DataTable();
                    InPhieuAs = Data.Business.BGIAO_DICH.In_Phieu_GD_As(txt_MaTK.Text, date_NgayGD.DateTime, MLGD);
                    xtr.DataSource = InPhieuAs;
                    if (InPhieuAs.Rows[0]["Ma_Loai_GD"].ToString().Trim() == "MLGD01")
                        xtr.labelTieuDe.Text = "PHIẾU THU";
                    else
                        xtr.labelTieuDe.Text = "PHIẾU CHI";
                    xtr.label_SoTienBangChu.Text = inchu(InPhieuAs.Rows[0]["So_Tien_GD"].ToString());
                    printControl1.PrintingSystem = xtr.PrintingSystem;
                    xtr.CreateDocument();
                }
            }
            catch { MessageBox.Show("Nhập đầy đủ thông tin để có thể tìm kiếm","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning); }          
        }

        private void txt_MLGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_MLGD.SelectedText == "GỬI TIỀN"||txt_MLGD.SelectedIndex==0)
            { MLGD = "MLGD01"; }
            if (txt_MLGD.SelectedText == "RÚT TIỀN")
            { MLGD = "MLGD02";}
            textEdit2.Text = MLGD;
        }

        private string inchu(string value)
        {
            Data.Business.CONTROLLER.Num2Str inchu = new TIETKIEM.Data.Business.CONTROLLER.Num2Str();
            string chu = inchu.NumberToString(value);
            return chu;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xtra_rpt_Phieu_GiaoDich xtr = new Xtra_rpt_Phieu_GiaoDich();
            DataTable InPhieuAs_MSGD = new DataTable();           
            InPhieuAs_MSGD = Data.Business.BGIAO_DICH.In_Phieu_GD_As_MSGD(listBoxControl1.Items[listBoxControl1.SelectedIndex].ToString());
            xtr.DataSource = InPhieuAs_MSGD;
            if(textEdit2.Text.Trim()== "MLGD01")
                xtr.labelTieuDe.Text = "PHIẾU THU";
            else
                xtr.labelTieuDe.Text = "PHIẾU CHI";
            //xtr.label_SoTienBangChu.Text = inchu(InPhieuAs_MSGD.Rows[0]["So_Tien_GD"].ToString());
            printControl1.PrintingSystem = xtr.PrintingSystem;
            xtr.CreateDocument();
        }
    }
}