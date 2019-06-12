using System;
using System.Linq;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // int temp;
            // int index1 = 0;
            // int index2 = 0;
            // while (index2 < n)
            // {
            //     if (nums1[index1] == 0)
            //     {
            //         nums1[index1] = nums2[index2];
            //         index1++;
            //         index2++;
            //     }
            //     else if (nums1[index1] > nums2[index2])
            //     {
            //         temp = nums1[index1];
            //         nums1[index1] = nums2[index2];
            //         nums2[index2] = temp;

            //         index1++;
            //     }
            //     else if (nums1[index1] <= nums2[index2])
            //     {
            //         index1++;
            //     }
            // }

            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            Array.Sort(nums1);
        }
    }
}
