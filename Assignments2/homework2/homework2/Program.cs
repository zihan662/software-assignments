using System.Collections.Specialized;

namespace homework2
{
    class Solution
    {
        public bool HandleArray(int[]array,out int min,out int max,out double pingjun,out int sum)
        {
            min = int.MaxValue;max = int.MinValue;pingjun = 0;sum = 0;
            if (array.Length == 0) { Console.WriteLine("empty array");return false; }
            foreach(int i in array)
            {
                min = i < min ? i : min;
                max = i > max ? i : max;
                sum += i;
            }
            pingjun = (double)sum / array.Length;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 8, 4, 2 };
            Solution s= new Solution();
            int min, max, sum;
            double pingjun;
            if (s.HandleArray(array, out min, out max, out pingjun, out sum))
            {
                double np=Math.Round(pingjun, 3);
                Console.WriteLine($"{min} {max} {np} {sum}");
            }
        }
    }
}
