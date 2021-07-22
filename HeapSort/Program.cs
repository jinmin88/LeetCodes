using System;

namespace HeapSortr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            Solution2 sol = new Solution2();
            sol.HeapSort(arr);

            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        
        public void HeapSort(int[] arr)
        {
            //Max-Heap : A[Parent[i]] >= A[i]
            int heapSize = arr.Length;
            BuildMaxHeap(arr, heapSize);
            for (int i=arr.Length-1; i>=1; i--)
            {
                //swap max-heap from head to tail
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapSize--;
                MaxHeapify(arr, 0, heapSize);
            }
        }
        

        public void BuildMaxHeap(int[] arr, int heapSize)
        {
            for (int i = ((heapSize + 1) / 2)-1; i>=0; i--)
            {
                MaxHeapify(arr, i, heapSize);
            }
        }

        /// <summary>
        /// 找出以i為root的Max heap
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="heapSize"></param>
        private void MaxHeapify(int[] arr, int i, int heapSize)
        {
            int l = Left(i);
            int r = Right(i);

            int largestIdx;
            if (l <= heapSize - 1 && arr[l] > arr[i])
            {
                largestIdx = l;
            }
            else
            {
                largestIdx = i;
            }
            if (r <= heapSize - 1 && arr[r] > arr[largestIdx])
            {
                largestIdx = r;
            }

            if (largestIdx != i)
            {
                int temp = arr[i];
                arr[i] = arr[largestIdx];
                arr[largestIdx] = temp;
                MaxHeapify(arr, largestIdx, heapSize);
            }
        }

        private int Parent(int i)
        {
            return (i + 1) / 2 - 1;
        }

        private int Left(int i)
        {
            return 2 * (i + 1) - 1;
        }

        private int Right(int i)
        {
            return 2 * (i + 1);
        }

    }

    public class Solution2
    {
        public void HeapSort(int[] arr)
        {
            int heapSize = arr.Length;
            BuildMaxHeap(arr, heapSize);
            for (int i = arr.Length-1; i>=1; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapSize--;
                MaxHeapify(arr, 0, heapSize);
            }


        }

        public void BuildMaxHeap(int[] arr, int heapSize)
        {
            for (int i = ((heapSize + 1) / 2) + 1; i>=0; i--)
            {
                MaxHeapify(arr, i, heapSize);
            }
        }

        private void MaxHeapify(int[] arr, int i, int heapSize)
        {
            int left = Left(i);
            int right = Right(i);

            int largestIndex;
            if (left <= heapSize-1 && arr[left] > arr[i])
            {
                largestIndex = left;
            }
            else
            {
                largestIndex = i;
            }
            if (right <= heapSize - 1 && arr[right] > arr[largestIndex])
            {
                largestIndex = right;
            }
            if (largestIndex != i)
            {
                var temp = arr[i];
                arr[i] = arr[largestIndex];
                arr[largestIndex] = temp;
                MaxHeapify(arr, largestIndex, heapSize);
            }
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public int Left(int i)
        {
            return 2 * i + 1;
        }

        public int Right(int i)
        {
            return 2 * i + 2;
        }
    }

}
