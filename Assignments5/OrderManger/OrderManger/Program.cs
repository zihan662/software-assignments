namespace OrderManger
{
    public class Program
    {
        static void Show()
        {
            Console.WriteLine("请输入数字选项");
            Console.WriteLine("1,添加订单");
            Console.WriteLine("2,删除订单");
            Console.WriteLine("3，修改订单");
            Console.WriteLine("4，查询订单");
            Console.WriteLine("5，对订单排序");
            Console.WriteLine("6，退出");
        }
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            while (true)
            {
                Show();
                int select=int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:service.AddOrder();break;
                    case 2:try { service.DeleteOrder(); }
                        catch(Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    case 3:
                        try { service.ChangeOrder(); }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    case 4: service.Query();break;
                    case 5: service.SortOrders();break;
                    case 6: return;
                }
                Console.Clear();
            }
        }
    }
}
