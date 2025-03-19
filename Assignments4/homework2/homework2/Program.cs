namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(11, 22, 33);
            clock.alarmTime = new TimeSpan(11, 22, 40);
            clock.Tick += (s, e) => Console.WriteLine(e.Time.ToString()+"滴答");
            clock.Alarm += (s, e) => Console.WriteLine(e.Time.ToString()+"叮呤呤");
            clock.Run();
        }
    }
}
