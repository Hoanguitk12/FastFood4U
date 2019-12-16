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
    public class BUSImport
    {
        private static BUSImport instance;
        public static BUSImport Instance
        {
            get { if (instance == null) instance = new BUSImport(); return BUSImport.instance; }
            private set { BUSImport.instance = value; }
        }
        public List<DTOImport> GetListImport()
        {
            return DALImport.Instance.GetListImport();
        }
        public DataTable GetImport()
        {
            return DALImport.Instance.GetImport();
        }
        public DataTable GetImport(string query)
        {
            return DALImport.Instance.GetImport(query);
        }
        public DTOImport GetImportById(int idimport)
        {
            return DALImport.Instance.GetImportById(idimport);
        }
        public bool AddImport( string dayimport, string supplier, string nameimport, int numbers, int unitprice, int idaccount)
        {
            bool kq = DALImport.Instance.AddImport( dayimport, supplier, nameimport, numbers, unitprice, idaccount);
            return kq;
        }
        public bool EditImport(int idimport, string dayimport, string supplier, string nameimport, int numbers, int unitprice, int idaccount)
        {
            bool kq = DALImport.Instance.EditImport(idimport, dayimport, supplier, nameimport, numbers, unitprice, idaccount);
            return kq;
        }
        public bool DeleteImport(int idimport)
        {
            bool kq = DALImport.Instance.DeleteImport(idimport);
            return kq;
        }
        public int GetTongChi(string datecheck)
        {
            return DALImport.Instance.GetTongChi(datecheck);
        }
    }
}
