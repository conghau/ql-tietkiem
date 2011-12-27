using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TIETKIEM.report
{
    public partial class Xtra_rpt_BC_DSHD_NGAY : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_rpt_BC_DSHD_NGAY()
        {
            InitializeComponent();
            
            
        }
        public void getBC()
        {
           // colMaBC.DataBindings.Add("Text",DataSource,"Ma_BC_DSHD");
        }

        int SoTT =0;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            SoTT++;
            colSTT.Text = SoTT.ToString();

        }

        private void Xtra_rpt_BC_DSHD_NGAY_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            SoTT = 0;
        }
       
       
    }
}
