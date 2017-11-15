using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project__Inheri_
{
    class Nurse : HospitalEmployee
    {
        //fields
        private string department;
        private int numberOfPatients;

        //properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }

        public Nurse(string employeeName, int employeeNumber, string department, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatients = numberOfPatients;
        }
        public override int Pay()
        {
            amountPaid += 80000;
            return base.Pay();
        }

    }
}
