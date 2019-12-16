using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALBill
    {
        private static DALBill instance;

        public static DALBill Instance
        {
            get { if (instance == null) instance = new DALBill(); return DALBill.instance; }
            private set { DALBill.instance = value; }
        }
        public List<DTOBill> GetListBill()
        {
            List<DTOBill> list = new List<DTOBill>();
            string query = string.Format("SELECT * FROM TableImport ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTOBill bill = new DTOBill(item);
                list.Add(bill);
            }
            return list;
        }

        public DataTable GetBill()
        {
            string query = "SELECT * FROM TableBill ORDER BY idbill";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetBill(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTOBill GetBillById(int idbill)
        {
            string query = string.Format("SELECT idbill,daycheck,totalbill,total,exchange,idaccount FROM TableBill WHERE idbill={0}", idbill);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTOBill gv = new DTOBill(dt.Rows[0]);
            return gv;
        }
        public int GetIDBillMax()
        {
            string query = string.Format("SELECT MAX(idbill) FROM TableBill");
            int kq = (int)DataProvider.Instance.ExecuteScalar(query);
            return kq;
        }
        public int getTongThu(string datecheck)
        {
            string query = string.Format("SELECT SUM(totalbill) FROM TableBill WHERE datecheck='{0}'", datecheck);
            int kq = (int)DataProvider.Instance.ExecuteScalar(query);
            return kq;
        }


        public bool AddBill(string datecheck, int totalbill, int total, int exchange,int idaccount)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableBill(datecheck,totalbill,total,exchange,idaccount) VALUES ('{0}',N'{1}','{2}',N'{3}',N'{4}')", datecheck, totalbill, total, exchange, idaccount);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
      
        public bool EditBill(int idbill, string datecheck, int totalbill, int total, int exchange, int idaccount)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableBill SET datecheck = N'{0}', totalbill = N'{1}', total= '{2}',exchange= N'{3}', idaccount = N'{4}' WHERE idbill= {5}", datecheck, totalbill, total, exchange, idaccount, idbill);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteBill(int idbill)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableBill WHERE idbill={0}", idbill);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
            
        }
        

    }
}
