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

namespace WindowsFormsApp7.GUIFastFood
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        private void LoadStafftodtgv()
        {
            GridStaff.DataSource = BUSStaff.Instance.GetStaff();


             GridStaff.Columns[0].Visible = true;
             GridStaff.Columns[1].Visible = false;//ẩn cột mã ;
              GridStaff.Columns[2].HeaderText = "NameStaff";
             GridStaff.Columns[3].HeaderText = "Birthday";
              GridStaff.Columns[4].HeaderText = "Workday";
              GridStaff.Columns[5].HeaderText = "Sex";
              GridStaff.Columns[6].HeaderText = "Address";
             GridStaff.Columns[7].HeaderText = "PhoneNumber";
         

             /* gridDSGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
              gridDSGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
              */
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadStafftodtgv();
        }

        private void GridStaff_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridStaff.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private string GetGioiTinh()
        {
            if (rbtNam.Checked == true)
                return rbtNam.Text;
            else if (rbtNu.Checked == true)
            {
                return rbtNu.Text;

            }
            else return rbtKhac.Text;
        }
        private void AddStaff(string namestaff,string birthday,string workday,string sex,string address,string phonenumber)
        {
            if (BUSStaff.Instance.AddStaff(namestaff, birthday, workday, sex, address, phonenumber))
            {
                MessageBox.Show("Add successfully!");
            }
            else
            {
                MessageBox.Show("Add failded!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string namestaff = txtNhanVien.Text;
            string birthday = dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy");
            string workday = dtpNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
            string sex = GetGioiTinh();
            string address = txtDiaChi.Text;
            string phonenumber = txtSDT.Text;
            AddStaff(namestaff, birthday, workday, sex, address, phonenumber);
          

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GridStaff.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    int idstaff;
                   idstaff = (int)GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSStaff.Instance.DeleteStaff(idstaff))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStafftodtgv();           
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
        private void EditStaff(int idstaff,string namestaff, string birthday, string workday, string sex, string address, string phonenumber)
        {
            if (BUSStaff.Instance.EditStaff(idstaff,namestaff,birthday,workday,sex,address,phonenumber))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string namestaff = txtNhanVien.Text;
            string birthday = dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy");
            string workday = dtpNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
            string sex = GetGioiTinh();
            string address = txtDiaChi.Text;
            string phonenumber = txtSDT.Text;
            int idstaff;
            idstaff = (int)GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[1].Value;
            EditStaff(idstaff, namestaff, birthday, workday, sex, address, phonenumber);
            LoadStafftodtgv();
            
        }

        private void GridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNhanVien.Text = GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[2].Value.ToString();
            dtpNgaySinh.Value= (DateTime)GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[3].Value;
            dtpNgayVaoLam.Value= (DateTime)GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[4].Value;
            if(GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[5].Value.ToString() == "Nam")
            {
                rbtNam.Checked = true;
            }
            else if(GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[5].Value.ToString() == "Nữ")
            {
                rbtNu.Checked = true;
            }
            else
            {
                rbtKhac.Checked = true;
            }
          txtDiaChi.Text = GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[6].Value.ToString();
            txtSDT.Text = GridStaff.Rows[GridStaff.SelectedRows[0].Index].Cells[7].Value.ToString();
            



        }
    }
}
