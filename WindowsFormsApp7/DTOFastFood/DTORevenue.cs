using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
    public class DTORevenue
    {
        private int idrevenue;
        private DateTime datecheck;
        private int total;

        public int Idrevenue { get => idrevenue; set => idrevenue = value; }
        public DateTime Datecheck { get => datecheck; set => datecheck = value; }
        public int Total { get => total; set => total = value; }

        public DTORevenue(int idrevenue,DateTime datecheck,int total)
        {
            this.Idrevenue = idrevenue;
            this.Datecheck = datecheck;
            this.Total = total;
        }
        public DTORevenue(DataRow row)
        {
            this.Idrevenue = (int)row["idrevenue"];
            this.Datecheck = (DateTime)row["datecheck"];
            this.Total = (int)row["total"];
        }
    }
}
