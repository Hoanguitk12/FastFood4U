using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DTOFastFood
{
   public  class DTOStaff
    {
        private int idStaff;
        private string nameStaff;
        private DateTime birthDay;
        private DateTime workDay;
        private string sex;
        private string address;
        private string phoneNumber;

        public int IdStaff { get => idStaff; set => idStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public DateTime WorkDay { get => workDay; set => workDay = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DTOStaff(int idStaff,string nameStaff, DateTime birthDay,DateTime workDay,string sex,string address,string phoneNumber)
        {
            this.IdStaff = idStaff;
            this.NameStaff = nameStaff;
            this.BirthDay = birthDay;
            this.WorkDay = workDay;
            this.Sex = sex;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
        public DTOStaff(DataRow row)
        {
            this.IdStaff = (int)row["idstaff"];
            this.NameStaff = row["namestaff"].ToString();
            this.BirthDay = (DateTime)row["birthday"];
            this.WorkDay = (DateTime)row["workday"];
            this.Sex = row["sex"].ToString();
            this.Address = row["address"].ToString();
            this.PhoneNumber = row["phonenumber"].ToString();


        }
    }
}
