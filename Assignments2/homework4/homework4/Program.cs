namespace homework4
{
    class Solution
    {
        public bool isquit(int[][]matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            if(m == 0||n==0) { Console.WriteLine("empty matrix"); return false; }
            for(int i = m - 2; i >= 0; i--)
            {
                int a = i, b = 0;
                int c = matrix[a][b];
                while (a < m&&b<n)
                {
                    if (matrix[a][b] != c) { return false; }
                    a++;
                    b++;
                }
            }
            for (int j = 1; j < n; j++)
            {
                int a = 0, b = j;
                int c = matrix[a][b];
                while (a<m&&b < n)
                {
                    if (matrix[a][b] != c) { return false; }
                    a++;b++;
                }
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] =new int[]{ 1,2,3,4};
            matrix[1] = new int[] { 5,1,2,3 };
            matrix[2] = new int[] { 9,5,1,2 };
            Solution s=new Solution();
            Console.WriteLine(s.isquit(matrix));
        }
    }
}
