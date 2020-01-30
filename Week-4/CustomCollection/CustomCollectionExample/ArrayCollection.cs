using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionExample
{
    public class ArrayCollection<T> 
    {
        private static int sizeOfArray = 2;
        int currentSizeOfArray = -1;
        private T[] array = new T[sizeOfArray];

        /// <summary>
        /// Create new array if there is an overflow
        /// </summary>
        private void CreateNewArray()
        {            
            if (currentSizeOfArray == sizeOfArray-1)
            {
                //TODO: Refactor Again
                sizeOfArray = sizeOfArray * 2;
                var new_Array = new T[sizeOfArray];
                Array.Copy(array, new_Array, array.Length);
                array = new_Array;
            }
        }
        /// <summary>
        /// adds a new element to the collection
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            CreateNewArray();
            ++currentSizeOfArray;
            array[currentSizeOfArray] = data;
            

        }

        /// <summary>
        /// clear the colletion 
        /// </summary>
        public void Clear()
        {
            sizeOfArray = 2;
            array = new T[sizeOfArray];
            currentSizeOfArray = -1;
        }

        /// <summary>
        /// Check if the element is present is the collection or not and return true or false
        /// </summary>
        /// <param name="data"> the element to be checked in the collection</param>
        /// <returns>true if found else false</returns>
        public bool Contains(T data)
        {

            for (int i = 0; i <= currentSizeOfArray; i++)
            {
                 if (array[i].Equals(data)) return true;
            }
            return false;

        }
        /// <summary>
        /// Remove an element from the collection
        /// </summary>
        /// <param name="data">the element to be removed</param>
        public void Remove(T data)
        {
            if (!Contains(data)) throw new Exception(data + " does not exist in the collection");
            int elementIndex=0;
            for (int i = 0; i <= currentSizeOfArray; i++)
            {
                if (array[i].Equals(data))
                {
                    elementIndex = i;
                    break;
                }
                
            }
            for (int i = elementIndex; i < currentSizeOfArray-1; i++)
            {
                array[i] = array[i + 1];
            }
            currentSizeOfArray--;
        }

        /// <summary>
        /// Sorts the given collection
        /// </summary>
        public void Sort()
        {
            Array.Sort(array, 0, currentSizeOfArray);
        }


        public void Display()
        {
            for (int i = 0; i <= currentSizeOfArray; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
