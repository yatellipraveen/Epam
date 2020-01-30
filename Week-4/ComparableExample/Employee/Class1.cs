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

        /// <summary>
        /// Implementing ComapreTo method which helps to order the objects while sorting
        /// </summary>
        /// <param name="other"> the object to be compared to </param>
        /// <returns>return 1, -1, 0 depending on the order</returns>
        public int CompareTo(Emp other)
        {
            if (this._empID == other._empID) return 0;
            else if (this._empID < other._empID) return -1;
            else return 1;
            
        }

        /// <summary>
        /// Checks if two objects of type Emp are equal or not
        /// </summary>
        /// <param name="other">object to be compare to</param>
        /// <returns>returns true if both are equal otherwise returns false</returns>
        public bool Equals(Emp other)
        {
            if (this._empID == other._empID) return true;
            else return false;
        }
    }
}
