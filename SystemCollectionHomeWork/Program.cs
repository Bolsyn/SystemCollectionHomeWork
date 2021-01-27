using System;
using System.Collections.Generic;

namespace SystemCollectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var list = new List<int>(10);
            int count = 10;
            for (int i =0; i < count; i++)
            {
                list.Add(rand.Next() % 90 + 10);
            }
            int max=0;
            int max2=0;

            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            for (int i = 0; i < count; i++)
            {
                if (list[i] < max && list[i] > max2)
                {
                    max2 = list[i];
                }
            }

            Console.WriteLine(max2);

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (i%2==0)
                {
                    sum += list[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
