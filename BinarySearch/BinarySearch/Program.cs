using System;
using System.Security.Cryptography.X509Certificates;
using static System.Math;

namespace BinarySearch
{
    class Program
    {
        private int[] array = {1, 2, 2, 4, 5, 6, 7, 8, 9, 10, 11};
        private int lowIndex = 0;
        private int highIndex = 10;
        private int x;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           


            Console.WriteLine("Enter number to binary search: ");
            Program bs = new Program();
            bs.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Regular binary search:
            //Console.WriteLine("Binary Search returns: {0}", bs.BinarySearch(bs.lowIndex, bs.highIndex));

            // SampleQuestionNumber1:
            Console.WriteLine("Binary Search returns: {0}", bs.SampleQuestionNumber1(bs.lowIndex, bs.highIndex));
            
            Console.ReadKey();

        }


        public bool BinarySearch(int low, int high)
        {
            if (low > high)
            {
                return false;
            }
            else
            {
                int mid = (int)Floor(Convert.ToDouble((low + high) / 2));
                if (x == mid)
                {
                    return true;
                }
                else if (x < array[mid])
                {
                    return BinarySearch(low, mid - 1);
                }
                else return BinarySearch(mid + 1, high);
            }
        }

        /// <summary>
        /// Let A[1..n] be a sorted array of distinct integers. 
        /// Design an efficient divide and conquer algorithm to determine 
        /// if there exists an index i such that A[i]=i.
        /// </summary>
        public bool SampleQuestionNumber1(int low, int high)
        {
            if (low > high)
            {
                return false;
            }
            else
            {
                int mid = (int)Floor(Convert.ToDouble((low + high) / 2));
                if (x == array[x])
                {
                    return true;
                }
                else if (x < array[mid])
                {
                    return SampleQuestionNumber1(low, mid - 1);
                }
                else
                {
                    return SampleQuestionNumber1(mid + 1, high);
                }
            }
        }


    }
}
