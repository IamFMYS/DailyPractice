using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryDemo_10._8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * SortedDictionary<TKey,TValue> 是一个二叉搜索树
             * 其中元素根据键来排序
             * 键的类型必须实现IComparable<TKey> 接口
             * 如果键类型不能排序，可以创建一个实现了ICompare<TKey>接口的比较器（作为构造函数的参数）
             * SortedDictionary<TKey,TValue>（实现为一个字典） 和 SortedList<TKey,TValue>（基于数组的列表）  它们的功能类似
             * 
             * 区别：
             * SortedList 类使用的内存比SortedDictionary 类 少
             * SoredDictionary 类元素插入和删除操作比较快
             */             
        }
    }
}
