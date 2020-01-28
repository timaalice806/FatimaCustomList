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

            //ONCE COUNT = CAPACITY, DUPLICATE 
            if(count == capacity)
            {
                capacity *= 2;
                tempItems = items;
                items = new T[capacity];
                //LOOP THROUGH ARRAY
                for (int i = 0; i < Count; i++)
                {
                    items[i] = tempItems[i];
                }
            }
        }
        public void Remove(T item)
        {
            T[] temp = new T[capacity];
            bool isFound = false;
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(items[i]))
                {
                    Count--;
                    isFound = true;
                }
                if (isFound == true)
                {
                    temp[i] = items[i + 1];
                }
                else
                {
                    temp[i] = items[i];
                }
            }
            items = temp;
        }
        public void Zip()
        {
            TimaList<T> odd = new TimaList<T>();
            TimaList<T> even = new TimaList<T>();

            TimaList<T> zipped = new TimaList<T>();



        }
    }
}
