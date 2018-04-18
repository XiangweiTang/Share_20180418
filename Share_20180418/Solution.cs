using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share_20180418
{
    partial class Solution
    {
        public Solution() { }
    }

    partial class Solution
    {
        public int MaxProfit(int[] Prices, int p)
        {
            int start = 2000;
            int end = -1;
            int profit = 0;
            for(int i = 0; i < Prices.Length; i++)
            {
                if (start > Prices[i])
                {
                    if (end > start + p)
                    {
                        Console.WriteLine(end + "\t" + start);
                        profit += end - start - p;
                        end = -1;
                    }
                    start = Prices[i];
                    continue;
                }
                if (Prices[i] > end)
                {
                    end = Prices[i];
                    continue;
                }
                if (end - Prices[i] - p > 0)
                {
                    Console.WriteLine(end + "\t" + start);
                    profit += end - start - p;
                    start = Prices[i];
                    end = -1;
                }
            }
            if (end - start - p > 0)
            {
                Console.WriteLine(end + "\t" + start);
                profit += end - start - p;
            }
            return profit;
        }
    }

    partial class Solution
    {
        public int KthInList(int[] array, int k)
        {
            int i = GetI(k)+1;
            return Select(array, 0, array.Length - 1, i);
        }

        private int Select(int[] array, int left, int right, int k)
        {
            if (left == right)
                return array[left];
            int pivot = left;
            pivot = Partition(array, left, right, pivot);
            if (k == pivot)
                return array[k];
            if (k < pivot)
                return Select(array, left, pivot - 1, k);
            return Select(array, pivot + 1, right, k);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            int p = array[pivot];
            Swap(array, pivot, right);

            int index = left;
            for(int i = left; i < right; i++)
            {
                if (array[i] > p)
                {
                    Swap(array, index, i);
                    index++;
                }
            }
            Swap(array, right, index);
            return index;
        }

        private void Swap(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }

        private int GetI(int k)
        {
            int i = 0;
            for (; ; i++)
            {
                if (i * (i + 1) / 2 < k && (i + 1) * (i + 2) / 2 >= k)
                    break;
            }
            return i;
        }
    }
}
