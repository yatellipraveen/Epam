using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Emp : IComparable<Emp>, IEquatable<Emp>
    {
        public String _name;
        private int _empID;

        public Emp(String name, int empID) 
        {
            this._empID = empID;
            this._name = name;
                
        }

        public void Display()
        {
            Console.WriteLine(_name+" "+_empID);
        }

        public int CompareTo(Emp other)
        {
            if (this._empID == other._empID) return 0;
            else if (this._empID < other._empID) return -1;
            else return 1;
            
        }


        public bool Equals(Emp other)
        {
            if (this._empID == other._empID) return true;
            else return false;
        }
    }
}
