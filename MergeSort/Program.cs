using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            Solution2 sol = new Solution2();
            sol.MergeSort_Recursive(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }


    public class Solution
    {
        public void MergeSort_ButtomUp(int[] arr)
        {
            int[] orderedArr = new int[arr.Length];
            for (int i = 2; i<arr.Length * 2; i*=2)
            {
                for (int j = 0; j < (arr.Length + i - 1) / i; j++)
                {
                    //i: 2, 4, 6, 8, 10, ..., 2n-2
                    //j: 0, 1, 2, 3, ..., n+1
                    //j: 0, 1, 2, 3, ..., n+3
                    //j: 0, 1, 2, 3, ..., n+5
                    //j: ...
                    //j: 0, 1, 2, 3, ..., n+2n-1


                }
            }
        }

        public void MergeSort_Recursive(int[] arr)
        {
            int[] reg = new int[arr.Length];
            MergeSort_Recursive(arr, reg, 0, arr.Length - 1);
        }

        private void MergeSort_Recursive(int[] arr, int[] reg, int start, int end)
        {
            if (start >= end) return;

            int mid = start + (end - start) / 2;

            int start1 = start, end1 = mid;
            int start2 = mid + 1, end2 = end;
            MergeSort_Recursive(arr, reg, start1, end1);
            MergeSort_Recursive(arr, reg, start2, end2);

            int k = start;
            //當兩個指標都沒超過該陣列最大值時
            while (start1 <= end1 && start2 <= end2)
            {
                if (arr[start1] < arr[start2])
                {
                    reg[k] = arr[start1];
                    start1++;
                }
                else
                {
                    reg[k] = arr[start2];
                    start2++;
                }
                k++;
            }
            //如果start2走完 start1卻沒走完，則走完他
            while (start1 <= end1)
            {
                reg[k] = arr[start1];
                start1++;
                k++;
            }
            while (start2 <= end2)
            {
                reg[k] = arr[start2];
                start2++;
                k++;
            }
            for (k = start; k <= end; k++)
            {
                arr[k] = reg[k];
            }
        }
    }


    public class Solution2
    {

        public void MergeSort_Recursive(int[] arr)
        {
            int[] temp = new int[arr.Length];
            MergeSort(arr, temp, 0, arr.Length - 1);
        }

        public void MergeSort(int[] arr, int[] temp, int start, int end)
        {
            if (start >= end)
                return;

            int mid = start + (end - start) / 2;
            int start1 = start; int end1 = mid;
            int start2 = mid + 1; int end2 = end;
            MergeSort(arr, temp, start1, end1);
            MergeSort(arr, temp, start2, end2);

            int k = start;
            while (start1 <= end1 && start2 <= end2)
            {
                if (arr[start1] < arr[start2])
                {
                    temp[k] = arr[start1];
                    start1++;
                }
                else
                {
                    temp[k] = arr[start2];
                    start2++;
                }
                k++;
            }

            while (start1 <= end1)
            {
                temp[k] = arr[start1];
                start1++;
                k++;
            }

            while (start2 <= end2)
            {
                temp[k] = arr[start2];
                start2++;
                k++;
            }

            //copy array to arr
            for (int i=start; i<= end;  i++)
            {
                arr[i] = temp[i];
            }
            return;
        }



    }


}
