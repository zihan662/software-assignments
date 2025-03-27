using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManger
{
    public class OrderService
    {
        List<Order> orders;
        List<OrderDetails> details;
        public OrderService() {
            orders = new List<Order>();
            details = new List<OrderDetails>();
        }
        // 1,按订单号查找，2，按商品名查找，3，按用户名查找，4，按总金额查找
        public IEnumerable<Order> QueryByOrderId(int id) =>
           orders.Where(o => o.id == id).OrderBy(o => o.price);
        public IEnumerable<Order> QueryByGoodname(string goodname) =>
            orders.Where(o => o.goodName==goodname).OrderBy(o => o.price);
        public IEnumerable<Order> QueryByCustomer(string customer) =>
            orders.Where(o => o.customer == customer).OrderBy(o => o.price);
        public IEnumerable<Order> QueryByPrice(double price)=>
            orders.Where(o=>o.price==price).OrderBy(o => o.price);
        public void Query()
        {
            Console.WriteLine("请输入查询方式：" +
                "1,按订单号查找，2，按商品名查找，3，按用户名查找，4，按总金额查找");
            int select=int.Parse(Console.ReadLine());
            IEnumerable<Order> qorders;
            
            switch (select)
            {
                case 1: {
                        Console.WriteLine("请输入订单号");
                        int target = int.Parse(Console.ReadLine());
                        qorders = QueryByOrderId(target);
                        break; }
                case 2: {
                        Console.WriteLine("请输入商品名");
                        string target = Console.ReadLine();
                        qorders =QueryByGoodname(target);
                        break; }
                case 3: {
                        Console.WriteLine("请输入用户名");
                        string target = Console.ReadLine();
                        qorders = QueryByCustomer(target);
                        break; }
                case 4: {
                        Console.WriteLine("请输入总金额");
                        double target = double.Parse(Console.ReadLine());
                        qorders=QueryByPrice(target);
                        break; }
                default:
                    {
                        qorders = null;
                        Console.WriteLine("未定义查找类型");
                        break;
                    }
            }
            foreach (Order o in qorders)
            {
                Console.WriteLine(o.ToString());
            }

        }
        public void DeleteOrder()
        {
            Console.WriteLine("请输入要删除的订单id：");
            int orderId=int.Parse(Console.ReadLine());
            Order order = orders.FirstOrDefault(o => o.id == orderId);
            if (order == null)
                throw new ArgumentException($"Order {orderId} not found for deletion");
            orders.Remove(order);
        }
        public void AddOrder()
        {
            int id;
            string goodName;
            string customer;
            double price;
            int count;
            int goodId;
            double goodprice;
            Console.WriteLine("请输入订单号:");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入商品名称:");
            goodName= Console.ReadLine();
            Console.WriteLine("请输入客户名:");
            customer= Console.ReadLine();
            Console.WriteLine("请输入商品编号:");
            goodId=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入商品数量:");
            count=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入商品单价");
            goodprice=double.Parse(Console.ReadLine());
            price = count * goodprice;
            Order o = new Order(id, goodName, customer, price);
            OrderDetails od=new OrderDetails(o,count,goodId, goodprice);
            var nowOrders=QueryByOrderId(id);
            foreach(var no in nowOrders)
            {
                if (no.Equals(o))
                {
                    Console.WriteLine("重复的订单");
                    return;
                }
            }
            orders.Add(o);
            foreach(var nod in details)
            {
                if (nod.Equals(od))
                {
                    Console.WriteLine("重复的订单明细");
                    return;
                }
            }
            details.Add(od);
            Console.WriteLine("成功添加订单及订单明细");
        }
        public void ChangeOrder()
        {
            Console.WriteLine("请输入要修改的id");
            int id=int.Parse(Console.ReadLine());
            Order theorder = orders.FirstOrDefault(o => o.id == id);
            OrderDetails detail=details.FirstOrDefault(o => o.id == id);
            if (theorder == null)
                throw new ArgumentException($"不存在订单号为{id}的订单");
            if (detail == null)
                Console.WriteLine("该订单不存在明细，可以新建");
            string goodName;
            string customer;
            double price;
            int count;
            int goodId;
            double goodprice;
            Console.WriteLine("请输入修改后的商品名称:");
            goodName = Console.ReadLine();
            Console.WriteLine("请输入修改后的客户名:");
            customer = Console.ReadLine();
            Console.WriteLine("请输入修改后的商品编号:");
            goodId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入修改后的商品数量:");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入修改后的商品单价");
            goodprice = double.Parse(Console.ReadLine());
            price = count * goodprice;
            theorder.price = price;
            theorder.id = id;
            theorder.goodName = goodName;
            theorder.customer = customer;
            if(detail != null)
            {
                detail.goodprice = goodprice;
                detail.goodId= goodId;
                detail.count = count;
            }
            else
            {
                OrderDetails od=new OrderDetails(theorder,count,goodId, goodprice);
                details.Add(od);
            }
        }
        public void SortOrders() => orders = orders.OrderBy(o => o.id).ToList();
        public void SortOrders<TKey>(Func<Order, TKey> keySelector) =>
            orders = orders.OrderBy(keySelector).ToList();
    }
}
