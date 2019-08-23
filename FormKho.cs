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
    public partial class FormKho : Form
    {
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled =btnReload.Enabled=btnExit.Enabled=btnHuy.Enabled= false;
                gbKho.Enabled = false;
            }
            else
            {
                panelChinhanh.Enabled = false;
                gbKho.Enabled = false;
                btnHuy.Enabled = false;
            }
            cbChinhanh.SelectedIndex = Program.mCoSo;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            khoBindingSource.AddNew();
            btnGhi.Enabled = btnReload.Enabled = btnXoa.Enabled =btnExit.Enabled=btnThem.Enabled= false;
            btnHuy.Enabled = true;
            gbKho.Enabled = true;
            bdsKho.Enabled = false;
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
            txtMakho.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtMakho.Text.Trim()=="")
            {
                MessageBox.Show("Mã kho không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMakho.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaKhoTonTai] " +
                    "@MAKHO = N'" + txtMakho.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã kho đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                    txtMakho.Focus();
                    return;
                }
                else
                {
                    if (txtTenkho.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên kho không được để trống");
                        txtTenkho.Focus();
                    }
                    else
                    {
                        SqlDataReader myReader1;
                        String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraTenKhoTonTai] " +
                            "@TENKHO = N'" + txtTenkho.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                        myReader1 = Program.ExecSqlDataReader(strlenh1);
                        if (myReader1 == null) return;
                        myReader1.Read();
                        int value1 = myReader1.GetInt32(0);
                        myReader1.Close();

                        if (value1 == 1)
                        {
                            MessageBox.Show("Tên kho đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                            txtTenkho.Focus();
                            return;
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
                                txtMakho.Text.Trim();
                                khoBindingSource.EndEdit();

                                btnExit.Enabled = btnGhi.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
                                khoTableAdapter.Update(dS.Kho);
                                khoTableAdapter.Fill(dS.Kho);
                                bdsKho.Enabled = true;
                                gbKho.Enabled = false;
                                btnHuy.Enabled = false;
                                bdsKho.Enabled = true;
                            }
                        }

                    }

                }
            }
           
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa kho.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {              
                khoBindingSource.RemoveCurrent();
                khoTableAdapter.Update(dS.Kho);
                btnReload.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = true;
            }
            else
            {
                btnReload.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = true;
               
            }                     
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnGhi.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = false; 
            this.khoTableAdapter.Fill(this.dS.Kho);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnGhi.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled  = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = false;           
            khoTableAdapter.Update(dS.Kho);
            khoTableAdapter.Fill(dS.Kho);
            MessageBox.Show("Ghi thành công", "Thông báo");
            btnReload.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = true;            
        }

        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbChinhanh_SelectedIndexChanged_1(object sender, EventArgs e)
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

                        khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        khoTableAdapter.Fill(dS.Kho);
                    }

                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbKho.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnHuy.Enabled = false;

            khoBindingSource.CancelEdit();
            khoBindingSource.EndEdit();

            khoTableAdapter.Fill(dS.Kho);
            bdsKho.Enabled = true;
        }
    }
}

