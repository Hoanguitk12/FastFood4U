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
    public class BUSStaff
    {
        private static BUSStaff instance;

        public static BUSStaff Instance
        {
            get { if (instance == null) instance = new BUSStaff(); return BUSStaff.instance; }
            private set {BUSStaff.instance = value; }
        }
        public List<DTOStaff> GetListStaff()
        {
            return DALStaff.Instance.GetListStaff();

        }
        public DataTable GetStaff()
        {
            return DALStaff.Instance.GetStaff();
        }
        public DataTable GetStaff(string query)
        {
            return DALStaff.Instance.GetStaff(query);
        }
        public DTOStaff GetStaffById(int idstaff)
        {
            return DALStaff.Instance.GetStaffById(idstaff);
        }
        public bool AddStaff(string namestaff, string birthday, string workday, string sex, string address, string phonenumber)
        {
            bool kq = DALStaff.Instance.AddStaff(namestaff, birthday,workday, sex, address, phonenumber);
            return kq;
        }
        public bool EditStaff(int idstaff, string namestaff, string birthday, string workday, string sex, string address, string phonenumber)
        {
            bool kq = DALStaff.Instance.EditStaff(idstaff,namestaff, birthday, workday, sex, address, phonenumber);
            return kq;
        }
        public bool DeleteStaff(int idstaff)
        {
            bool kq = DALStaff.Instance.DeleteStaff(idstaff);
            return kq;
        }
    }
}
