using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
    public class DTOImport
    {
        private int idImport;
        private DateTime dayImport;
        private string supplier;
        private string nameImport;
        private int numbers;
        private int unitPrice;
        private int idAccount;
        public DTOImport(int idimport, DateTime dayimport, string supplier,string nameimport,int numbers,int unitprice,int idaccount)
        {
            this.IdImport = idimport;
            this.DayImport = dayimport;
            this.Supplier = supplier;
            this.NameImport = nameimport;
            this.Numbers = numbers;
            this.UnitPrice = unitprice;
            this.IdAccount = idaccount;


        } 
        public DTOImport(DataRow row )
        {
            this.IdImport = (int)row["idimport"];
            this.DayImport = (DateTime)row["dayimport"];
            this.Supplier = row["supplier"].ToString();
            this.NameImport = row["nameimport"].ToString();
            this.Numbers = (int)row["numbers"];
            this.UnitPrice = (int)row["unitprice"];
            this.IdAccount = (int)row["idaccount"];
        }
       


        public int IdImport { get => idImport; set => idImport = value; }
        public DateTime DayImport { get => dayImport; set => dayImport = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public string NameImport { get => nameImport; set => nameImport = value; }
        public int Numbers { get => numbers; set => numbers = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int IdAccount { get => idAccount; set => idAccount = value; }
    }
}
