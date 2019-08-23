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
        private bool isLoaded = false;
        public FormPhieunhap()
        {
            InitializeComponent();
        }

        private void FormPhieunhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_InDanhSachNhanVienDangLamViec' table. You can move, or remove it, as needed.
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter.Fill(this.qLVTDataSet.sp_InDanhSachNhanVienDangLamViec);
         
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = false;
                btnReload.Enabled = btnExit.Enabled=false;
                cbChinhanh.Enabled = true;
                listVattu.Items[0].Visible = false;
                listVattu.Items[1].Visible = false;
                listVattu.Items[2].Visible = false;

            }
            else
            {
                cbChinhanh.Enabled = false;
            }
            cbChinhanh.SelectedIndex = Program.mCoSo;
            gbPhieunhap.Enabled = gbCtpn.Enabled = txtMaddh.Enabled = txtManv.Enabled = btnHuy.Enabled = false;

            isLoaded = true;
            listVattu.Items[2].Visible = false;
            cbChinhanh.SelectedIndex = Program.mCoSo;
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

            // TODO: This line of code loads data into the 'qLVTDataSet1.sp_InDanhSachMaCTDDH' table. You can move, or remove it, as needed.
            this.sp_InDanhSachMaCTDDHTableAdapter.Fill(this.qLVTDataSet1.sp_InDanhSachMaCTDDH);

            string temp= DateTime.Now.ToString("d");                       
            txtNgay.Text = temp;

            txtManv.Text = Program.username;
            txtManv.Enabled = false;
            txtMaddh.Text = cbMaddh.Text;
            btnReload.Enabled = btnXoa.Enabled =btnThem.Enabled=btnExit.Enabled= false;
            gbCtpn.Enabled = gbPhieunhap.Enabled = btnHuy.Enabled = cbMaddh.Enabled = txtMaphieunhap.Enabled =btnOkphieunhap.Enabled= true;
            txtNgay.Enabled = bdsPhieunhap.Enabled =  false;
            txtMaphieunhap.Focus();

            listVattu.Items[0].Visible = false;
            listVattu.Items[1].Visible = false;
            listVattu.Items[2].Visible = false;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
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

        private void masoDDHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaddh.Text = cbMaddh.Text;
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemvt_Click(object sender, EventArgs e)
        {

            cbMavt.Items.Clear();

            cTPNBindingSource.AddNew();
            txtMactpn.Text = txtMaphieunhap.Text;
            SqlDataReader myReader1;
            String strlenh1 = "EXEC [dbo].[sp_InMaVatTuCTPN]" +
                "@MAPN = N'" + txtMaphieunhap.Text + "'," +
                "@MADDH = N'" + txtMaddh.Text + "'";

            myReader1 = Program.ExecSqlDataReader(strlenh1);

            if (myReader1 == null) return;

            while (myReader1.Read())
            {
                cbMavt.Items.Add(myReader1.GetString(0));
            }

            myReader1.Close();
            bdsPhieunhap.Enabled = txtMactpn.Enabled = txtMavt.Enabled = txtDongia.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHuy.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            txtSoluong.Enabled = btnOkctpn.Enabled = true;

            gbCtpn.Enabled = true;
           
            cbMavt.Enabled = true;

            listVattu.Items[0].Visible = false;
            listVattu.Items[1].Visible = false;
            listVattu.Items[2].Visible = true;
            bdsCtpn.Enabled = false;
        }

        private void cbMavt_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMavt.Text = cbMavt.Text;
        }

        private void v(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                txtMavt.Text = cbMavt.Text;

                if (Program.KetNoi() == 0)
                    return;
                SqlDataReader myReader;
                String strlenh = "EXEC sp_InSoLuongDonGiaCTPN " +
                    "@MAVT = N'" + txtMavt.Text.Trim() + "'," +
                    "@MADDH = N'" + txtMaddh.Text.Trim() + "'";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int soluong = myReader.GetInt32(0);
                var dongia = myReader.GetDouble(1);

                txtDongia.Text = dongia.ToString();
                this.txtSoluong.Properties.MinValue = 1;
                this.txtSoluong.Properties.MaxValue = soluong;

                myReader.Close();
            }
        }

        private void btnOkphieunhap_Click(object sender, EventArgs e)
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
                phieuNhapBindingSource.EndEdit();
                phieuNhapBindingSource.CancelEdit();
                btnReload.Enabled = btnXoa.Enabled = btnThem.Enabled = btnExit.Enabled = bdsPhieunhap.Enabled = true;
                phieuNhapTableAdapter.Update(dS.PhieuNhap);
                phieuNhapTableAdapter.Fill(dS.PhieuNhap);
                txtMaphieunhap.Enabled = cbMaddh.Enabled = false;
                btnOkphieunhap.Enabled =btnHuy.Enabled= false;
                listVattu.Items[0].Visible = true;
                listVattu.Items[1].Visible = true;
                listVattu.Items[2].Visible = false;
           
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnExit.Enabled = false;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnThem.Enabled = btnXoa.Enabled = btnExit.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu nhập.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaPhieuNhap] " +
                    "@MAPN = N'" + txtMaphieunhap.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại trong chi tiết phiếu nhập. Không thể xóa !!!", "Thông báo");
                    return;
                }
                else
                {
                    phieuNhapBindingSource.RemoveCurrent();
                    phieuNhapTableAdapter.Update(dS.PhieuNhap);
                    btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                    MessageBox.Show("Xóa phiếu nhập thành công.");
                }
                
            }
            else
            {

                btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = true;
            }      
        }

        private void btnOkctpn_Click(object sender, EventArgs e)
        {
            if (txtMavt.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMavt.Focus();
            }
            else if (txtSoluong.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng vật tư không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtSoluong.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "EXEC sp_TangSLTCTPN " +
                    "@MAVT = N'" + cbMavt.Text.Trim() + "'," +
                    "@SL = N'" + Convert.ToInt32(txtSoluong.Text.Trim()) + "'";

                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                myReader.Close();
                cTPNBindingSource.EndEdit();
                cTPNTableAdapter.Update(dS.CTPN);
                cTPNTableAdapter.Fill(dS.CTPN);
                listVattu.Items[0].Visible = true;
                listVattu.Items[1].Visible = true;
                listVattu.Items[2].Visible = false;
                btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                bdsPhieunhap.Enabled = bdsCtpn.Enabled = true;
                gbCtpn.Enabled = false;
           }
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTPNBindingSource.CancelEdit();
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            bdsPhieunhap.Enabled = bdsCtpn.Enabled = true;
            gbCtpn.Enabled = false;
            listVattu.Items[0].Visible = true;
            listVattu.Items[1].Visible = true;
            listVattu.Items[2].Visible = false;
        }

        private void btnReloadvt_Click(object sender, EventArgs e)
        {
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            phieuNhapBindingSource.CancelEdit();
            phieuNhapBindingSource.EndEdit();
            phieuNhapTableAdapter.Fill(dS.PhieuNhap);
            phieuNhapTableAdapter.Update(dS.PhieuNhap);
            gbPhieunhap.Enabled = btnHuy.Enabled = false;
            bdsPhieunhap.Enabled = btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled =btnExit.Enabled= true;
            listVattu.Items[0].Visible = true;
            listVattu.Items[1].Visible = true;
            listVattu.Items[2].Visible = false;
        }

        private void txtDongia_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
