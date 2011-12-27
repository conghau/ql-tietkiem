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
    public partial class fm_Chart_Dong_Mo_So_Thang : DevExpress.XtraEditors.XtraForm
    {
        public fm_Chart_Dong_Mo_So_Thang()
        {
            InitializeComponent();
            for (int i = 0; i < get_Nam().Rows.Count; i++)
            {
                cb_Nam.Properties.Items.Add(get_Nam().Rows[i]["Nam"].ToString());
            }
        }
        public DataTable get_Nam()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "SELECT nam FROM bao_cao_mo_dong_so_thang GROUP BY nam", null);
            return all;
            //
        }
        private void fm_Chart_Load(object sender, EventArgs e)
        {
        }

        private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dS_Chart_Dong_Mo_So1.DataTable1,Int16.Parse(cb_Nam.Text));
        }
        private void fm_Chart_Dong_Mo_So_Thang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Chart_Dong_Mo_So1.DataTable1' table. You can move, or remove it, as needed.
            

        }
    }
}