using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchDemo
{
    /// <summary>
    /// 二分查找（折半查找）
    /// </summary>
    public class BinarySearchDemo
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="arr">有序数组</param>
        /// <param name="key">查找目标</param>
        /// <returns></returns>
        public static int BianrySearch(int[] arr, int key)
        {
            int low = 0, height = arr.Length, mid = 0;
            while (low <= height)
            {
                mid = (low + height) / 2;
                if (arr[mid] == key) return mid;
                else if (arr[mid] > key) height = mid - 1;
                else low = mid + 1;
            }
            return 0;
        }
    }

    //分块查找（块间有序，第二个块中的关键字都大于第一个块中的最大关键字） 利用二分查找
    
}
