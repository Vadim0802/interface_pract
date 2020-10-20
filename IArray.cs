using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_pract
{
    interface IArray
    {
        void Add(int newValue);
        int? Find(int index);
        void Remove(int index);
        void Update(int index, int? newValue);
    }
}
