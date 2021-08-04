using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 8, 7, 8, 3, 5, 6, 4 };
            Solution2 sol = new Solution2();
            sol.QuickSort(arr, 0, arr.Length - 1);
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();

        }
    }


    public class Solution
    {
        public void QuickSort(int[] arr, int left, int right)
        {
            //如果right小於等於left則停止
            if (right <= left) 
                return;
            
            //取出以p為pivot的parition array, arr(left .. p-1) 小於 arr[p] , arr[p+1 .. right] 大於 arr[right]
            int p = Partition(arr, left, right);
            QuickSort(arr, left, p - 1);
            QuickSort(arr, p + 1, right);            
        }

        private static int Partition(int[] arr, int left, int right)
        {
            //一開始pivot = arr[right]
            // i = left, j = left
            // j 一路往右邊找比pivot小的元素，找到的話則swap(arr[i], arr[j]) 並把i++
            // 最後則swap arr[i]與arr[right]交換  (最後arr[i]肯定比arr[right]大，因為比pivot小的都被swap到i右邊了
            int pivot = arr[right];
            int i = left;
            for (int j = left; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }
            Swap(arr, i, right);
            return i;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }


    public class Solution2
    {
        public void QuickSort(int[] arr, int left, int right)
        {
            if (right <= left) return;
            int p = Partition(arr, left, right);
            QuickSort(arr, left, p - 1);
            QuickSort(arr, p + 1, right);
        }

        private static int Partition(int[]arr, int left, int right)
        {
            int pivot = right;
            int i = left;
            for (int j = left; j <= right; j++)
            {
                if (arr[j] < arr[pivot])
                {
                    Swap(arr, i, j);
                    i++;
                }
            }

            //current i's left is smaller than arr[pivot]
            Swap(arr, i, pivot);
            return i;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }




}
