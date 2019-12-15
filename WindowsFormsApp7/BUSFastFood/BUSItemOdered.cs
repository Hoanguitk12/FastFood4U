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
    public class BUSItemOdered
    {
        private static BUSItemOdered instance;

        public static BUSItemOdered Instance
        {
            get { if (instance == null) instance = new BUSItemOdered(); return BUSItemOdered.instance; }
            private set { BUSItemOdered.instance = value; }
        }
        public List<DTOItemOdered> GetListItemOdered()
        {
            return DALItemOdered.Instance.GetListItemOdered();
        }
        public DataTable GetItemOdered()
        {
            return DALItemOdered.Instance.GetItemOdered();
        }
        public DataTable GetItemOdered(string query)
        {
            return DALItemOdered.Instance.GetItemOdered(query);
        }
        public DTOItemOdered GetItemOderedById(int idItem)
        {
            return DALItemOdered.Instance.GetItemOderedById(idItem);
        }
        public bool AddItemOdered(string nameItem, int cost, int numbers, string note, int idbill)
        {
            bool kq = DALItemOdered.Instance.AddItemOdered(nameItem, cost, numbers, note, idbill);
            return kq;
        }
        public bool EditItemOdered(int idItem, string nameItem, int cost, int numbers, string note, int idbill)
        {
            bool kq = DALItemOdered.Instance.EditItemOdered(idItem, nameItem, cost, numbers, note, idbill);
            return kq;
        }
        public bool DeleteItemOdered(int idItem)
        {
            bool kq = DALItemOdered.Instance.DeleteItemOdered(idItem);
            return kq;

        }
    }
}
