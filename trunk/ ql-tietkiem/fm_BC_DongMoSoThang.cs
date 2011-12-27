using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using TIETKIEM.Data.DataAccess;
using TIETKIEM.report;

namespace TIETKIEM
{
    public partial class fm_BC_DongMoSoThang : DevExpress.XtraEditors.XtraForm
    {
        public fm_BC_DongMoSoThang()
        {
            InitializeComponent();
            for (int i = 0; i < get_Thang().Rows.Count; i++)
            {
                cb_Thang.Properties.Items.Add(get_Thang().Rows[i]["Thang"].ToString());
            }
        }
        public DataTable get_Thang()
        {
            //SqlParameter[] pr = new SqlParameter[1];
            //pr[0] = new SqlParameter(@"Ma_TK", Ma_TK);
            DataTable all = SqlHelper.ExecuteData(CommandType.Text,"select thang from Bao_cao_mo_dong_so_thang  group by thang",null);
            return all;
        }
        public DataTable get_MLTK(string thang)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Thang", thang);
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "select ma_loai_tk from bao_cao_mo_dong_so_thang where thang = @Thang", pr);
            return all;
        }

        private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_MLTK.Properties.Items.Clear();
            cb_MLTK.Text = "";
            for (int i = 0; i < get_MLTK(cb_Thang.Text).Rows.Count; i++)
            {
                cb_MLTK.Properties.Items.Add(get_MLTK(cb_Thang.Text).Rows[i]["Ma_Loai_TK"].ToString());
            }
        }

        Xtra_rpt_BC_Mo_Dong_So_Thang xtr_BCDMS = new Xtra_rpt_BC_Mo_Dong_So_Thang();
        private void cb_MLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            xtr_BCDMS.DataSource = get_BC_MDS_thang();
            printControl1.PrintingSystem = xtr_BCDMS.PrintingSystem;
            xtr_BCDMS.CreateDocument();

            gridView2.GridControl.DataSource = this.dS_BC_Mo_Dong_So_Thang1.Datable_BC_Mo_Dong_So_Thang;

        }
        public DataSet get_BC_MDS_thang()
        {

            DataSet ds = new DataSet();
            this.datable_BC_Mo_Dong_So_ThangTableAdapter1.Fill(this.dS_BC_Mo_Dong_So_Thang1.Datable_BC_Mo_Dong_So_Thang,Int16.Parse(cb_Thang.Text),cb_MLTK.Text);
            return ds = this.dS_BC_Mo_Dong_So_Thang1.Datable_BC_Mo_Dong_So_Thang.DataSet;

        }
    }
}