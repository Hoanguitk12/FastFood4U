using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALRevenue
    {
        private static DALRevenue instance;

        public static DALRevenue Instance
        {
            get { if (instance == null) instance = new DALRevenue(); return DALRevenue.instance; }
            private set { DALRevenue.instance = value; }
        }
        public List<DTORevenue> GetListRevenue()
        {
            List<DTORevenue> list = new List<DTORevenue>();
            string query = string.Format("SELECT * FROM TableStaff ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTORevenue revenue = new DTORevenue(item);
                list.Add(revenue);
            }
            return list;
        }
        public string getID(string datecheck)
        {
            string id = string.Empty;

            
            string query = string.Format("SELECT * FROM TableRevenue WHERE datecheck='{0}' ", datecheck);
           
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id = dr["idrevenue"].ToString();
                }
            }
            return id;
        }

        public DataTable GetRevenue()
        {
            string query = "SELECT * FROM TableRevenue ORDER BY total ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetRevenue(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTORevenue GetRevenueById(int idrevenue)
        {
            string query = string.Format("SELECT idrevenue,datecheck,total FROM TableRevenue WHERE idrevenue={0}", idrevenue);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTORevenue gv = new DTORevenue(dt.Rows[0]);
            return gv;
        }
        public DataTable GetRevenueByDate(string datecheck)
        {
            string query = string.Format("SELECT * FROM TableRevenue WHERE datecheck='{0}'", datecheck);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
           
            return dt;
        }
         
        public bool AddRevenue(string  datecheck, int total)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableRevenue(datecheck,total) VALUES (N'{0}',N'{1}')", datecheck, total);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool EditRevenue(int total ,string datecheck)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableRevenue SET total = N'{0}' WHERE datecheck = '{1}'", total,datecheck);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteRevenue(int idrevenue)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableRevenue WHERE idrevenue={0}", idrevenue);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

    }
}
