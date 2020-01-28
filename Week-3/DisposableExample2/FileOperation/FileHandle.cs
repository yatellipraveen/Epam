using System;
using System.IO;
using DisposableExample2;

namespace FileOperationn
{
    class FileHandle
    {
        static void Main(string[] args)
        {
            // Dispose Example
            FileOperation fileObject = new FileOperation();
            fileObject.WriteToFile("Hello World");
            //Call the Dispose method
            fileObject.Dispose();



            //GC Collect Example
            // creating a new object with same name so that the the previous object becomes obsolete
           // fileObject = new FileOperation();
            // Calls the Garbage Collector hence Destructor will be invoked if Dispose was not called before.
            // comment dispose method. else will throw exception
            GC.Collect();


            // Using block Example
            String path = "C:\\Users\\Praveen_Yatelli\\Documents\\FileStreamExample\\Example.txt";
            using (StreamWriter writerObject = new StreamWriter(path))
            {
                writerObject.WriteLine("Using block example");
                writerObject.Flush();
            }
            // Will throw Exception if using block is not used
            StreamWriter writerObject2 = new StreamWriter(path);
            writerObject2.Close();


          
        }
    }
}
