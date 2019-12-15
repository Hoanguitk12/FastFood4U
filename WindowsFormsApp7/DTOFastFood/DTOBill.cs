using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
   public  class DTOBill
    {
        private int idbill;
        private DateTime datecheck;
        private int totalbill;
        private int total;
        private int exchange;
        private int idaccount;

        public int Idbill { get => idbill; set => idbill = value; }
        public DateTime Datecheck { get => datecheck; set => datecheck = value; }
        public int Totalbill { get => totalbill; set => totalbill = value; }
        public int Total { get => total; set => total = value; }
        public int Exchange { get => exchange; set => exchange = value; }
        public int Idaccount { get => idaccount; set => idaccount = value; }
        public DTOBill(int idbill, DateTime datecheck, int totalbill, int total,int exchange,int idaccount)
        {
            this.Idbill = idbill;
            this.Datecheck = datecheck;
            this.Totalbill = totalbill;
            this.Total = total;
            this.Exchange = exchange;
            this.Idaccount = idaccount;
        }
        public DTOBill(DataRow row)
        {
            this.Idbill = (int)row["idbill"];
            this.Datecheck = (DateTime)row["datecheck"];
            this.Totalbill = (int)row["totalbill"];
            this.Total = (int)row["total"];
            this.Exchange = (int)row["exchange"];
            this.Idaccount = (int)row["idaccount"];
        }
       
    }
}
