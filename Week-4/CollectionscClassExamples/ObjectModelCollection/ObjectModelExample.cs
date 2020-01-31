using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModelCollection
{
    class ObjectModelExample
    {
        static void Main(string[] args)
        {
            #region ReadOnlyCollection
            List<int> myList = new List<int>();
            myList.Add(51);
            myList.Add(21);
            myList.Add(51);
            myList.Add(12);

            foreach (int value in myList) Console.WriteLine(value);

            ReadOnlyCollection<int> myReadOnlyCollection = new ReadOnlyCollection<int>(myList);

            foreach (int value in myReadOnlyCollection) Console.WriteLine(value);

            #endregion
        }
    }
}
