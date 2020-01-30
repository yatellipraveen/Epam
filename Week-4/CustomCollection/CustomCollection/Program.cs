using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCollectionExample;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            ArrayCollection < String > collection= new ArrayCollection<String>();
            
            //Add function
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");
            collection.Display();

            //Clear function clears the entire collection
            collection.Clear();

            Console.WriteLine("Called clear method and adding new data");
            
            collection.Add("Hello");
            collection.Add("World");
            collection.Add("Abcde");
            collection.Add("123");
            collection.Display();
            Console.WriteLine("Calling sort method");

            //Sorts the collection
            collection.Sort();
            collection.Display();
            Console.WriteLine("Remove string '123' ");

            //Remove an element from the collection
            collection.Remove("123");
         
            collection.Display();

     
        }
    }
}
