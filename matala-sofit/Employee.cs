using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public abstract class Employee : Person
    {
        internal int empId { get; set; }
        internal Boolean onShift { get; set; }

        public Employee(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo,
                        int empId, bool onShift)
            :base(name, lastName, id, password, age, phoneNum, email, photo)
        {
            this.empId = empId;
            this.onShift = onShift;
            //inTime and outTime ask chat
        }

        public  bool signOnToShift()
        {
            if (!onShift)
            {
                onShift = true;
                return true;
            }
            return false;

        }
        public  bool signOutOfShift()
        {
            if (onShift)
            {
                onShift = false;
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return base.Equals(other) && this.empId == other.empId;
            return false;
        }

        public override string ToString()
        {
            return $"Employee ID: {empId}\nOn Shift: {(onShift ? "Yes" : "No")}";
        }

    }
}
