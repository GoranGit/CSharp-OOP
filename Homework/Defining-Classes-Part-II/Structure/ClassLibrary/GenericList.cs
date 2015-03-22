namespace Structure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    public class GenericList<T> where T : IComparable
    {
        private T[] elements;
        private int capacity;
        private int count;
        const int DefaultCapacity = 4;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.capacity = capacity;
        }
        public GenericList()
        {
            this.capacity = DefaultCapacity;
            this.elements = new T[DefaultCapacity];
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
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

        public void Add(T element)
        {
            if (Count >= capacity)
            {
                elements = AutoGrow();
                elements[Count] = element;
                this.Count++;
            }
            else
            {
                this.elements[Count] = element;
                this.Count++;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return this.elements[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    this.elements[index] = value;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                if (index == this.Count - 1)
                {
                    this.elements[index] = default(T);
                    this.Count--;
                }
                else
                {

                    for (int i = index; i < this.Count - 1; i++)
                    {
                        this.elements[i] = this.elements[i + 1];

                    }
                    this.elements[this.Count - 1] = default(T);
                    this.Count--;
                }
            }
            else
                throw new ArgumentOutOfRangeException("Index out of range!");
        }

        public void InsertAt(int index, T element)
        {
            if (index >= 0 && index < Count)
            {
                if (this.Count == this.capacity)
                {
                    elements = AutoGrow();
                }

                T[] elem = new T[this.capacity]; // because of  referent type of objects ( no constructor with type T so we can not create  new object of type T)
                for (int i = 0; i < index; i++)
                {
                    elem[i] = elements[i];
                }
                elem[index] = element;
                for (int i = index + 1; i <= Count; i++)
                {
                    elem[i] = elements[i - 1];
                }
                elements = elem;
                this.Count++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.capacity = DefaultCapacity;
            this.elements = new T[capacity];
        }

        private T[] AutoGrow()
        {
            this.capacity *= 2;
            T[] newElements = new T[capacity];
            this.elements.CopyTo(newElements, 0);
            return newElements;
        }

        public int IndexOf(T val)
        {
            for(int i=0;i<this.Count;i++)
            {
                if (elements[i].CompareTo(val) == 0)
                    return i;
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(elements[i].ToString());
                result.Append(" ");
            }
            return result.ToString();
        }

        public T Min()
        {
            if (Count > 0)
            {
                T min = this.elements[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this.elements[i].CompareTo(min) < 0)
                    {
                        min = this.elements[i];
                    }
                }
                return min;
            }
            else
                throw new ArgumentNullException("No elements in list!");
        }

        public T Max()
        {
            if (Count > 0)
            {
                T max = this.elements[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this.elements[i].CompareTo(max) > 0)
                    {
                        max = this.elements[i];
                    }
                }
                return max;
            }
            else
                throw new ArgumentNullException("No elements in list!");
        }
    }
}
