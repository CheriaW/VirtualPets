using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project__Inheri_
{
    class Surgeon : HospitalEmployee
    {
        //fields
        private string specialtyArea;
        bool operating;

        //property
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }
        public bool Operating
        {
            get { return this.operating; }
            set { this.operating = value; }
        }

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }
        //method
        public override int Pay()
        {
            amountPaid += 200000;
            return base.Pay();
        }
    }
}
