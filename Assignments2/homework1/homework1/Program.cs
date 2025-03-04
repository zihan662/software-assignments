namespace homework1
{
    class MySolution
    {
        bool IsSuNum(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int[]AllYinZi (int num,out int size)
        {
            if (num <= 1) { Console.WriteLine("number "+num+" doesn't care yinzi");
                size = 0;
                return new int[0]; }
            size = 0;
            int[] yinZi = new int[num];
            int i = 2;
            while (i <= num)
            {
                if (!IsSuNum(i))
                {
                    i++;
                    continue;
                }
                if (num % i == 0)
                {
                    yinZi[size++] = i;
                    num /= i;
                }
                else
                {
                    i++;
                }
            }
            return yinZi;
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a num to show its all yinzi");
            int num,size;
            if (!int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine("输入错误");
            }
            MySolution s= new MySolution();
            int[] yinzi = s.AllYinZi(num, out size);
            for(int i = 0; i < size; i++)
            {
                Console.Write(yinzi[i] + " ");
            }
        }
    }
}
