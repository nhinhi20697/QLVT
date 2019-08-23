using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace DXApplication2
{
    static class Program
    {
        public static FormDangNhap frDangNhap;
        //public static FormMain frmMain;
        

        public static SqlConnection conn = new SqlConnection();

        public static String connstr;

        public static String servername = "";

        public static String username = "";

        public static String mlogin = "";

        public static String password = "";

        public static String database = "QLVT";

        public static String remotelogin = "HTKN";

        public static String remotepassword = "123";

        public static String mloginDN = "";//user

        public static String passwordDN = "";//pass

        public static String mGroup = "";

        public static String mHoten = "";

        public static SqlCommand cmd = new SqlCommand();

        public static int mCoSo;
       

        // giữ danh sách phân mảnh của cơ sở khi đăng nhập

        public static BindingSource bds_dspm = new BindingSource();

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frDangNhap = new FormDangNhap();
            Application.Run(frDangNhap);
        }

       
    }
}
