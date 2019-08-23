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
    public partial class FormNhanvien : Form
    {
        public FormNhanvien()
        {
            InitializeComponent();
        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            /*chạy sai nếu đổi mât khẩu của 1 tài khoản.nó sẽ giữ tài khoản cũ.chọn chi nhánh 2 nó vẫn chạy chi nhánh 1.Thông tin tài khoản của ng đăng nhập:connstr*/

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled =btnChuyenchinhanh.Enabled=btnReload.Enabled=btnThoat.Enabled=btnHuy.Enabled= false;
                gbNhanvien.Enabled = false;
               
            }
            else
            {
                cbChinhanh.Enabled =btnHuy.Enabled= false;
                gbNhanvien.Enabled = false;
               
            }
            cbChinhanh.SelectedIndex = Program.mCoSo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cbChinhanh.SelectedValue.ToString();

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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnThem.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled = btnDathang.Enabled = false;
            nhanVienTableAdapter.Update(dS.NhanVien);
           
            
            MessageBox.Show("Ghi thành công", "Thông báo");
            btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnThem.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled = btnDathang.Enabled = true;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            nhanVienBindingSource.AddNew();
            btnGhi.Enabled = btnReload.Enabled = btnXoa.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled= btnThem.Enabled=btnThoat.Enabled= false;
            btnHuy.Enabled = true;
            gbNhanvien.Enabled = true;
            bdsNhanvien.Enabled = false;
            if (Program.mCoSo == 0)
            {
                txtMacn.Text = "CN1";
                txtMacn.Enabled = false;
            }
            else if (Program.mCoSo == 1)
            {
                txtMacn.Text = "CN2";
                txtMacn.Enabled = false;
            }
            txtTrangthaixoa.Text = "0";
            txtTrangthaixoa.Enabled = false;

            SqlDataReader myReader1;
            String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_LayMaxMaNhanVien] " +
                    "@temp = N'" + 0 + "' SELECT  'Return Value' = @return_value";
            myReader1 = Program.ExecSqlDataReader(strlenh1);

            if (myReader1 == null) return;

            myReader1.Read();
            int value1 = myReader1.GetInt32(0);

            myReader1.Close();
            int temp = value1 + 2;
            string temps = "" + temp;
            txtManv.Text = temps;
            txtManv.Enabled = false;
            txtHo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống");
                txtHo.Focus();
            }
            else
            {
                if (txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Tên nhân viên không được để trống");
                    txtTen.Focus();
                }
                else
                {
                    if (txtNgaysinh.Text.Trim() == "")
                    {
                        MessageBox.Show("Ngày sinh không được để trống");
                        txtNgaysinh.Focus();
                    }
                    else
                    {
                        if (txtDiachi.Text.Trim() == "")
                        {
                            MessageBox.Show("Địa chỉ không được để trống");
                            txtDiachi.Focus();
                        }
                        else
                        {
                            if (txtLuong.Text.Trim() == "")
                            {
                                MessageBox.Show("Lương không được để trống");
                                txtLuong.Focus();
                            }
                            else
                            {
                                string temp2 = txtLuong.Text.Trim();
                                float Luong = float.Parse(temp2);
                                if (Luong < 4000000)
                                {
                                    MessageBox.Show("Lương không được nhỏ hơn 4.000.000");
                                    txtLuong.Focus();
                                }
                                else
                                {
                                    nhanVienBindingSource.EndEdit();
                                    btnThoat.Enabled = btnGhi.Enabled = btnReload.Enabled = btnXoa.Enabled = btnChuyenchinhanh.Enabled =btnThem.Enabled = true;
                                    btnHuy.Enabled = false;
                                    nhanVienTableAdapter.Update(dS.NhanVien);
                                    nhanVienTableAdapter.Fill(dS.NhanVien);
                                    bdsNhanvien.Enabled = true;
                                    gbNhanvien.Enabled = false;
                                    bdsNhanvien.Enabled = true;
                                }

                            }
                        }
                    }
                }
            }


        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled = false;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa nhân viên.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaNhanVien] " +
                        "@MANV = N'" + txtManv.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();

                if (value1 == 1)
                {
                    MessageBox.Show("Nhân viên đã lập phiếu.Không được xóa.");
                    txtTrangthaixoa.Text = "1";
                    nhanVienBindingSource.EndEdit();
                    nhanVienTableAdapter.Update(dS.NhanVien);
                }
                else
                {
                    
                    nhanVienBindingSource.RemoveCurrent();
                    nhanVienTableAdapter.Update(dS.NhanVien);
                }

                gbNhanvien.Enabled = true;
                btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled = true;
                gbNhanvien.Enabled = false;

            }
            else
            {
                btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnChuyenchinhanh.Enabled = btnXoaddh.Enabled = true;

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXoa.Enabled = btnThoat.Enabled = btnThem.Enabled = btnGhi.Enabled = btnChuyenchinhanh.Enabled = btnDathang.Enabled = btnXoaddh.Enabled = false;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnXoa.Enabled = btnThoat.Enabled = btnThem.Enabled = btnGhi.Enabled = btnChuyenchinhanh.Enabled = btnDathang.Enabled = btnXoaddh.Enabled = true;
        }

        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
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

                        nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        nhanVienTableAdapter.Fill(dS.NhanVien);
                    }

                }
            }
        }

        private void btnChuyenchinhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnXoaddh.Enabled = btnDathang.Enabled = false;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn chuyển chi nhánh", "Chuyển nhân viên.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                txtTrangthaixoa.Text = "1";
                nhanVienBindingSource.EndEdit();
                nhanVienTableAdapter.Update(dS.NhanVien);

                btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnXoaddh.Enabled = btnDathang.Enabled = true;
                // Qua site kia bằng HTKN
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                
                string macn = "";

                if (cbChinhanh.SelectedIndex == 0)
                {
                    Program.servername = "DESKTOP-R117U2T\\NHINHI_1";
                    macn = "CN2";
                }

                else 
                { 
                    Program.servername = "DESKTOP-R117U2T\\NHINHI";
                    macn = "CN1";
                }

                Program.KetNoi();

                // Lấy max mã nhân viên để không bi trùng.
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_LayMaxMaNhanVien] " +
                        "@temp = N'" + 0 + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);
                myReader1.Close();
                int manv = value1 + 2;

                SqlDataReader myReader2;
                                
                string lenh = "EXEC  sp_ThemNhanVien '" + 
                            manv + "','" +
                            txtHo.Text + "','" +
                            txtTen.Text + "','" +
                            txtNgaysinh.Text + "','" +
                            txtDiachi.Text + "','" + 
                            txtLuong.Text + "','" + 
                            macn + "','" +
                            0 + "'";
                myReader2 = Program.ExecSqlDataReader(lenh);
                MessageBox.Show("Chuyển chi nhánh nhân viên thành công.kakaka");

                // Quay lại site cũ
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;

                if (cbChinhanh.SelectedIndex == 0)
                {
                    Program.servername = "DESKTOP-R117U2T\\NHINHI";
                }

                else
                {
                    Program.servername = "DESKTOP-R117U2T\\NHINHI_1";
                }

                Program.KetNoi();


            }
            else
            {
                btnReload.Enabled = btnGhi.Enabled = btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnXoaddh.Enabled = btnDathang.Enabled = true;

            }
        }

        private void datHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void mANVSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
 
        }

        private void btnOkDdh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoaddh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbNhanvien.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled =btnChuyenchinhanh.Enabled= true;
            btnHuy.Enabled = false;
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.EndEdit();
            nhanVienTableAdapter.Fill(dS.NhanVien);
            bdsNhanvien.Enabled = true;
        }

        private void txtLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtLuong.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtLuong.Text);
                txtLuong.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
    }
}

/*ứng dụng phân tán
 đứng ở site 1 chạy qua site 2 kiểm tra trùng mã nhân viên thông qua sp*/
