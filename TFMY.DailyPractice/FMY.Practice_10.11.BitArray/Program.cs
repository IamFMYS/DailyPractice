using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * 需要处理的数字有许多位 可以使用BitArray BitVector32 结构
 * BitArray 可以重置大小 事先布置都大小，可以包含非常多的位
 * BitVector32 基于栈 比较快
*/
namespace FMY.Practice_10._11.BitArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bitArray1 = new BitArray(5);

            bitArray1.SetAll(true);
            BitArray bitArray2 = new BitArray(5);

            bitArray2.SetAll(false);
            BitArray and = bitArray1.And(bitArray2);
            BitArray or = bitArray1.Or(bitArray2);
            BitArray xor = bitArray1.Xor(bitArray2);

            List<BitArray> list = new List<BitArray>() { and, or, xor };
            foreach (var bitArr in list)
            {
                Console.WriteLine("******");
                foreach (bool item in bitArr)
                {
                    Console.WriteLine(item ? 1 : 0);
                }
            }
            Console.ReadKey();
        }
    }
}
