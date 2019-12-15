using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
    public class DTOItemOdered
    {
        private int idItem;
        private string nameItem;
        private int numbers;
        private int cost;
        private string note;
        private int idbill;

        public int IdItem { get => idItem; set => idItem = value; }
        public string NameItem { get => nameItem; set => nameItem = value; }
        public int Numbers { get => numbers; set => numbers = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Note { get => note; set => note = value; }
        public int Idbill { get => idbill; set => idbill = value; }
        public DTOItemOdered(int iditem,string nameitem,int numbers,int cost,string note,int idbill)
        {
            this.IdItem = iditem;
            this.NameItem = nameItem;
            this.Numbers = numbers;
            this.Cost = cost;
            this.Note = note;
            this.Idbill = idbill;
        }
        public DTOItemOdered(DataRow row)
        {
            this.IdItem = (int)row["idItem"];
            this.NameItem = row["nameItem"].ToString();
            this.Numbers = (int)row["numbers"];
            this.Cost = (int)row["cost"];
            this.Note = row["note"].ToString();
            this.Idbill = (int)row["idbill"];

        }
    }
}
