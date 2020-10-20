using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interface_pract
{
    class CustomArray : IArray, IEnumerable
    {
        private int?[] arr;

        public CustomArray() : this(10) { }

        public CustomArray(int size)
        {
            arr = new int?[size];
        }

        public void Add(int newValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = newValue;
                    break;
                }
            }
        }

        public int? Find(int index)
        {
            int? elemIndex = arr[index];

            return elemIndex;
        }

        public void Remove(int index)
        {
            if (index > arr.Length)
                throw new ArgumentOutOfRangeException("Index превышает длину массива.");

            arr[index] = null;
        }

        public void Update(int index, int? newValue)
        {
            if (index > arr.Length)
                throw new ArgumentOutOfRangeException("Index превышает длину массива.");

            arr[index] = newValue;
        }

        public IEnumerator GetEnumerator() => arr.GetEnumerator();

        public int? this[int index]
        {
            get => Find(index);
            set => Update(index, value);
        }
    }
}
