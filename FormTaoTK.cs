using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'qLVTDataSet2.DanhSachNVChuaTaoTK' table. You can move, or remove it, as needed.
            this.danhSachNVChuaTaoTKTableAdapter.Fill(this.qLVTDataSet2.DanhSachNVChuaTaoTK);
            txtUserName.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                cbRole.Items.Add("CONGTY");
            }
            else
            {
                cbRole.Items.Add("CHINHANH");
                cbRole.Items.Add("USER");
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
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
            else{

                txtNamLogin.Text = txtPass.Text = txtPassCF.Text = "";
                this.danhSachNVChuaTaoTKTableAdapter.Fill(this.qLVTDataSet2.DanhSachNVChuaTaoTK);
            }
        }
    }
}
