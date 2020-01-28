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
            //TimaList<int> list = new TimaList<int>();
            TimaList<int> odd = new TimaList<int>() { 1, 3, 5 };
            TimaList<int> even = new TimaList<int>() { 2, 4, 6 };
            TimaList<int> zipped = new TimaList<int>();
            zipped.Zip(odd, even);
           
           
        }
    }
}
