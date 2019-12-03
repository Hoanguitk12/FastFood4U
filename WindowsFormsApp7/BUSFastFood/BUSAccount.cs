using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.DALFastFood;

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
        public string getID(string taikhoan, string matkhau)
        {
            return DALAccount.Instance.getID(taikhoan, matkhau);
        }
    }
}
