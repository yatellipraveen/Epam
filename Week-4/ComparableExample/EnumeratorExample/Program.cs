using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExample
{
    class Emp : IEnumerable<Emp>
    {
        public String name;

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Emp> IEnumerable<Emp>.GetEnumerator()
        {
            return (IEnumerator<Emp>)GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
