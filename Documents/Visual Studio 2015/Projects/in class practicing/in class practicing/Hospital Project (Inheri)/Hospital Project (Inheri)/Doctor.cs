using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project__Inheri_
{
    class Doctor : HospitalEmployee
    {
        //fields
        private new string specialtyArea;

        //property
        public string SpecialtyArea
        {
            get { return this.SpecialtyArea; }
        }
        
        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

        //method
        public override int Pay()
        {
            amountPaid += 100000;
            return base.Pay();
        }
    }
}
