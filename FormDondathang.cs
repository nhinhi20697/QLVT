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
    public partial class FormDondathang : Form
    {
        public FormDondathang()
        {
            InitializeComponent();
        }

        private void FormDondathang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inDanhSachMaVatTu.sp_InDanhSachMaVatTu' table. You can move, or remove it, as needed.
            this.sp_InDanhSachMaVatTuTableAdapter.Fill(this.inDanhSachMaVatTu.sp_InDanhSachMaVatTu);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_InDanhSachNhanVienDangLamViec' table. You can move, or remove it, as needed.
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter.Fill(this.qLVTDataSet.sp_InDanhSachNhanVienDangLamViec);
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            cbMavt.Enabled = false;

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled=btnExit.Enabled =btnHuy.Enabled= false;
                Listthem.Items[0].Visible = false;
                Listthem.Items[1].Visible = false;
                Listthem.Items[2].Visible = false;
                Listthem.Items[3].Visible = false;
            }
            else
            {
                btnHuy.Enabled = false;
                cbChinhanh.Enabled = false;
                Listthem.Items[3].Visible = false;
            }
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void datHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tENCNComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Fill(this.dS.DatHang);
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
                    }

                }
            }
        }

        private void tENCNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnOkctddh_Click(object sender, EventArgs e)
        {

            SqlDataReader myReader;
            String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaChiTietDDH]" +
                "@MAVT = N'" + txtMavt.Text + "'," +
                "@MADDH = N'" + txtMactddh.Text + "'" +
                "SELECT  'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();
            int value = myReader.GetInt32(0);

            myReader.Close();

            if (value == 1)
            {
                MessageBox.Show("Chi tiết đơn đặt hàng này đã tồn tại đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                txtMavt.Focus();
                return;
            }
            else
            {
                if (txtSoluong.Text.Trim() == "")
                {
                    MessageBox.Show("Số lượng vật tư không được để trống.");
                    txtNhacungcap.Focus();
                }

                else if (txtDonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống.");
                    txtNhacungcap.Focus();
                }

                else
                {
                    cTDDHBindingSource.EndEdit();
                    cTDDHTableAdapter.Update(dS.CTDDH);
                    cTDDHTableAdapter.Fill(dS.CTDDH);
                    cbMavt.Enabled = txtSoluong.Enabled = txtDonGia.Enabled = btnOkctddh.Enabled = false;
                    MessageBox.Show("Thêm vật tư cho đơn hàng thành công.");
                    Listthem.Items[0].Visible = true;
                    Listthem.Items[1].Visible = true;
                    Listthem.Items[2].Visible = true;
                    Listthem.Items[3].Visible = false;
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled =btnExit.Enabled= false;
            btnHuy.Enabled = true;
            datHangBindingSource.AddNew();
            txtMaddh.Enabled = txtNgay.Enabled = txtNhacungcap.Enabled = Btnokdh.Enabled = true;
            txtManv.Text = Program.username;
            txtMaddh.Focus();
            string temp = DateTime.Now.ToString("d");
            txtNgay.Text = temp;
            txtNgay.Enabled = false;
            Listthem.Items[0].Visible = false;
            Listthem.Items[1].Visible = false;
            Listthem.Items[2].Visible = false;
            Listthem.Items[3].Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTDDHBindingSource.AddNew();
            txtMactddh.Enabled = cbMavt.Enabled = txtSoluong.Enabled = txtDonGia.Enabled = btnOkctddh.Enabled = true;
            txtMactddh.Text = txtMaddh.Text;
            txtMactddh.Enabled = false;
            txtMavt.Text = cbMavt.Text;
            txtSoluong.Focus();
            Listthem.Items[0].Visible = false;
            Listthem.Items[1].Visible = false;
            Listthem.Items[2].Visible = false;
            Listthem.Items[3].Visible = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            txtSoluong.Properties.MinValue = 1;
            txtSoluong.Properties.MaxValue = 1000000;
            txtDonGia.Properties.MinValue = 1;
            txtDonGia.Properties.MaxValue = 100000000;
        }

        private void Btnokdh_Click(object sender, EventArgs e)
        {
            if (txtMaddh.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMaddh.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaDDH]" +
                    "@MADDH = N'" + txtMaddh.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã đơn đặt hàng đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                    txtMaddh.Focus();
                    return;
                }
                else
                {
                    if (txtNhacungcap.Text.Trim() == "")
                    {
                        MessageBox.Show("Nhà cung cấp không được để trống.");
                        txtNhacungcap.Focus();
                    }
                    else
                    {
                        
                        datHangBindingSource.EndEdit();
                        txtMaddh.Text.Trim();
                        datHangTableAdapter.Update(dS.DatHang);
                        datHangTableAdapter.Fill(dS.DatHang);
                        txtMaddh.Enabled = txtNgay.Enabled = txtNhacungcap.Enabled  = txtManv.Enabled = Btnokdh.Enabled = false;
                        MessageBox.Show("Thêm đơn hàng thành công.");
                        btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled=true;
                        Listthem.Items[0].Visible = true;
                        Listthem.Items[1].Visible = true;
                        Listthem.Items[2].Visible = true;
                        btnHuy.Enabled = false;
                    }
                }
            }
        }

        private void chiTiếtĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa đơn đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {

                SqlDataReader myReader;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaCTDDH]" +
                    "@MADDH = N'" + txtMactddh.Text + "'," +
                     "@MAVT = N'" + txtMavt.Text + "'" +
                     "SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Không thể xóa vât tư vì đã lập phiếu.Kiểm tra lại !!!", "Thông báo");
                    return;
                }
                else
                {

                    cTDDHBindingSource.RemoveCurrent();
                    cTDDHTableAdapter.Update(dS.CTDDH);
                    cTDDHTableAdapter.Fill(dS.CTDDH);
                    MessageBox.Show("Xóa vật tư trong đơn hàng thành công.");
                }
            }
            else
            {
                return;

            }
        }

        private void cbMavt_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbMavt_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMavt.Text = cbMavt.Text;
        }

        private void txtMavt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtManv.Text = cbManv.Text;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa đơn đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaDonDatHang]" +
                    "@MADDH = N'" + txtMaddh.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Đơn đặt hàng này không thể xóa.Kiểm tra lại !!!", "Thông báo");
                    btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                    return;
                }
                else
                {
                    datHangBindingSource.RemoveCurrent();
                    datHangTableAdapter.Update(dS.DatHang);
                    btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                    MessageBox.Show("Xóa đơn đặt hàng thành công.");
                }
            }
            else
            {
                btnReload.Enabled = btnExit.Enabled = btnThem.Enabled = true;

            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled =  true;
            btnHuy.Enabled =Btnokdh.Enabled= false;
            txtMaddh.Enabled = txtNhacungcap.Enabled = false;
            datHangBindingSource.CancelEdit();
            datHangBindingSource.EndEdit();
            datHangTableAdapter.Fill(dS.DatHang);
            Listthem.Items[0].Visible = true;
            Listthem.Items[1].Visible = true;
            Listthem.Items[2].Visible = true;

        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnHuy.Enabled = false;
            cTDDHBindingSource.CancelEdit();
            cTDDHBindingSource.EndEdit();
            cTDDHTableAdapter.Fill(dS.CTDDH);
            Listthem.Items[0].Visible = true;
            Listthem.Items[1].Visible = true;
            Listthem.Items[2].Visible = true;
            Listthem.Items[3].Visible = false;
            cbMavt.Enabled = txtDonGia.Enabled = txtSoluong.Enabled = btnOkctddh.Enabled = false;
        }
    }
}
