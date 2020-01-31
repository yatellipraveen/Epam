using System;
using System.Collections;


namespace CollectionscClassExamples
{
    /// <summary>
    /// Examples for all the Data Structures in Collections
    /// </summary>
    class Collections
    {
        static void Main(string[] args)
        {
            #region ArrayListExample
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(123);

            foreach (Object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            #endregion

            #region HashTableExample
            Hashtable hashTable = new Hashtable();
            hashTable.Add(123,"Hello");
            hashTable.Add("world", 342);

            foreach (DictionaryEntry obj in hashTable) Console.WriteLine(obj.Key + " "+ obj.Value);

            hashTable.Remove(123);
            foreach (DictionaryEntry obj in hashTable) Console.WriteLine(obj.Key + " " + obj.Value);
            #endregion

            #region QueueExample

            Queue myQue = new Queue();
            myQue.Enqueue("Praveen");
            myQue.Enqueue(123);
            myQue.Enqueue(24.5);

            foreach (Object obj in myQue) Console.WriteLine(obj);
            myQue.Dequeue();
            foreach (Object obj in myQue) Console.WriteLine(obj);
            #endregion

            #region StackExample

            Stack myStack = new Stack();
            myStack.Push("Stack Begins");
            myStack.Push("321");
            myStack.Push("Stack last object");
            foreach (Object obj in myStack) Console.WriteLine(obj);
            myStack.Pop();
            foreach (Object obj in myStack) Console.WriteLine(obj);
            #endregion
    
            #region SortedList

            SortedList mySL = new SortedList();
            mySL.Add(3,"Sorted List starts");
            mySL.Add(1,123);
            mySL.Add(2, "Sorted List Ends");
            foreach (DictionaryEntry obj in mySL )Console.WriteLine(obj.Key + " "+ obj.Value);
            #endregion

        }
    }
}
