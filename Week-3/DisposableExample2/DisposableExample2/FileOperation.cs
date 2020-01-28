using System;
using System.IO;

namespace DisposableExample2
{
    public class FileOperation : IDisposable
    {

        private const string _path = @"C:\\Users\\Praveen_Yatelli\\Documents\\FileStreamExample\\Example.txt";
        private StreamWriter writerObject;
        /// <summary>
        /// Write Data to File
        /// </summary>
        /// <param name="data">Input data from user that is to be written in file</param>
        public void WriteToFile(String data)
        {
            writerObject = new StreamWriter(_path);
            writerObject.WriteLine(data);
            writerObject.Flush();
        }

        /// <summary>
        /// Dispose method closes the StreamWriter
        /// </summary>
        public void Dispose() 
        {
            Console.WriteLine("Dispose method called");
            writerObject.Close();
            // GC.SuppressFinalize() tells GC not to call the Destructor
            GC.SuppressFinalize(this);
        }

        // Finalize Implementation
        ~FileOperation()
        {
            Console.WriteLine("Destructor called");
            writerObject.Close();

        }


    }
}
