using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
   public class DTOAccount
    {
        private int idaccount;
        private string nameaccount;
        private string password;
        private string status;
        private int idstaff;
        public DTOAccount(int idaccount,string nameaccount,string password,string status,int idstaff)
            
        {
            this.Idaccount = idaccount;
            this.Nameaccount = nameaccount;
            this.Password = password;
            this.Status = status;
            this.Idstaff = Idstaff;
        }
        public DTOAccount(DataRow row)
        {
            this.Idaccount = (int)row["idaccount"];
            this.Nameaccount = row["nameaccount"].ToString();
            this.Password = row["password"].ToString();
            this.Status = row["status"].ToString();
            this.Idstaff = (int)row["idstaff"];
        }


        public int Idaccount { get => idaccount; set => idaccount = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        public int Idstaff { get => idstaff; set => idstaff = value; }
        public string Nameaccount { get => nameaccount; set => nameaccount = value; }
    }
}
