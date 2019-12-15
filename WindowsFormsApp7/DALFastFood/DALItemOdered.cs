using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
    public class DALItemOdered
    {
        private static DALItemOdered instance;

        public static DALItemOdered Instance
        {
            get
            { if (instance == null) instance = new DALItemOdered(); return DALItemOdered.instance; }
            private set { DALItemOdered.instance = value; }
        }
        public List<DTOItemOdered> GetListItemOdered()
        {
            List<DTOItemOdered> list = new List<DTOItemOdered>();
            string query = string.Format("SELECT * FROM TableItemOdered ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTOItemOdered order = new DTOItemOdered(item);
                list.Add(order);
            }
            return list;
        }

        public DataTable GetItemOdered()
        {
            string query = "SELECT * FROM TableItemOdered ORDER BY nameItem";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetItemOdered(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTOItemOdered GetItemOderedById(int idItem)
        {
            string query = string.Format("SELECT idItem,nameItem,cost,numbers,note,idbill FROM TableItemOdered WHERE idItem={0}", idItem);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTOItemOdered gv = new DTOItemOdered(dt.Rows[0]);
            return gv;
        }
        public bool AddItemOdered(string nameItem, int cost,int numbers, string note,int idbill)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableItemOdered(nameItem,cost,numbers,note,idbill) VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}',)", nameItem, cost, numbers, note, idbill);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool EditItemOdered(int idItem,string  nameItem,int cost,int  numbers, string note,int idbill)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableItemOdered SET nameItem = N'{0}', cost = N'{1}', numbers= '{2}', note = N'{3}',idbill = N'{4}' WHERE idItem= {5}", nameItem, cost, numbers, note, idbill, idItem);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteItemOdered(int idItem)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableItemOdered WHERE idItemOdered={0}", idItem);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

    }
}
