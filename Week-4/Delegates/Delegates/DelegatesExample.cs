using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MethodsForDelegates
    {
        public static void DisplayOne() 
        {
            Console.WriteLine("Delegate one called");
        }

        public static void DisplayTwo()
        {
            Console.WriteLine("Delegate Two called");
        }


    }

    class Student
    {
        private String _name;
        private int _studentID;

        public String Name => _name;
        public int SID => _studentID;

        public static Comparison<Student> comapreBynameDelegate = new Comparison<Student>(compareByName);
        public static Comparison<Student> compareByIdDelegate = new Comparison<Student>(compareById);

        public Student(String name,int sID)
        {
            _name = name;
            _studentID = sID;
        }

        private static int compareByName(Student s1, Student s2)
        {
            return s1._name.CompareTo(s2._name);
        }

        private static int compareById(Student s1, Student s2)
        {
            if (s1._studentID < s2._studentID) return -1;
            else if (s1._studentID > s2._studentID) return 1;
            else return 0;
        }
    }
    class DelegatesExample
    {
        private delegate void delegateHandler() ;
        
        
        static void Main(string[] args)
        {
            //Delegate to call function DisplayOne
            delegateHandler handle = new delegateHandler(MethodsForDelegates.DisplayOne);
            handle();
            //Delegate to call function DisplayTwo
            delegateHandler handleTwo = new delegateHandler(MethodsForDelegates.DisplayTwo);
            handleTwo();

            //Adding two delegates in one handle to inovke two functions with single handle
            handle = handle + handleTwo;
            handle();

            //Comparision Delegate
            Student s1 = new Student("Praveen", 10);
            Student s2 = new Student("Kumar", 2);
            Student s3 = new Student("Sachin ", 5);
            List<Student> studentList = new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);

            foreach (Student tempStudent in studentList)
            {
                Console.WriteLine(tempStudent.Name + " "+ tempStudent.SID);
            }

            studentList.Sort(Student.compareByIdDelegate);
            
            foreach(Student tempStudent in studentList)
            {
                Console.WriteLine(tempStudent.Name + " " + tempStudent.SID);
            }

            studentList.Sort(Student.comapreBynameDelegate);

            foreach (Student tempStudent in studentList)
            {
                Console.WriteLine(tempStudent.Name + " " + tempStudent.SID);
            }


        }
    }
}
