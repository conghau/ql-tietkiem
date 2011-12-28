using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace TIETKIEM
{
    public partial class fmAbout : DevExpress.XtraEditors.XtraForm
    {
        public fmAbout()
        {
            InitializeComponent();
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
            System.GC.Collect();
        }
    }
}