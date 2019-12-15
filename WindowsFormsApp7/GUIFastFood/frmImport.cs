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
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadImportTodtgv()
        {
            GridImport.DataSource = BUSImport.Instance.GetImport();


            GridImport.Columns[0].Visible = true;
            GridImport.Columns[1].Visible = false;//ẩn cột mã ;
            GridImport.Columns[2].HeaderText = "DayImport";
            GridImport.Columns[3].HeaderText = "Supplier";
            GridImport.Columns[4].HeaderText = "NameImport";
            GridImport.Columns[5].HeaderText = "Numbers";
            GridImport.Columns[6].HeaderText = "UnitPrice";
            GridImport.Columns[7].HeaderText = "IdAccount";

        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            LoadImportTodtgv();
            LoadAccountToCb();
        }

        private void GridImport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridImport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void LoadAccountToCb()
        {
            cbAccount.DataSource = BUSAccount.Instance.GetListAccount();

            cbAccount.DisplayMember = "nameaccount";
            cbAccount.ValueMember = "idaccount";

          
        }
        private void AddImport(string dayimport, string supplier, string nameimport, int numbers, int unitprice, int idaccount)
        {
            if (BUSImport.Instance.AddImport(dayimport, supplier, nameimport,numbers, unitprice, idaccount))
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
            string dayimport= dtpDayImport.Value.Date.ToString("MM/dd/yyyy");
            string supplier = txtSupplier.Text;
            string nameimport = txtNameImport.Text;
            int numbers = int.Parse(txtNumber.Text);
            int unitprice = int.Parse(txtUnitPrice.Text);
            int idaccount = (cbAccount.SelectedItem as DTOAccount).Idaccount;
            AddImport(dayimport, supplier, nameimport, numbers, unitprice, idaccount);
            LoadImportTodtgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GridImport.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    int idimport;
                    idimport = (int)GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSImport.Instance.DeleteImport(idimport))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadImportTodtgv();
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
        private void EditImport(int idimport, string dayimport, string supplier, string nameimport, int numbers, int unitprice, int idaccount)
        {
            if (BUSImport.Instance.EditImport( idimport, dayimport, supplier, nameimport, numbers, unitprice, idaccount))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int idimport = (int)GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[1].Value;
            string dayimport = dtpDayImport.Value.Date.ToString("MM/dd/yyyy");
            string supplier = txtSupplier.Text;
            string nameimport = txtNameImport.Text;
            int numbers = int.Parse(txtNumber.Text);
            int unitprice = int.Parse(txtUnitPrice.Text);
            int idaccount = (cbAccount.SelectedItem as DTOAccount).Idaccount;
            EditImport(idimport, dayimport, supplier, nameimport, numbers, unitprice, idaccount);
            LoadImportTodtgv();
        }

        private void GridImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDayImport.Value = (DateTime)GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[2].Value;
            txtSupplier.Text = GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[3].Value.ToString();
            txtNameImport.Text = GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[4].Value.ToString();
            txtNumber.Text = GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[5].Value.ToString();
            txtUnitPrice.Text = GridImport.Rows[GridImport.SelectedRows[0].Index].Cells[6].Value.ToString();

        }
    }
}
