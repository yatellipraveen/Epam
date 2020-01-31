using System;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecializedCollections
{
    class SpecializedCollectionExample
    {
        static void Main(string[] args)
        {
            #region HybridDictionary
            HybridDictionary myHyDictionary = new HybridDictionary();
            myHyDictionary.Add("praveen",21);
            myHyDictionary.Add(21,23);
            myHyDictionary.Add("sachin",21);
            myHyDictionary.Add("hello",123);

            foreach ( DictionaryEntry obj  in myHyDictionary) Console.WriteLine(obj.Value);

            #endregion

            #region OrderedDictionary
            OrderedDictionary myOrDictionary = new OrderedDictionary();
            myOrDictionary.Add("Hello", 21);
            myOrDictionary.Add(21,"Praveen");

            foreach (var key in myOrDictionary.Keys) Console.WriteLine(myOrDictionary[key]);
            for (int i = 0; i < myOrDictionary.Count; i++) Console.WriteLine(myOrDictionary[i]);
            #endregion

            #region ListDictionary
            ListDictionary myLDict = new ListDictionary();
            myLDict.Add(12,12);
            myLDict.Add("praveen",12);
            myLDict.Add("hello",12);

            foreach (DictionaryEntry obj in myLDict) Console.WriteLine(obj.Value);

            #endregion

        }
    }
}
