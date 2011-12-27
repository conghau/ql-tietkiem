using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.report;

namespace TIETKIEM
{
    public partial class rpt_GiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public rpt_GiaoDich()
        {
            InitializeComponent();
            InPhieuGD();
        }
        private string inchu(string value)
        {
            Data.Business.CONTROLLER.Num2Str inchu = new TIETKIEM.Data.Business.CONTROLLER.Num2Str();
            string chu = inchu.NumberToString(value);
            return chu;
        }
        public void InPhieuGD()
        {
            DataTable InPhieu = new DataTable();
            InPhieu = Data.Business.BGIAO_DICH.In_Phieu_GD();

            Xtra_rpt_Phieu_GiaoDich xtr = new Xtra_rpt_Phieu_GiaoDich();
            xtr.DataSource = InPhieu;
            if (InPhieu.Rows[0]["Ma_Loai_GD"].ToString().Trim() == "MLGD01")
                xtr.labelTieuDe.Text = "PHIẾU THU";
            else
                xtr.labelTieuDe.Text = "PHIẾU CHI";
            xtr.label_SoTienBangChu.Text = inchu(InPhieu.Rows[0]["So_Tien_GD"].ToString());            
            printControl1.PrintingSystem = xtr.PrintingSystem;
            xtr.CreateDocument();
        }
        private void rpt_GiaoDich_Load(object sender, EventArgs e)
        {
            
            
        }
      
    }
}