using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication2
{
    public partial class Vattu : Form
    {
        public Vattu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Vattu_Load(object sender, EventArgs e)
        {
           
           
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnReload.Enabled =btnExit.Enabled= btnHuy.Enabled=false;
                gbVattu.Enabled = false;
            }
            else
            {
                btnHuy.Enabled = false;
                 gbVattu.Enabled = false;
            }
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vattuBindingSource.AddNew();
            gbVattu.Enabled = true;                
            btnGhi.Enabled = btnReload.Enabled = btnUndo.Enabled = btnXoa.Enabled =btnExit.Enabled=btnThem.Enabled= false;
            btnHuy.Enabled = true;
            txtSlt.Text = 0+"";
            txtSlt.Enabled = false;
            txtMavt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMavt.Text.Trim()=="")
            {
                MessageBox.Show("Mã vật tư không được để trống !!!", "Thông báo");
                txtMavt.Focus();
            }
            else
            {

                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaVatTuTonTai] " +
                    "@MAVT = N'" + txtMavt.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();

                if (value == 1)
                {
                    MessageBox.Show("Mã vật tư đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                    txtMavt.Focus();
                    return;
                }
                else
                {
                    if (txtTenvt.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên vật tư không được để trống");
                        txtTenvt.Focus();
                    }
                    else
                    {
                        SqlDataReader myReader1;
                        String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraTenVatTuTonTai] " +
                            "@TENVATTU = N'" + txtTenvt.Text + "' SELECT  'Return Value' = @return_value";
                        myReader1 = Program.ExecSqlDataReader(strlenh1);
                        if (myReader1 == null) return;
                        myReader1.Read();
                        int value1 = myReader1.GetInt32(0);
                        myReader1.Close();

                        if (value1 == 1)
                        {
                            MessageBox.Show("Tên vật tư đã tồn tại. Kiểm tra lại !!!", "Thông báo");
                            txtTenvt.Focus();
                            return;
                        }
                        else
                        {
                            if (txtDvt.Text.Trim() == "")
                            {
                                MessageBox.Show("Đơn vị tính không được để trống");
                                txtDvt.Focus();

                            }                          
                        }
                        txtMavt.Text.Trim();
                        vattuBindingSource.EndEdit();
                        bdsVattu.Enabled = true;
                        gbVattu.Enabled = false;
                        btnExit.Enabled = btnGhi.Enabled = btnReload.Enabled = btnUndo.Enabled = btnXoa.Enabled =btnThem.Enabled= true;
                        btnHuy.Enabled = false;
                        
                        vattuTableAdapter.Update(dS.Vattu);
                        vattuTableAdapter.Fill(dS.Vattu);
                    }

                }
            }                           
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnExit.Enabled=btnThem.Enabled = false;
            gbVattu.Enabled = false;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa vật tư", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaVatTu] " +
                    "@MAVT = N'" + txtMavt.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);
                if (myReader1 == null) return;
                myReader1.Read();
                int value1 = myReader1.GetInt32(0);
                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã vật tư đã tồn tại trong CTPN,CTPX,CTDDH. Không thể xóa.", "Thông báo");
                    btnReload.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                   
                    return;
                }
                else
                {
                    vattuBindingSource.RemoveCurrent();
                    vattuTableAdapter.Update(dS.Vattu);
                    btnReload.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                    
                }

               
            }
            else
            {
                btnReload.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnExit.Enabled = btnThem.Enabled = true;
                gbVattu.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnReload.Enabled = btnUndo.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = false;
            gbVattu.Enabled = false;
            vattuTableAdapter.Update(dS.Vattu);
            vattuTableAdapter.Fill(dS.Vattu);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnReload.Enabled = btnUndo.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = true;
            gbVattu.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = false;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            MessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
            btnGhi.Enabled = btnXoa.Enabled = btnExit.Enabled = btnThem.Enabled = true;
            
        }

        private void Vattu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void textDvt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vattuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void tENVTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dVTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dVTLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tENVTLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sOLUONGTONLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbVattu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnReload.Enabled = btnExit.Enabled  = true;
            btnHuy.Enabled = false;

            vattuBindingSource.CancelEdit();
            vattuBindingSource.EndEdit();

            vattuTableAdapter.Fill(dS.Vattu);
        }
    }
}

                

            
           
                
           
       
    