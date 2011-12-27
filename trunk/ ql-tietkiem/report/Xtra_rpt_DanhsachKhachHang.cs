using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TIETKIEM
{
    public partial class XtraReport_DanhsachKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DanhsachKhachHang()
        {
            InitializeComponent();
        }
        int STT = 0;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            colSTT.Text = STT.ToString();
        }

        private void XtraReport_DanhsachKhachHang_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT = 0;
        }
      

    }
}
