using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DALFastFood;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.BUSFastFood
{
   public  class BUSRevenue
    {
        private static BUSRevenue instance;

        public static BUSRevenue Instance
        {
            get { if (instance == null) instance = new BUSRevenue(); return BUSRevenue.instance; }
            private set { BUSRevenue.instance = value; }
        }
        public List<DTORevenue> GetListRevenue()
        {
            return DALRevenue.Instance.GetListRevenue();
        }
        public string getID(string datecheck)
        {
            return DALRevenue.Instance.getID(datecheck);
        }
        public DataTable GetRevenue()
        {
            return DALRevenue.Instance.GetRevenue();
        }
        public DataTable GetRevenue(string query)
        {
            return DALRevenue.Instance.GetRevenue(query);
        }
        public DTORevenue GetRevenueById(int idrevenue)
        {
            return DALRevenue.Instance.GetRevenueById(idrevenue);
        }
        public bool AddRevenue(string datecheck, int total)
        {
            bool kq = DALRevenue.Instance.AddRevenue(datecheck, total);
            return kq;
        }
        public bool EditRevenue(int total, string datecheck)
        {
            bool kq = DALRevenue.Instance.EditRevenue(total, datecheck);
            return kq;
        }
        public bool DeleteRevenue(int idrevenue)
        {
            bool kq = DALRevenue.Instance.DeleteRevenue(idrevenue);
            return kq;
        }
        public DataTable GetRevenueByDate(string datecheck)
        {
            return DALRevenue.Instance.GetRevenueByDate(datecheck);
        }


    }
}
