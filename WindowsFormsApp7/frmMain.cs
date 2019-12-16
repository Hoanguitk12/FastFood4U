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
using WindowsFormsApp7.DALFastFood;
using WindowsFormsApp7.DTOFastFood;
using WindowsFormsApp7.GUIFastFood;

namespace WindowsFormsApp7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string QUYEN = string.Empty;
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmThongTin frmThongTin = new frmThongTin();
            frmThongTin.TopLevel = false;
            pnZone.Controls.Add(frmThongTin);
            frmThongTin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmThongTin.AutoScroll = true;
            frmThongTin.Dock = DockStyle.Fill;
            frmThongTin.Show();
            QUYEN = BUSAccount.Instance.GetQuyen(frmLogin.ID_USER);
        }
        private bool checkQuyen(string quyen)
        {
            if (quyen != "admin")
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền truy cập");
                return false;
            }
            return true;
        }

        private void btnCreatBill_Click(object sender, EventArgs e)
        {

           int idaccount = int.Parse(frmLogin.ID_USER);
            string datecheck = DateTime.Now.ToString("MM/dd /yyyy");
            int totalbill = 0;
           int total = 0;
            int exchange = 0;
            DALBill.Instance.AddBill(datecheck, totalbill, total, exchange, idaccount);
           //id bill la id lon nhat

            frmCreatBill fm = new frmCreatBill();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (checkQuyen(QUYEN))
            {
                pnZone.Controls.Clear();
                frmStaff frmStaff = new frmStaff();
                frmStaff.TopLevel = false;
                pnZone.Controls.Add(frmStaff);
                frmStaff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmStaff.AutoScroll = true;
                frmStaff.Dock = DockStyle.Fill;
                frmStaff.Show();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (checkQuyen(QUYEN))
            {
                pnZone.Controls.Clear();
                frmAccount frmAccount = new frmAccount();
                frmAccount.TopLevel = false;
                pnZone.Controls.Add(frmAccount);
                frmAccount.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmAccount.AutoScroll = true;
                frmAccount.Dock = DockStyle.Fill;
                frmAccount.Show();
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            if (checkQuyen(QUYEN))
            {
                pnZone.Controls.Clear();
                frmRevenue frmRevenue = new frmRevenue();
                frmRevenue.TopLevel = false;
                pnZone.Controls.Add(frmRevenue);
                frmRevenue.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmRevenue.AutoScroll = true;
                frmRevenue.Dock = DockStyle.Fill;
                frmRevenue.Show();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            pnZone.Controls.Clear();
            frmImport frmImport = new frmImport();
            frmImport.TopLevel = false;
            pnZone.Controls.Add(frmImport);
            frmImport.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmImport.AutoScroll = true;
            frmImport.Dock = DockStyle.Fill;
            frmImport.Show();
        }
       

    }
}
