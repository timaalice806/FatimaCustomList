using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FatimasCustomList
{
    public class TimaList<T> : IEnumerable
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
            //CREATE NEW TEMPORARY ARRAY
            T[] temp = new T[capacity];
            //IF ELEMENT IS FOUND IN ARRAY
            bool isFound = false;
            //LOOP THROUGH ARRAY
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(items[i]))
                {
                    Count--;
                    isFound = true;
                }
                //IF ELEMENT IS FOUND IN ARRAY INCREMENT INDEX BY 1
                if (isFound == true)
                {
                    temp[i] = items[i + 1];
                }
                else
                {
                    temp[i] = items[i];
                }
            }
            //COPY ELEMENTS IN TEMP ARRAY OVER TO ITEMS ARRAY
            items = temp;
        }
        //PASS TWO LIST ARGUMENTS TO BE ZIPPED
        public static TimaList<T> Zip(TimaList<T> odd, TimaList<T> even)
        {
            //CREATE NEW ZIP LIST
            TimaList<T> zipped = new TimaList<T>();
            //ITERATE OVER BOTH LISTS ALTERNATING
            for (int i = 0; i < even.count; i++)
            { 
                    zipped.Add(odd[i]);
                    zipped.Add(even[i]);
            }
            return zipped;
        }
        //MAKE LIST ITERABLE
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
            yield return "End of list.";
        }
        public static TimaList<T> PlusOperator(TimaList<T> odd, TimaList<T> even)
        {
            TimaList<T> combined = new TimaList<T>();

            for (int i = 0; i < odd.count; i++)
            {
                combined.Add(odd[i]);
            }
            for (int i = 0; i < even.count; i++)
            {
                combined.Add(even[i]);
            }
            return combined;
        }
        public static TimaList<T> MinusOperator(TimaList<T> odd, TimaList<T> even)
        {
            TimaList<T> newlist = new TimaList<T>();

            for (int i = 0; i < odd.count; i++)
            {
                newlist.Remove(odd[i]);
            }
            for (int i = 0; i < even.count; i++)
            {
                newlist.Remove(even[i]);
            }
            return newlist;
        }
        public override string ToString()
        {
            StringBuilder stringMaker = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringMaker.Append(items[i]);
            }
            return stringMaker.ToString();
        }
    }
}
