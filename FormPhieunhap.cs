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
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);          

            //if (Program.mGroup == "CONGTY")
            //{
            //    btnThem.Enabled = btnXoa.Enabled =false;
            //    btnReload.Enabled = true;
               
            //}
            //else
            //{
            //    panelChinhanh.Enabled = false;
                
            //}

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
            string temp= DateTime.Now.ToString("d");
            
            
            txtNgay.Text = temp;
            //phieuNhapBindingSource.AddNew();
            //btnReload.Enabled = btnXoa.Enabled = false;
            //txtMaphieunhap.Enabled = txtNgay.Enabled = txtMaDDH.Enabled = txtManv.Enabled = btnOk.Enabled = true;
            //txtManvpn.Text = txtManv.Text;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if(txtMaphieunhap.Text.Trim()=="")
            //{
            //    MessageBox.Show("Mã phiếu nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
            //    txtMaphieunhap.Focus();
            //}
            //else
            //{
            //    SqlDataReader myReader;
            //    String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuNhap] " +
            //        "@MAPN = N'" + txtMaphieunhap.Text + "' SELECT  'Return Value' = @return_value";

            //    myReader = Program.ExecSqlDataReader(strlenh);
            //    if (myReader == null) return;
            //    myReader.Read();
            //    int value = myReader.GetInt32(0);

            //    myReader.Close();

            //    if (value == 1)
            //    {
            //        MessageBox.Show("Mã phiếu nhập đã tồn tại. Kiểm tra lại !!!", "Thông báo");
            //        txtMaphieunhap.Focus();
            //        return;
            //    }
            //    else
            //    {
            //        if(txtNgay.Text.Trim()=="")
            //        {
            //            MessageBox.Show("Ngày không được để trống. Kiểm tra lại !!!", "Thông báo");
            //            txtMaphieunhap.Focus();
            //        }
            //        else if(txtMaDDH.Text.Trim()=="")
            //        {
            //            MessageBox.Show("Mã đơn đặt hàng không được để trống. Kiểm tra lại !!!", "Thông báo");
            //            txtMaphieunhap.Focus();
            //        }
            //        else
            //        {
            //            phieuNhapBindingSource.EndEdit();                      
            //            btnReload.Enabled = btnXoa.Enabled = true;
            //            phieuNhapTableAdapter.Update(dS.PhieuNhap);
            //            txtMaphieunhap.Enabled = txtNgay.Enabled = txtMaDDH.Enabled = txtManv.Enabled = btnOk.Enabled = false;
            //        }

            //    }
            //}
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChinhanh.SelectedValue != null)
            {
                if (cbChinhanh.ValueMember != "")
                {
                    if (Program.servername != cbChinhanh.SelectedValue.ToString())
                    {
                        Program.servername = cbChinhanh.SelectedValue.ToString();
                    }
                    if (cbChinhanh.SelectedIndex != Program.mCoSo)
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                    }
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPNTableAdapter.Fill(this.dS.CTPN);
                    }

                }
            }
        }
    }
}
