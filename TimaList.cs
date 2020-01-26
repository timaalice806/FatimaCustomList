using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatimasCustomList
{
    public class TimaList<T>
    {
        //MEMBER VARIABLES (MY LIST HAS A..)

        //CREATE EMPTY GENERIC ARRAY
        T[] items = new T[Capacity]

        int count = 0;
        int capacity = 4;

        public TimaList()
        {
            items = new T[Capacity];

            {
                get { return items[i]; }
                set { items[i] = value; }
            }
        }
        //MEMBER METHOD (MY LIST CAN DO..)
        public void Add(T items)
        {
            //ADD ITEMS TO ARRAY
            items[Count] = item;

            //INCREMENT THE COUNT BY 1
            Count++

            //LOOP THROUGH ARRAY
            for (int i = 0; i < Count; i++);

            if(count == capacity)
            {
                capacity*= 2
            }
   
        }
    }
}
