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
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.GUIFastFood
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadAccounttodtgv()
        {
            GridAccount.DataSource = BUSAccount.Instance.GetAccount();


            GridAccount.Columns[0].Visible = true;
            GridAccount.Columns[1].Visible = false;//ẩn cột mã ;
            GridAccount.Columns[2].HeaderText = "NameAccount";
            GridAccount.Columns[3].HeaderText = "Password";
            GridAccount.Columns[4].HeaderText = "Status";
            GridAccount.Columns[5].HeaderText = "IDStaff";
            
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccounttodtgv();
            LoadStaffToCb();
        }

        private void GridAccount_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridAccount.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void AddAccount(string nameaccount, string password, string status, int idstaff)
        {
           if (BUSAccount.Instance.AddAccount(nameaccount,password,status,idstaff))
            {
                MessageBox.Show("Add successfully!");
            }
            else
            {
                MessageBox.Show("Add failded!");
            }
        }
        private void LoadStaffToCb()
        {
            cbStaff.DataSource = BUSStaff.Instance.GetListStaff();
            
            cbStaff.DisplayMember = "nameStaff";
            cbStaff.ValueMember = "idStaff";
            
            /*cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            cbNamHoc.ValueMember = "MANAMHOC";*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nameaccount = txtNameAccount.Text;
            string password = txtPassword.Text;
            string status = txtStatus.Text;
            int idstaff = (cbStaff.SelectedItem as DTOStaff).IdStaff;
            AddAccount(nameaccount, password, status, idstaff);
            LoadAccounttodtgv();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridAccount.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    int idaccount;
                    idaccount = (int)GridAccount.Rows[GridAccount.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSAccount.Instance.DeleteAccount(idaccount))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccounttodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EditAccount(int idaccount, string nameaccount, string password, string status, int idstaff)
        {
            if (BUSAccount.Instance.EditAccount( idaccount,  nameaccount,  password,  status,  idstaff))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int idaccount= (int)GridAccount.Rows[GridAccount.SelectedRows[0].Index].Cells[1].Value;
            string nameaccount = txtNameAccount.Text;
            string password = txtPassword.Text;
            string status = txtStatus.Text;
          
              int idstaff = (cbStaff.SelectedItem as DTOStaff).IdStaff;
            EditAccount(idaccount, nameaccount, password, status, idstaff);
        }

        private void GridAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameAccount.Text= GridAccount.Rows[GridAccount.SelectedRows[0].Index].Cells[2].Value.ToString();
            txtPassword.Text= GridAccount.Rows[GridAccount.SelectedRows[0].Index].Cells[3].Value.ToString();
            txtStatus.Text= GridAccount.Rows[GridAccount.SelectedRows[0].Index].Cells[4].Value.ToString();
        }
        
    }
}
