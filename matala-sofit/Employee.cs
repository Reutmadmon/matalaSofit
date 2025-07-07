using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public abstract class Employee : Person
    {
        public int EmpId { get; set; }
        public Boolean OnShift { get; set; }
        protected Library library;

        public Employee(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo,
                        int empId, Library library)
            : base(name, lastName, id, password, age, phoneNum, email, photo)
        {
            this.EmpId = empId;
            this.OnShift = false;
            this.library = library;
        }

        public bool SignOnToShift()
        {
            if (!OnShift)
            {
                OnShift = true;
                return true;
            }
            return false;
        }

        public bool SignOutOfShift()
        {
            if (OnShift)
            {
                OnShift = false;
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return base.Equals(other) && this.EmpId == other.EmpId;
            return false;
        }

        public override string ToString()
        {
            return $"Employee ID: {EmpId}\nOn Shift: {(OnShift ? "Yes" : "No")}";
        }
    }
}
