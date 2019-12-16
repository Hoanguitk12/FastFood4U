using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALAccount
    {
        private static DALAccount instance;

        public static DALAccount Instance { 
            get { if (instance == null) instance = new DALAccount(); return DALAccount.instance; } 
            private set { DALAccount.instance = value; } }

        public string GetQuyen(string id)
        {
            string quyen = string.Empty;
            string query = string.Format("SELECT status FROM TableAccount WHERE idaccount = {0}", id);
            quyen = DataProvider.Instance.ExecuteScalar(query).ToString();
            return quyen;
        }

        public string getID(string taikhoan, string matkhau)
        {
            string id = string.Empty;

           // byte[] temp = ASCIIEncoding.ASCII.GetBytes(matkhau);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
           // {
             //   hasPass += item;
           // }
            
            //string query = string.Format("SELECT * FROM NGUOIDUNG WHERE TAIKHOAN = '{0}' AND MATKHAU = '{1}'", taikhoan, hasPass);
            string query = string.Format("SELECT * FROM TableAccount WHERE Nameaccount='{0}' AND Password='{1}'", taikhoan, matkhau);
            //"SELECT * FROM dbo.TableAccount WHERE Nameaccount='{0}' AND Password='{1}'",taikhoan,hasPass)
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id = dr["Idaccount"].ToString();
                }
            }
            return id;
        }
     public List<DTOAccount> GetListAccount()
        {
            List<DTOAccount> list = new List<DTOAccount>();
            string query = string.Format("SELECT * FROM TableAccount ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTOAccount account = new DTOAccount(item);
                list.Add(account);
            }
            return list;
        }

        public DataTable GetAccount()
        {
            string query = "SELECT * FROM TableAccount ORDER BY nameaccount";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetAccount(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTOAccount GetAccountById(int idaccount)
        {
            string query = string.Format("SELECT idaccount,nameaccount,password,status,idstaff FROM TableAccount WHERE idaccount={0}", idaccount);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTOAccount gv = new DTOAccount(dt.Rows[0]);
            return gv;
        }
        public bool AddAccount(string nameaccount,string password,string status,int idstaff)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableAccount(nameaccount,password,status,idstaff) VALUES (N'{0}',N'{1}','{2}',N'{3}')", nameaccount, password,status,idstaff);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool EditAccount(int idaccount, string nameaccount, string password, string status, int idstaff)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableAccount SET nameaccount = N'{0}', password = N'{1}', status= '{2}', idstaff = N'{3}' WHERE idaccount= {4}",nameaccount,password,status,idstaff,idaccount );
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteAccount(int idaccount)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableAccount WHERE idaccount={0}", idaccount);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
    }
    
}
