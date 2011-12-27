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
    public partial class fm_DS_all_STK : DevExpress.XtraEditors.XtraForm
    {
        public fm_DS_all_STK()
        {
            InitializeComponent();
        }

        private void printControl1_Load(object sender, EventArgs e)
        {
           Xtra_rpt_DS_all_STK DS_all_STK = new Xtra_rpt_DS_all_STK();
          // DS_all_STK.DataSource = this.dS_SoTietKiem1.Datatable_SoTK;
           printControl1.PrintingSystem = DS_all_STK.PrintingSystem;
           DS_all_STK.CreateDocument();
        }
    }
}