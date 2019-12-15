using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.BUSFastFood;

namespace WindowsFormsApp7
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public static string ID_USER = string.Empty;
        public static string NAME = string.Empty;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaikhoan.Text;
            string matKhau = txtMatkhau.Text;
            ID_USER = BUSAccount.Instance.getID(taiKhoan, matKhau);
            if (ID_USER != string.Empty)
            {

                frmMain fm = new frmMain();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        

        private void picTurnOff_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }
    }
}
