using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplication2
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            sp_InDanhSachNhanVienTheoTenTangDanTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sp_InDanhSachNhanVienTheoTenTangDanTableAdapter1.Fill(danhsachnhanvien1.sp_InDanhSachNhanVienTheoTenTangDan);
        }

    }
}
