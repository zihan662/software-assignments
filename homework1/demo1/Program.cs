using System;
namespace demo1
{
    class YunSuan
    {
        public double Op(double x, double y, char op)
        {
            switch (op)
            {
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                    break;
                case '*':
                    return x * y;
                    break;
                case '/':
                    return x / y;
                    break;
                case '^':
                    return Math.Pow(x, y);
                    break;
                case '%':
                    return x % y;
                    break;
                default: return -1;
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two nums and an op(such as 1+2):");
            string s= Console.ReadLine();
            int i = 0;
            while (i < s.LongCount() && ((s[i] >= '0' && s[i] <= '9') || s[i] == '.'))
            {
                i++;
            }
            string a = s.Substring(0, i);
            string b = s.Substring(i + 1);
            double first=double.Parse(a);
            double second=double.Parse(b);
            YunSuan y=new YunSuan();
            double ans = y.Op(first, second, s[i]);
            double result = Math.Round(ans, 5);
            Console.WriteLine($"= {result}");
        }
    }
}
