using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project__Inheri_
{
    class Receptionist : HospitalEmployee
    {
        //fields
        private string department;
        bool onThePhone;

        //properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public bool OnThePhone
        {
            get { return this.onThePhone; }
            set { this.onThePhone = value;  }
        }
        public Receptionist(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }

        //methods
        public override int Pay()
        {
            amountPaid += 40000;
            return base.Pay();
        }
    }
}
