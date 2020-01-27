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

        T[] items = new T[4];
        T[] tempItems;

        int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        //INDEXER
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        //CONSTRUCTOR (ALL OF MY LISTS WILL HAVE..)
        public TimaList()
        {
            count = 0;
            capacity = 4;
            items = new T[Capacity];

        }

        //MEMBER METHOD (MY LIST CAN DO..)
        public void Add(T item)
        {
            //ADD ITEMS TO ARRAY
            items[Count] = item;

            //INCREMENT THE COUNT BY 1
            Count++;

            //LOOP THROUGH ARRAY
            for (int i = 0; i < Count; i++);

            //ONCE COUNT = CAPACITY, DUPLICATE 
            if(count == capacity)
            {
                capacity *= 2;
                tempItems = items;
                items = new T[capacity];

                for (int i = 0; i < tempItems.Length; i++)
                {
                    items[i] = tempItems[i];
                }
            }
        }
    }
}
