using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class FormPhieunhap : Form
    {
        public FormPhieunhap()
        {
            InitializeComponent();
        }

        private void FormPhieunhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled =false;
                btnReload.Enabled = true;
               
            }
            else
            {
                panelChinhanh.Enabled = false;
                
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mACNTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nGAYLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            phieuNhapBindingSource.AddNew();
            btnReload.Enabled = btnXoa.Enabled = false;
            txtMaphieunhap.Enabled = txtNgay.Enabled = txtMaDDH.Enabled = txtManv.Enabled = btnOk.Enabled = true;
            txtManvpn.Text = txtManv.Text;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtMaphieunhap.Text.Trim()=="")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMaphieunhap.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuNhap] " +
                    "@MAPN = N'" + txtMaphieunhap.Text + "' SELECT  'Return Value' = @return_value";

                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                    txtMaphieunhap.Focus();
                    return;
                }
                else
                {
                    if(txtNgay.Text.Trim()=="")
                    {
                        MessageBox.Show("Ngày không được để trống. Kiểm tra lại !!!", "Thông báo");
                        txtMaphieunhap.Focus();
                    }
                    else if(txtMaDDH.Text.Trim()=="")
                    {
                        MessageBox.Show("Mã đơn đặt hàng không được để trống. Kiểm tra lại !!!", "Thông báo");
                        txtMaphieunhap.Focus();
                    }
                    else
                    {
                        phieuNhapBindingSource.EndEdit();                      
                        btnReload.Enabled = btnXoa.Enabled = true;
                        phieuNhapTableAdapter.Update(dS.PhieuNhap);
                        txtMaphieunhap.Enabled = txtNgay.Enabled = txtMaDDH.Enabled = txtManv.Enabled = btnOk.Enabled = false;
                    }

                }
            }
        }
    }
}
