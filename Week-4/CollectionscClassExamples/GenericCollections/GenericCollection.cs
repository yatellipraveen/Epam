using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class GenericCollection
    {
        static void Main(string[] args)
        {
            //List example
            List<String> myList = new List<string>();
            myList.Add("List Begin");
            myList.Add("List");
            myList.Add("List Ends");
            foreach (Object obj in myList) Console.WriteLine(obj);
            Console.WriteLine(myList.Count);

            //Dictionary Example
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(2,"Dict Start");
            myDict.Add(1,"Dict");
            myDict.Add(10,"Dict end");
            //foreach (DictionaryEntry  in myList) Console.WriteLine(obj);
            foreach(var key in myDict.Keys)
            {
                Console.WriteLine(key + " , " + myDict[key]);
            }

            //HashSet Example
            HashSet<int> myHS = new HashSet<int>();
            myHS.Add(5);
            myHS.Add(10);
            myHS.Add(2);
            foreach (Object obj in myHS) Console.WriteLine(obj);

            //Queue Example
            Queue<String> myQ = new Queue<string>();
            myQ.Enqueue("First");
            myQ.Enqueue("Second");
            myQ.Enqueue("third");
            myQ.Dequeue();
            foreach (Object obj in myQ) Console.WriteLine(obj);

        }
    }
}
