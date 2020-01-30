using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExample
{
    public class Emp 
    {
        public String _name;
        private int _empID;

        public Emp(String name, int empID)
        {
            this._empID = empID;
            this._name = name;

        }
    }

    public class Organization : IEnumerable
    {
        private Emp[] empArray = new Emp[10];
        private int currentIndex=0;

        /// <summary>
        /// Add Emp instance to the object
        /// </summary>
        /// <param name="employee">object of employee</param>
        public void Add(Emp employee)
        {
            if (currentIndex < 10)
            {
                empArray[currentIndex++] = employee;

            }
        }

        public void Display()
        {
            for (int i=0;i<currentIndex;i++)
            {
                Console.WriteLine(empArray[i]._name);
            }
        }

        /// <summary>
        /// GetEnumerator returns the enumerator to iterate this collection
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(empArray, currentIndex);
        }

        public class OrganizationEnumerator : IEnumerator
        {
            private Emp[] org;
            private int _currentIndex;
            private int _index;
            public OrganizationEnumerator(Emp[] empArray2, int currentIndex)
            {
                org = empArray2;
                _currentIndex = currentIndex;
                _index = -1;
            }
            public object Current => org[_index];

            /// <summary>
            /// If the array has elements it moves the pointer to next and returns true, otherwise returns false
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (_index < _currentIndex-1)
                {
                    _index++;
                    return true;
                }
                else return false;
                
            }

            /// <summary>
            /// Reset the pointer
            /// </summary>
            public void Reset()
            {
                _index = -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp employee1 = new Emp("Praveen", 12);
            Emp employee2 = new Emp("Ravi", 43);
            Organization org = new Organization();
            org.Add(employee1);
            org.Add(employee2);
            org.Display();

            foreach (Emp it in org)
            {
                Console.WriteLine(it._name);
            }
        }
    }
}
