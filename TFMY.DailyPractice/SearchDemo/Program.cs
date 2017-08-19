using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 13, 19, 21, 37, 56, 64, 75, 80, 88, 92 };
            Console.WriteLine(BinarySearchDemo.BianrySearch(arr, 92));
            Console.ReadKey();
        }
    }
}
