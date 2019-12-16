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
    public class BUSBill
    {
        private static BUSBill instance;

       
        public static BUSBill Instance
        {
            get { if (instance == null) instance = new BUSBill(); return BUSBill.instance; }
            private set { BUSBill.instance = value; }
        }
        public List<DTOBill> GetListBill()
        {
            return DALBill.Instance.GetListBill();
        }
        public DataTable GetBill()
        {
            return DALBill.Instance.GetBill();
        }
        public DataTable GetBill(string query)
        {
            return DALBill.Instance.GetBill(query);
        }
       
        public DTOBill GetBillById(int idbill)
        {
            return DALBill.Instance.GetBillById(idbill);
        }
        public int GetIDBillMax()
        {
            return DALBill.Instance.GetIDBillMax();
        }
        public int getTongThu(string datecheck)
        {
            int kq = DALBill.Instance.getTongThu(datecheck);
            return kq;
        }
        public bool AddBill(string datecheck, int totalbill, int total, int exchange, int idaccount)
        {
            bool kq = DALBill.Instance.AddBill(datecheck, totalbill, total, exchange, idaccount);
            return kq;
        }
     
        public bool EditBill(int idbill, string datecheck, int totalbill, int total, int exchange, int idaccount)
        {
            bool kq = DALBill.Instance.EditBill(idbill, datecheck, totalbill, total, exchange, idaccount);
            return kq;
        }
        public bool DeleteBill(int idbill)
        {
            bool kq = DALBill.Instance.DeleteBill(idbill);
            return kq;
        }
    }
}
