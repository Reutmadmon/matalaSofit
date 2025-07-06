using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Librarian : Employee

    {
        public Librarian(string name, string lastName, int id,String password, int age, int phoneNum,
                         string email, string photo,
                         int empId, bool onShift)
            : base(name, lastName, id,password, age, phoneNum, email, photo, empId, onShift)
        {
        }
        //send message to client


        public override string ToString()
        {
            return base.ToString() + $", On Shift: {onShift}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Librarian other)
                return base.Equals(other) && this.empId == other.empId;
            return false;
        }
    }
}
