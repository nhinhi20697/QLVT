using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Kiểm tra form tồn tại chưa?
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }


        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Vattu));
            if (frm != null) frm.Activate();
            else
            {
                Vattu f = new Vattu();
                f.MdiParent = this;
                f.Show();
            }


        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FormNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanvien f = new FormNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKho));
            if (frm != null) frm.Activate();
            else
            {
                FormKho f = new FormKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frDangNhap.Show();
            Close();

        }

        private void btnDondathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDondathang));
            if (frm != null) frm.Activate();
            else
            {
                FormDondathang f = new FormDondathang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapvattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieunhap));
            if (frm != null) frm.Activate();
            else
            {
                FormPhieunhap f = new FormPhieunhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXuatvattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuxuat));
            if (frm != null) frm.Activate();
            else
            {
                FormPhieuxuat f = new FormPhieuxuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frDangNhap.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "USER")
            {
                MessageBox.Show("Bạn không được xem báo cáo.Kiểm tra lại.");
               
            }
            else
            {
                Form frm = this.CheckExists(typeof(FormInDanhSachNhanVien));
                if (frm != null) frm.Activate();
                else
                {
                    FormInDanhSachNhanVien f = new FormInDanhSachNhanVien();
                    f.MdiParent = this;
                    f.Show();
                }
            }


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "USER")
            {
                MessageBox.Show("Bạn không được xem báo cáo.Kiểm tra lại.");

            }
            else
            {
                InDanhSachVatTuTheoTen vt = new InDanhSachVatTuTheoTen();
                ReportPrintTool invt = new ReportPrintTool(vt);
                invt.ShowPreviewDialog();
            }
           
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "USER")
            {
                MessageBox.Show("Bạn không được xem báo cáo.Kiểm tra lại.");

            }
            else
            {
                Form frm = this.CheckExists(typeof(FormInDanhSachDDHChuaCoPN));
                if (frm != null) frm.Activate();
                else
                {
                    FormInDanhSachDDHChuaCoPN f = new FormInDanhSachDDHChuaCoPN();
                    f.MdiParent = this;
                    f.Show();
                }
            }                           
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frDangNhap.Show();
            Close();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTK));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTK f = new FormTaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
