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
   public class BUSAccount
    {
        private static BUSAccount instance;

        public static BUSAccount Instance
        {
            get { if (instance == null) instance = new BUSAccount(); return BUSAccount.instance; }
            private set { BUSAccount.instance = value; }
        }
        public string GetQuyen(string id)
        {
            return DALAccount.Instance.GetQuyen(id);
        }
        public List<DTOAccount> GetListAccount()
        {
            return DALAccount.Instance.GetListAccount();
        }
        public string getID(string taikhoan, string matkhau)
        {
            return DALAccount.Instance.getID(taikhoan, matkhau);
        }
        public DataTable GetAccount()
        {
            return DALAccount.Instance.GetAccount();

        }
        public DataTable GetAccount(string query)
        {
            return DALAccount.Instance.GetAccount(query);
        }
        public DTOAccount GetAccountById(int idaccount)
        {
            return DALAccount.Instance.GetAccountById(idaccount);
        }
        public bool AddAccount(string nameaccount, string password, string status, int idstaff)
        {
            bool kq = DALAccount.Instance.AddAccount( nameaccount,  password,  status,  idstaff);
            return kq;
        }
        public bool EditAccount(int idaccount, string nameaccount, string password, string status, int idstaff)
        {
            bool kq = DALAccount.Instance.EditAccount(idaccount, nameaccount, password, status, idstaff);
            return kq;
        }
        public bool DeleteAccount(int idaccount)
        {
            bool kq = DALAccount.Instance.DeleteAccount(idaccount);
            return kq;
        }
    }
}
