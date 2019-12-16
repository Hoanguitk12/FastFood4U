using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALImport
    {
        private static DALImport instance;
        public static DALImport Instance
        {
            get
            { if (instance == null) instance = new DALImport(); return DALImport.instance; }
            private set { DALImport.instance = value; }
        }
        public List<DTOImport> GetListImport()
        {
            List<DTOImport> list = new List<DTOImport>();
            string query = string.Format("SELECT * FROM TableImport ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTOImport import = new DTOImport(item);
                list.Add(import);
            }
            return list;
        }
        public int GetTongChi(string datecheck)
        {
            string query = string.Format("SELECT SUM(unitprice) FROM TableImport WHERE dayimport='{0}'", datecheck);
            int kq = (int)DataProvider.Instance.ExecuteScalar(query);
            return kq;
        }

        public DataTable GetImport()
        {
            string query = "SELECT * FROM TableImport ORDER BY nameimport";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetImport(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTOImport GetImportById(int idimport)
        {
            string query = string.Format("SELECT idimport,dayimport,supplier,nameimport,numbers,unitprice,idaccount FROM TableStaff WHERE idimport={0}", idimport);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTOImport gv = new DTOImport(dt.Rows[0]);
            return gv;
        }
        public bool AddImport(string dayimport, string supplier,string nameimport,int numbers,int unitprice, int idaccount)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableImport(dayimport,supplier,nameimport,numbers,unitprice,idaccount) VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}','{5}')",  dayimport, supplier, nameimport, numbers, unitprice, idaccount);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool EditImport(int idimport, string dayimport, string supplier, string nameimport, int numbers, int unitprice, int idaccount)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableImport SET dayimport = N'{0}', supplier = N'{1}', nameimport= '{2}', numbers= N'{3}', unitprice = N'{4}', idaccount = N'{5}' WHERE idimport= {6}", dayimport, supplier, nameimport, numbers, unitprice, idaccount,idimport);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteImport(int idimport)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableImport WHERE idimport={0}", idimport);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

    }
}
