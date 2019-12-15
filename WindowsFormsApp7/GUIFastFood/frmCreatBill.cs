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

namespace WindowsFormsApp7.GUIFastFood
{
    public partial class frmCreatBill : Form
    {
        public frmCreatBill()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadItemtodtgv()
        {
            GridItem.DataSource = BUSItemOdered.Instance.GetItemOdered();


            GridItem.Columns[0].Visible = true;
            GridItem.Columns[1].Visible = false;//ẩn cột mã ;
            GridItem.Columns[2].HeaderText = "NameItemOdered";
            GridItem.Columns[3].HeaderText = "Cost";
            GridItem.Columns[4].HeaderText = "Numbers";
            GridItem.Columns[5].HeaderText = "Note";
            GridItem.Columns[6].HeaderText = "IdBill";
           


            /* gridDSGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
             gridDSGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
             */
        }

        private void frmCreatBill_Load(object sender, EventArgs e)
        {
            LoadItemtodtgv();
        }

        private void GridItem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridItem.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void AddItemOdered(string nameItem, int cost, int numbers, string note, int idbill)
        {
            if (BUSItemOdered.Instance.AddItemOdered(nameItem,cost, numbers, note, idbill))
            {
                MessageBox.Show("Add successfully!");
            }
            else
            {
                MessageBox.Show("Add failded!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GridItem.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    int idimport;
                    idimport = (int)GridItem.Rows[GridItem.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSImport.Instance.DeleteImport(idimport))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadItemtodtgv();
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

        private void btnGaCay_Click(object sender, EventArgs e)
        {
           
            string nameitem = btnGaCay.Text;
            int numbers = int.Parse(cbNumber.SelectedItem.ToString());
                
            int cost = int.Parse(btnGaCay.Tag.ToString())*numbers;
            string note = txtNote.Text;

        }
    }
}
