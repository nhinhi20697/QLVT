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
    public partial class FormPhieuxuat : Form
    {
        public FormPhieuxuat()
        {
            InitializeComponent();
        }

        private void FormPhieuxuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhsachnhanvien.sp_InDanhSachMaVatTuCTPX' table. You can move, or remove it, as needed.
            this.sp_InDanhSachMaVatTuCTPXTableAdapter.Fill(this.danhsachnhanvien.sp_InDanhSachMaVatTuCTPX);
            // TODO: This line of code loads data into the 'qLVTDataSet.sp_InDanhSachNhanVienDangLamViec' table. You can move, or remove it, as needed.
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter.Fill(this.qLVTDataSet.sp_InDanhSachNhanVienDangLamViec);
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.


            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHuy.Enabled = btnExit.Enabled = false;
                cbChinhanh.Enabled = true;
            }
            else
            {
                btnHuy.Enabled = false;
                cbChinhanh.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

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
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                        this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPXTableAdapter.Fill(this.dS.CTPX);
                    }

                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnHuy.Enabled=true;
            phieuXuatBindingSource.AddNew();
            string temp = DateTime.Now.ToString("d");
            txtNgay.Text = temp;
            txtMaphieuxuat.Enabled = txtTenkhachhang.Enabled =  true;
            txtManv.Text = Program.username;
            btnOkphieuxuat.Enabled = true;
            Listctpx.Items[0].Visible = false;
            Listctpx.Items[1].Visible = false;
            Listctpx.Items[2].Visible = false;
            txtMaphieuxuat.Focus();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOkphieuxuat_Click(object sender, EventArgs e)
        {
            if (txtMaphieuxuat.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.");
                txtMaphieuxuat.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuXuat] " +
                    "@MAPX = N'" + txtMaphieuxuat.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã phiếu xuất đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                    txtMaphieuxuat.Focus();
                    return;
                }
                else
                {
                    if (txtTenkhachhang.Text == "")
                    {
                        MessageBox.Show("Họ và tên khách hàng không được để trống.");
                        txtTenkhachhang.Focus();
                    }
                    else
                    {
                        txtMaphieuxuat.Text.Trim();
                        phieuXuatBindingSource.EndEdit();
                        btnReload.Enabled = btnXoa.Enabled = btnThem.Enabled = btnExit.Enabled = true;

                        phieuXuatTableAdapter.Update(dS.PhieuXuat);
                        phieuXuatTableAdapter.Fill(dS.PhieuXuat);

                        txtMaphieuxuat.Enabled = txtTenkhachhang.Enabled =btnHuy.Enabled= false;
                        btnOkphieuxuat.Enabled = false;
                        Listctpx.Items[0].Visible = true;
                        Listctpx.Items[2].Visible = true;
                    }


                }


            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnReload.Enabled = btnHuy.Enabled = btnExit.Enabled = false;
            
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu xuất.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaPhieuXuat] " +
                    "@MAPX = N'" + txtMaphieuxuat.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã phiếu xuất đã tồn tại trong chi tiết phiếu xuất. Không thể xóa !!!", "Thông báo");
                    btnThem.Enabled = btnReload.Enabled = btnHuy.Enabled = btnExit.Enabled = true;
                    return;
                }
                else
                {                    
                    phieuXuatBindingSource.RemoveCurrent();
                    phieuXuatTableAdapter.Update(dS.PhieuXuat);
                    MessageBox.Show("Xóa phiếu xuất thành công.");
                    btnThem.Enabled = btnReload.Enabled = btnHuy.Enabled = btnExit.Enabled = true;
                    
                }
            }
            else
            {
                btnThem.Enabled = btnReload.Enabled = btnHuy.Enabled = btnExit.Enabled = true;
            }      
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnExit.Enabled=btnHuy.Enabled = false;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnThem.Enabled = btnXoa.Enabled = btnExit.Enabled = btnHuy.Enabled = true;
        }

        private void thêmCTPXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnExit.Enabled = btnHuy.Enabled =btnReload.Enabled= false;
            cTPXBindingSource.AddNew();
            txtMactpx.Text = txtMaphieuxuat.Text;
            cbMavt.Enabled = txtSoluong.Enabled = txtDongia.Enabled=btnOkctpx.Enabled = true;
            Listctpx.Items[0].Visible = false;
            Listctpx.Items[2].Visible = false;
            Listctpx.Items[1].Visible = true;
            txtMavt.Text = cbMavt.Text;
            
        }

        private void cbMavt_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMavt.Text = cbMavt.Text;

            SqlDataReader myReader;
            String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_InSoLuongVatTuCTPX] " +
                        "@MAVT = N'" + txtMavt.Text + "' SELECT  'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh1);
            if (myReader == null) return;
            myReader.Read();           
            try{
                int value = myReader.GetInt32(0);
                txtSoluong.Text = value + "";
                myReader.Close();
                this.txtSoluong.Properties.MinValue = 1;
                this.txtSoluong.Properties.MaxValue = value;
            }catch(Exception a){
                
            }
        }

        private void btnOkctpx_Click(object sender, EventArgs e)
        {
            if(txtDongia.Text=="")
            {
                MessageBox.Show("Đơn giá không được để trống.");
                txtDongia.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaChiTietPhieuXuat]" +
                    "@MAVT = N'" + txtMavt.Text + "'," +
                    "@MAPX = N'" + txtMactpx.Text + "'" +
                    "SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Chi tiết phiếu xuất này đã tồn tại.Vui lòng chọn mã vật tư khác.");
                    cbMavt.Focus();                  
                    return;
                }
                else
                {
                    cTPXBindingSource.EndEdit();
                    btnReload.Enabled = btnXoa.Enabled = btnThem.Enabled = btnExit.Enabled =  true;
                    cbMavt.Enabled = txtDongia.Enabled = txtSoluong.Enabled = false;
                    btnOkctpx.Enabled = false;
                    Listctpx.Items[0].Visible = true;
                    Listctpx.Items[1].Visible = false;
                    Listctpx.Items[2].Visible = true;
                    cTPXTableAdapter.Update(dS.CTPX);
                    int temp = int.Parse(txtSoluong.Text);
                    SqlDataReader myReader1;

                    string lenh = "EXEC  sp_GiamSLTCTPX '" +
                                txtMavt.Text + "','" +                                                              
                                temp + "'";
                    myReader1 = Program.ExecSqlDataReader(lenh);
                }
               
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            phieuXuatBindingSource.CancelEdit();
            phieuXuatBindingSource.EndEdit();
            phieuXuatTableAdapter.Fill(dS.PhieuXuat);
            txtMaphieuxuat.Enabled = txtTenkhachhang.Enabled = btnOkphieuxuat.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnHuy.Enabled = false;
            Listctpx.Items[0].Visible = true;
            Listctpx.Items[1].Visible = true;
            Listctpx.Items[2].Visible = true;
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTPXBindingSource.CancelEdit();
            cTPXBindingSource.EndEdit();
            cTPXTableAdapter.Fill(dS.CTPX);
            cbMavt.Enabled = txtSoluong.Enabled = txtDongia.Enabled = btnOkctpx.Enabled=false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            Listctpx.Items[0].Visible = true;
            Listctpx.Items[1].Visible = false;
            Listctpx.Items[2].Visible = true;
        }

        private void bdsPhieuxuat_Click(object sender, EventArgs e)
        {

        }
    }
}
