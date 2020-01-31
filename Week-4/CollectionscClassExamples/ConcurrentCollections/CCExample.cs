using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConcurrentCollections
{
    class ConCuStack
    {
        //private static ConcurrentStack<int> ccStack = new ConcurrentStack<int>();
        private static Stack<int> ccStack = new Stack<int>();
        public  static void AddOne()
        {
            for (int i = 0; i < 1000; i++) ccStack.Push(i);
        }
        public static void AddTwo()
        {
            for (int i = 0; i < 1000; i++) ccStack.Push(i);
        }

    }
    class CCExample
    {
        
       
        static void Main(string[] args)
        {
            //Blocking collection example
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(3);
            blockingCollection.Add(5);
            blockingCollection.Add(7);
            blockingCollection.Add(2);
           
            blockingCollection.Add(1); //programs gets blocked

            foreach (Object obj in blockingCollection) Console.WriteLine(obj);

            //ConcurrentStack
            Thread t1 = new Thread(ConCuStack.AddOne);
         
            Thread t2 = new Thread(ConCuStack.AddTwo);
            t1.Start();
            t2.Start();
            

        }
    }
}
