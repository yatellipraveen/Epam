using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionExample
{
    public class ArrayCollection<T>
    {
        private static int count = 2;
        int currentIndex = 0;
        private T[] array = new T[count];

        private void CreateNewArray()
        {            
            if (currentIndex == count-1)
            {
                //TODO: Refactor Again
                count = count * 2;
                var new_Array = new T[count];
                Array.Copy(array, new_Array, array.Length);
                array = new_Array;
            }
        }
        public void Add(T data)
        {
            CreateNewArray();
            array[currentIndex] = data;
            ++currentIndex;

        }

        public void Clear()
        {
            count = 2;
            array = new T[count];
            currentIndex = 0;
        }

        public bool Contains(T data)
        {
            foreach (var ele in array)
            {
                if (ele.Equals(data)) return true;
            }
            return false;
            
        }

        public void InsertAt(T data, int index)
        { 
            
        }
        



        public void Display()
        {
            foreach (var data in array)
                Console.WriteLine(data);
        }

    }
}
