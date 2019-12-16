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
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
        }
        private void LoadRevenueTodtv()
        {
            Gridrevenue.DataSource = BUSRevenue.Instance.GetRevenue();


            Gridrevenue.Columns[0].Visible = true;
            Gridrevenue.Columns[1].Visible = false;//ẩn cột mã ;
            Gridrevenue.Columns[2].HeaderText = "DateCheck";
            Gridrevenue.Columns[3].HeaderText = "Total";
           

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            string datecheck = dtpDateCheck.Value.Date.ToString("MM/dd/yyyy");
            string id = DALRevenue.Instance.getID(datecheck);
            txtTongThu.Text = (DALBill.Instance.getTongThu(datecheck)).ToString();
            txtTongChi.Text = (DALImport.Instance.GetTongChi(datecheck)).ToString();
           int TongThu = int.Parse(txtTongThu.Text);
            int TongChi = int.Parse(txtTongChi.Text);
            int DoanhSo = TongThu - TongChi;
           
               txtDoanhSo.Text = DoanhSo.ToString();
            if (id != string.Empty)
            {
                DALRevenue.Instance.EditRevenue(DoanhSo, datecheck);
            }
            else
                DALRevenue.Instance.AddRevenue(datecheck, DoanhSo);
            LoadRevenueTodtv();
        }

        private void Gridrevenue_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Gridrevenue.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {
            LoadRevenueTodtv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Gridrevenue.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    int idrevenue;
                    idrevenue = (int)Gridrevenue.Rows[Gridrevenue.SelectedRows[0].Index].Cells[1].Value;
                    if (BUSRevenue.Instance.DeleteRevenue(idrevenue))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRevenueTodtv();
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
        private void Search()
        {
            string datecheck = dtpDateCheck.Value.Date.ToString("MM/dd/yyyy");

            DataTable dt = new DataTable();
            dt = BUSRevenue.Instance.GetRevenueByDate(datecheck);
            Gridrevenue.DataSource = dt;


            Gridrevenue.Columns[0].Visible = true;
            Gridrevenue.Columns[1].Visible = false;//ẩn cột mã ;
            Gridrevenue.Columns[2].HeaderText = "DateCheck";
            Gridrevenue.Columns[3].HeaderText = "Total";

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            txtDoanhSo.Text = "";
            txtTongChi.Text = "";
            txtTongThu.Text = "";
        }
    }
}
