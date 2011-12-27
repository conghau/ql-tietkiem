using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data.DataAccess;

namespace TIETKIEM
{
    public partial class fm_Chart_Doanh_so_Trong_Thang : DevExpress.XtraEditors.XtraForm
    {
        public fm_Chart_Doanh_so_Trong_Thang()
        {
            InitializeComponent();
            for (int i = 0; i < get_Nam().Rows.Count; i++)
            {
                cb_Nam.Properties.Items.Add(get_Nam().Rows[i]["Nam"].ToString());
            }

        }
        private DataTable get_Nam()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "select year(ngay) as Nam from bao_cao_DSHD_Ngay group by year(ngay)", null);
            return all;
        }
        private DataTable get_Thang()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "select month(ngay) as Thang from bao_cao_DSHD_Ngay group by month(ngay)", null);
            return all;
        }

        private void fm_Chart_Doanh_so_Trong_Thang_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < get_Thang().Rows.Count; i++)
            {
                cb_Thang.Properties.Items.Add(get_Thang().Rows[i]["Thang"].ToString());
            }
        }

        private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bAO_CAO_DSHD_NGAYTableAdapter.Fill(dS_Chart_Doanh_so_Trong_Thang1.BAO_CAO_DSHD_NGAY, Int16.Parse(cb_Thang.Text), Int16.Parse(cb_Nam.Text));
            gridView2.GridControl.DataSource = this.bAO_CAO_DSHD_NGAYTableAdapter.Fill(dS_Chart_Doanh_so_Trong_Thang1.BAO_CAO_DSHD_NGAY, Int16.Parse(cb_Thang.Text), Int16.Parse(cb_Nam.Text));
            
        }
    }
}