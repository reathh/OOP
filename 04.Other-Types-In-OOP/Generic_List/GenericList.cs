using System;
using System.Text;

namespace Generic_List
{
    [Version(1.00)]
    class GenericList<T> where T:IComparable<T>
    {
        const int defaultCapacity = 16;

        private int count = 0;
        private int lastIndex = 0;
        private T[] arr;
        public GenericList(int capacity = defaultCapacity)
        {
            arr = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.arr.Length;
            }
        }
        public int LastIndex
        {
            get
            {
                return this.lastIndex;
            }
            private set
            {
                this.lastIndex = value;
            }
        }

        public void Add(T element)
        {
            //Double array
            if (this.LastIndex >= this.Capacity)
            {
                DoubleArray();
            }
            //Just add the element

            this.arr[lastIndex] = element;
            this.Count++;
            this.LastIndex++;

        }
        public void AddAll(T[] element)
        {
            for (int i = 0; i < element.Length; i++)
            {
                if (this.LastIndex >= this.Capacity)
                {
                    DoubleArray();
                }

                T currElement = element[i];
                this.arr[lastIndex] = currElement;
                this.Count++;
                this.LastIndex++;
            }
        }
        public void DoubleArray()
        {
            T[] doubledArray = new T[this.Capacity * 2];
            for (int i = 0; i < this.Capacity; i++)
            {
                doubledArray[i] = this.arr[i];
            }
            this.arr = doubledArray;
        }
        public T this[int i]
        {
            get
            {
                return this.arr[i];
            }
            set
            {
                this.arr[i] = value;
            }
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }
            this.Count--;
        }
        public void InsertAt(int position, T element)
        {

            while (position > this.Capacity)
            {
                DoubleArray();
            }
            if (this.Count >= this.Capacity)
            {
                DoubleArray();
            }
            if (position > this.LastIndex)
            {
                this.arr[position] = element;
                this.LastIndex = position + 1;
            }
            else
            {
                T[] oldValuesArray = (T[])this.arr.Clone();
                for (int i = position; i < this.Count; i++)
                {
                    this.arr[i + 1] = oldValuesArray[i];
                }
                this.arr[position] = element;

                this.LastIndex++;
            }
            this.Count++;
        }
        public void Clear()
        {
            for (int i = 0; i < this.LastIndex; i++)
            {
                arr[i] = default(T);
            }
            this.Count = 0;
            this.LastIndex = 0;
        }
        public int Find(T value)
        {
            for (int i = 0; i < this.LastIndex; i++)
            {
                if (this.arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Exists(T value)
        {
            return Find(value) >= 0;
        }
        public T Max()
        {
            var max = this.arr[0];

            for (int i = 1; i < this.LastIndex; i++)
            {
                if (max.CompareTo(this.arr[i]) < 0)
                {
                    max = this.arr[i];
                }
            }

            return max;
        }
        public T Min()
        {
            var min = this.arr[0];

            for (int i = 1; i < this.LastIndex; i++)
            {
                if (min.CompareTo(this.arr[i]) > 0)
                {
                    min = this.arr[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < this.LastIndex; i++)
            {
                T element = this.arr[i];
                output.Append(element + ", ");
            }
            if (this.lastIndex != 0)
            {
                output.Remove(output.Length - 2, 2);
                return output.ToString();
            }
            else
            {
                return "List is Empty";
            }
        }


    }
}

