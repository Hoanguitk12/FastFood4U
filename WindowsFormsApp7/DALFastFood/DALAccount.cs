using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALAccount
    {
        private static DALAccount instance;

        public static DALAccount Instance { 
            get { if (instance == null) instance = new DALAccount(); return DALAccount.instance; } 
            private set { DALAccount.instance = value; } }



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
    }
    
}
