using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project__Inheri_
{
    class HospitalEmployee
    {
        //fields
        protected string employeeName;
        protected int employeeNumber;
        protected string specialtyArea;
        public string department;
        public int amountPaid;

        //properties
        public string EmployeeName
        {
            get{ return this.EmployeeName; }
            //set { this.EmployeeName = value; }
        }
        public int EmployeeNumber
        {
            get { return this.EmployeeNumber; }
            //set { this.EmployeeNumber = value; }
        }
        public string SpecialtyAreas
        {
            get { return this.SpecialtyAreas; }
           // set { this.SpecialtyAreas = value; }
        }
        public string Department
        {
            get { return this.Department; }
           // set { this.Department = value; }
        }
        public int HoursLogged
        {
            get { return this.HoursLogged; }
            set { this.HoursLogged = value; }
        }

        //constructors
        public HospitalEmployee()
        {

        }

        public HospitalEmployee(string employeeName, int employeeNumber, string specialtyArea, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.department = department;
        }
       
        public virtual int Pay()
        {
            amountPaid += 30000;
            return Pay();
        }
    }
}
