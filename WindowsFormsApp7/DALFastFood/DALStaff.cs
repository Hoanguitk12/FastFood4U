using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DTOFastFood;

namespace WindowsFormsApp7.DALFastFood
{
   public class DALStaff
    {
        private static DALStaff instance;

        public static DALStaff Instance {
            get 
            { if (instance == null) instance = new DALStaff(); return DALStaff.instance; }
            private set { DALStaff.instance = value; }
        }
        public List<DTOStaff> GetListStaff()
        {
            List<DTOStaff> list = new List<DTOStaff>();
            string query = string.Format("SELECT * FROM TableStaff ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTOStaff staff = new DTOStaff(item);
                list.Add(staff);
            }
            return list;
        }

        public DataTable GetStaff()
        {
            string query = "SELECT * FROM TableStaff ORDER BY namestaff";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetStaff(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DTOStaff GetStaffById(int idstaff)
        {
            string query = string.Format("SELECT idstaff,namestaff,birthday,workday,sex,address,phonenumber FROM TableStaff WHERE idstaff={0}", idstaff);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTOStaff gv = new DTOStaff(dt.Rows[0]);
            return gv;
        }
        public bool AddStaff(string namestaff,string birthday, string workday, string sex,string address, string phonenumber)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO TableStaff(namestaff,birthday,workday,sex,address,phonenumber) VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}','{5}')", namestaff, birthday, workday, sex, address, phonenumber);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool EditStaff(int idstaff,string namestaff, string birthday, string workday, string sex, string address, string phonenumber)
        {
            int kq = 0;
            string query = string.Format("UPDATE TableStaff SET namestaff = N'{0}', birthday = N'{1}', workday= '{2}', sex = N'{3}', address = N'{4}', phonenumber = N'{5}' WHERE idstaff= {6}", namestaff, birthday, workday, sex, address, phonenumber,idstaff);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool DeleteStaff(int idstaff)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM TableStaff WHERE idstaff={0}", idstaff);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

      
    }
}
