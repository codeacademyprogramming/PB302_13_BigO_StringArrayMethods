using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 3119;
            //bool isPrime = true;
            //int count = 0;

            //for (int i = 2; i*i <= num; i++)
            //{
            //    count++;
            //    if (num % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPrime);
            //Console.WriteLine(count);

            //int[] nums = { 12, 13, 14, 15, 20, 21, 22, 23, 24, 25, 40, 45, 67, 68, 69, 78, 70, 100, 101 };
            //int num = 12;
            //int index = -1;
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    count++;
            //    if (nums[i] == num)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            int[] nums = { 12, 13, 14, 15, 20, 21, 22, 23, 24, 25, 40, 45, 67, 68, 69, 78, 70, 100, 101 };
            int num = 67;
            int index = -1;
            int count = 0;

            int min = 0;
            int max = nums.Length - 1;

            for (int i = min; min <= max; i++)
            {
                count++;
                var mid = (min + max) / 2;

                if (nums[mid] == num)
                {
                    index = mid;
                    break;
                }
                else if (nums[mid]>num)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }



            Console.WriteLine(index);
            Console.WriteLine(count);
        }
    }
}
