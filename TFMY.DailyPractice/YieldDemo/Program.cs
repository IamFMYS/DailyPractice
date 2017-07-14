using System;
using System.Collections.Generic;
using System.Collections;

namespace YieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Circulation())
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable Circulation()
        {
            int index = 0;
            while (true)
            {
                if (list[index] % 2 == 0)
                    yield return list[index];
                index++;
                if (index >= list.Count)
                    yield break;
            }
        }
        private static List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }
}
