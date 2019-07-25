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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            Program.servername = "DESKTOP-R117U2T\\NHINHI";
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSetDSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSetDSPM.V_DS_PHANMANH);
            cbCoSo.SelectedIndex = 1; // chọn dòng số 2
            cbCoSo.SelectedIndex = 0;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            else
            {
                Program.servername = cbCoSo.SelectedValue.ToString();
                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;


                if (Program.KetNoi() == 0) return;
                else
                {
                    Program.bds_dspm = this.bdsDSPM;
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;
                    Program.mCoSo = cbCoSo.SelectedIndex;
                    SqlDataReader myReader;
                        string strlenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
                        myReader = Program.ExecSqlDataReader(strlenh);
                        if (myReader == null) return;
                        myReader.Read();
                        Program.username = myReader.GetString(0);
                        Program.mHoten = myReader.GetString(1);
                        Program.mGroup = myReader.GetString(2);
                        myReader.Close();
                        FormMain frMain = new FormMain();
                        frMain.MANV.Text ="Mã nhân viên : "+ Program.username;
                        frMain.HOTEN.Text = "Họ và tên : " + Program.mHoten;
                        frMain.NHOM.Text = "Nhóm quyền : " + Program.mGroup;
                        frMain.Show();
                        this.Hide();
                }
            }
           
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
