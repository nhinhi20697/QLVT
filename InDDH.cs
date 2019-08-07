using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplication2
{
    public partial class InDDH : DevExpress.XtraReports.UI.XtraReport
    {
        public InDDH()
        {
            InitializeComponent();
            
            try
            {
                sp_InDanhSachDDHChuaCoPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_InDanhSachDDHChuaCoPNTableAdapter.Fill(danhsachnhanvien2.sp_InDanhSachDDHChuaCoPN);
            }
            catch { };
            
        }

    }
}
