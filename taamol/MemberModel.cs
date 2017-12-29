using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taamol
{

    class MemberModel
    {
        int member_id;
        string name;
        string family;
        int gender;
        DateTime dob;
        string melicode;
        string address;
        string phone;
        DateTime registration_date;
        DateTime expire_date;
        string mobile;
        int gymid;
        String gym_name;

        public int Member_id
        {
            get { return member_id; }
            set { member_id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gym_name
        {
            get { return gym_name; }
            set { gym_name = value; }
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Melicode
        {
            get { return melicode; }
            set { melicode = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public DateTime Registration_date
        {
            get { return registration_date; }
            set { registration_date = value; }
        }
        public DateTime Expire_date
        {
            get { return expire_date; }
            set { expire_date = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public int Gymid
        {
            get { return gymid; }
            set { gymid = value; }
        }

    }
}
