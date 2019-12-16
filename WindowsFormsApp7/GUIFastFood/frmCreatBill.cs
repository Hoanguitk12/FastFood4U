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
            //int idbill = DALBill.Instance.GetIDBillMax();

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
            LoadAccountToCb();
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

                    int iditem;
                    iditem = (int)GridItem.Rows[GridItem.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSItemOdered.Instance.DeleteItemOdered(iditem))
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
            int numbers = (int)(cbNumber.SelectedIndex+1);
         
            int cost = int.Parse(btnGaCay.Tag.ToString())*numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();

        }

        private void btnGaTruyenThong_Click(object sender, EventArgs e)
        {
            string nameitem = btnGaTruyenThong.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnGaTruyenThong.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnCanhGaCay_Click(object sender, EventArgs e)
        {
            string nameitem = btnCanhGaCay.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnCanhGaCay.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnCanhTruyenThong_Click(object sender, EventArgs e)
        {
            string nameitem = btnCanhTruyenThong.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnCanhTruyenThong.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnUcGaCay_Click(object sender, EventArgs e)
        {
            string nameitem = btnUcGaCay.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnUcGaCay.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnUcTruyenThong_Click(object sender, EventArgs e)
        {
            string nameitem = btnUcTruyenThong.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnUcTruyenThong.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btn34Cay_Click(object sender, EventArgs e)
        {
            string nameitem = btn34Cay.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btn34Cay.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btn34tt_Click(object sender, EventArgs e)
        {
            string nameitem = btn34tt.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btn34tt.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            string nameitem = btnBo.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnBo.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnGa_Click(object sender, EventArgs e)
        {
            string nameitem = btnGa.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnGa.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            string nameitem = btnSpecial.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnSpecial.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnKhoaiLon_Click(object sender, EventArgs e)
        {
            string nameitem = btnKhoaiLon.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnKhoaiLon.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnKhoaiNho_Click(object sender, EventArgs e)
        {
            string nameitem = btnKhoaiNho.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnKhoaiNho.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            string nameitem = btnSalad.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnSalad.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnBanhCuon_Click(object sender, EventArgs e)
        {
            string nameitem = btnBanhCuon.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnBanhCuon.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnKemCay_Click(object sender, EventArgs e)
        {
            string nameitem = btnKemCay.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnKemCay.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            string nameitem = btnCom.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnCom.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnSpa_Click(object sender, EventArgs e)
        {
            string nameitem = btnSpa.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnSpa.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            string nameitem = btnPizza.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnPizza.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnPepsiLon_Click(object sender, EventArgs e)
        {
            string nameitem = btnPepsiLon.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnPepsiLon.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnPepSiNho_Click(object sender, EventArgs e)
        {
            string nameitem = btnPepSiNho.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnPepSiNho.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnCocaLon_Click(object sender, EventArgs e)
        {
            string nameitem = btnCocaLon.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnCocaLon.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnSpriteLon_Click(object sender, EventArgs e)
        {
            string nameitem = btnSpriteLon.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnSpriteLon.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnSpriteNho_Click(object sender, EventArgs e)
        {
            string nameitem = btnSpriteNho.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnSpriteNho.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btnCocaNho_Click(object sender, EventArgs e)
        {
            string nameitem = btnCocaNho.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btnCocaNho.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btncb6_Click(object sender, EventArgs e)
        {
            string nameitem = btncb6.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btncb6.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btncb3_Click(object sender, EventArgs e)
        {
            string nameitem = btncb3.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btncb3.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btncbS_Click(object sender, EventArgs e)
        {
            string nameitem = btncbS.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btncbS.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }

        private void btncbL_Click(object sender, EventArgs e)
        {
            string nameitem = btncbL.Text;
            int numbers = (int)(cbNumber.SelectedIndex + 1);

            int cost = int.Parse(btncbL.Tag.ToString()) * numbers;
            string note = txtNote.Text;
            int idbill = DALBill.Instance.GetIDBillMax();
            DALItemOdered.Instance.AddItemOdered(nameitem, cost, numbers, note, idbill);
            LoadItemtodtgv();
        }
        //button thanh toan nam day nha
        private void LoadAccountToCb()
        {
            cbAccount.DataSource = BUSAccount.Instance.GetListAccount();

            cbAccount.DisplayMember = "nameaccount";
            cbAccount.ValueMember = "idaccount";

            /*cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            cbNamHoc.ValueMember = "MANAMHOC";*/
        }
        private void btnOdered_Click(object sender, EventArgs e)
        {
            int idbill = DALBill.Instance.GetIDBillMax();
            int totalbill = DALItemOdered.Instance.getTotalBill(idbill);
            try
            {
                int total = int.Parse(txtTotal.Text);
                int exchange = total - totalbill;
                string datecheck = dtpDateCheck.Value.ToString("MM/dd/yyyy");
                int idaccount = (cbAccount.SelectedItem as DTOAccount).Idaccount;
                BUSBill.Instance.EditBill(idbill, datecheck, totalbill, total, exchange, idaccount);
                txtExchange.Text = exchange.ToString();
                txtTotalBill.Text = totalbill.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn nhập tiền nhận");
                txtTotal.Focus();
            }
            



        }
    }
}
