using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatimasCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            TimaList<int> list = new TimaList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Remove(2);
        }
    }
}
