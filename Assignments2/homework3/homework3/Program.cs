namespace homework3
{
    class MySolution
    {
        public int[] AllSunNum(int r)
        {
            bool[] issu = new bool[r + 1];
            Array.Fill(issu, true);
            int size = 0;
            for(int i = 2; i <= r; i++)
            {
                if (!issu[i]) continue;
                size++;
                for(int k = i * 2; k <= r; k += i)
                {
                    issu[k] = false;
                }
            }
            int[] allSu = new int[size];
            int j = 0;
            for(int i = 2; i <=r; i++)
            {
                if (issu[i])
                {
                    allSu[j] = i;
                    j++;
                }
            }
            return allSu;
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            MySolution solution= new MySolution();
            int []allsun=solution.AllSunNum(100);
            foreach(int i in allsun)
            {
                Console.Write(i + " ");
            }
        }
    }
}
