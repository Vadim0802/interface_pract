using System;

namespace Interface_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray X = new CustomArray(15);
            X.Add(5);
            X.Add(1);
            X.Add(1);
            X.Add(1);
            X.Add(1);
            X.Add(1);

            X.Remove(0);
            X.Remove(14);


        }
    }
}
