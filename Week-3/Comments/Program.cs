using System;


namespace Task
{
    /// <summary>
    /// This class has fields to store student details and 
    /// methods to set marks and calculate average
    /// </summary>
    public class Student {
        private string name;
        private string unique_ID;
        private int sub1, sub2, sub3;

        /// <summary>
        /// This method sets the values of each subject
        /// </summary>
        /// <example>
        /// <code>
        /// student_object.set_marks(100,49,50);
        /// </code>
        /// </example>
        /// <param name="sub1">marks in subject 1</param>
        /// <param name="sub2">marks in subject 2</param>
        /// <param name="sub3">marks in subject 3</param>
        public void set_marks(int sub1,int sub2, int sub3) {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }

        /// <summary>
        /// This method calculates average of marks and return the average
        /// </summary>
        /// <returns>
        /// returns the average of three subject marks
        /// </returns>
        public float calulate_averge() {
            float avg=(this.sub1+this.sub2+this.sub3)/3f;
            return avg;
        }

        /// <summary>
        /// Constructor to initialize the name and unique_ID fields
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unique_ID"></param>
        public Student(string name, string unique_ID) {
            this.name = name;
            this.unique_ID = unique_ID;
        }
    }
    /// <summary>
    /// class for main program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main class
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Student s1 = new Student("Praveen", "560236");
            s1.set_marks(40, 20, 40);
            Console.WriteLine(s1.calulate_averge());
            
        }
    }
}