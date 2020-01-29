using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace ComparableExample
{
    class SortByName : IComparer<Emp>
    {
        public int Compare(Emp emp1, Emp emp2)
        {
            return emp1._name.CompareTo(emp2._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            // Arrange
            List<Emp> employeeList = new List<Emp>();
            Emp employee1 = new Emp("Praveen",123);
            Emp employee2 = new Emp("Sachin", 12);
            Emp employee3 = new Emp("Jitender", 2000);
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            // IComparer Example, sorting by roll number
            foreach (Emp employee in employeeList) 
            {
                employee.Display();
            }
            employeeList.Sort();
            foreach (Emp employee in employeeList)
            {
                employee.Display();
            }

            //IComparer Example, sorting by name

            SortByName sortingObject = new SortByName();
            employeeList.Sort(sortingObject);

            foreach (Emp employee in employeeList)
            {
                employee.Display();
            }

            //IEquatable Example
            Emp employee4 = new Emp("Praveen",123);
            Console.WriteLine(employee4.Equals(employee1));
        }
    }
}
