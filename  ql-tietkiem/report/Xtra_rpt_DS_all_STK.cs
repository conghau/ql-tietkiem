using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TIETKIEM.report
{
    public partial class Xtra_rpt_DS_all_STK : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_rpt_DS_all_STK()
        {
            InitializeComponent();
        }
        int STT;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            colSTT.Text = STT.ToString();
        }

    }
}
