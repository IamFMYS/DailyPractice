using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.DailyPractice_10._9.Set
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 集：包含不重复元素的集合
             * .NET Framework 包含两个集 HashSet<T>、SortedSet<T> 它们都实现ISet<T>
             * ISet<T> 提供可以创建合集、交集；给出集之间的超集、子集信息
             */
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            HashSet<int> setExt = new HashSet<int>();
            setExt.Add(3);
            setExt.Add(4);
            setExt.Add(5);
            setExt.Add(6);
            Console.WriteLine(set.Overlaps(setExt));
            set.ExceptWith(setExt);            
            Console.ReadKey();
        }
    }
}
