namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>list = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            //打印列表
            list.ForEach(d=>Console.Write(d+" "));
            int sum = 0;
            int Max=int.MinValue; int Min=int.MaxValue;
            list.ForEach(d => sum += d);
            list.ForEach(d => { Max = (d > Max) ? d : Max; });
            list.ForEach(d => { Min = (d < Min) ? d : Min; });
            Console.WriteLine($"Max: {Max}  Min:  {Min}  sum:  {sum}");
        }
    }
}
