using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DXApplication2
{
    public partial class FormTaoTK : Form
    {
        public FormTaoTK()
        {
            InitializeComponent();
        }

        private void FormTaoTK_Load(object sender, EventArgs e)
        {
            this.v_DSNV_CHUA_TAO_LOGINTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVTDataSet3.V_DSNV_CHUA_TAO_LOGIN' table. You can move, or remove it, as needed.
            this.v_DSNV_CHUA_TAO_LOGINTableAdapter.Fill(this.qLVTDataSet3.V_DSNV_CHUA_TAO_LOGIN);
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
           
            txtUserName.Enabled = false;
            txtNamLogin.Focus();
            if (Program.mGroup == "CONGTY")
            {
                cbRole.Items.Add("CONGTY");
            }
            else
            {
                cbRole.Items.Add("CHINHANH");
                cbRole.Items.Add("USER");
            }
            txtNamLogin.Focus();
        }


        private void btnTaoTK_Click_1(object sender, EventArgs e)
        {
            if (txtNamLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtNamLogin.Focus();
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtPass.Focus();
            }
            else if (txtPassCF.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtPassCF.Focus();
            }
            else if (cbRole.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm quyên không được để trống. Kiểm tra lại !!!", "Thông báo");
            }
            else if (txtPass.Text.Equals(txtPassCF.Text) == false)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau. Kiểm tra lại !!!", "Thông báo");
            }
            else
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }              
                SqlDataReader myReader1;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_TaoTaiKhoan]" +
                    "@LGNAME = N'" + txtNamLogin.Text + "'," +
                    "@PASS = N'" + txtPass.Text + "'," +
                    "@USERNAME = N'" + txtUserName.Text + "'," +
                    "@ROLE = N'" + cbRole.Text + "'" +
                    "SELECT  'Return Value' = @return_value";

                myReader1 = Program.ExecSqlDataReader(strlenh); 
              
                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1 || value1 == 2)
                {
                    MessageBox.Show("UserName bị trùng.");
                    return;
                }
                else if (value1 == 0)
                {
                    MessageBox.Show("THANH CONG");
                    txtNamLogin.Text = txtPass.Text = txtPassCF.Text = cbRole.Text = "";
                    this.v_DSNV_CHUA_TAO_LOGINTableAdapter.Fill(this.qLVTDataSet3.V_DSNV_CHUA_TAO_LOGIN);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNamLogin.Text = txtPass.Text = txtPassCF.Text = "";
            cbRole.Text = "";
        }
    }
}
