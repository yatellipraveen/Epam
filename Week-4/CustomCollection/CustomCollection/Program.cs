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
            ArrayCollection < String > ac= new ArrayCollection<String>();
            ac.Add("test");
            ac.Add("again test");
            ac.Add("again tefd");
            ac.Display();
        }
    }
}
