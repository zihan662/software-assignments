using OrderLib.OrderLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderLib
{

    public class OrderService
    {


        public readonly List<Order> orders = new List<Order>();

        public OrderService()
        {
        }

        //添加订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new ApplicationException($"the order {order.Id} already exists!");
            }
            orders.Add(order);
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        //更新订单
        public void UpdateOrder(Order order)
        {
            int idx = orders.FindIndex(o => o.Id == order.Id);
            if (idx < 0)
            {
                throw new ApplicationException($"the order {order.Id} doesn't exist!");
            }
            orders.RemoveAt(idx);
            orders.Add(order);
            using (var context = new OrderContext())
            {
                context.Entry(order).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //根据Id查询订单
        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        //根据Id删除订单
        public void RemoveOrder(int orderId)
        {
            int idx = orders.FindIndex(o => o.Id == orderId);
            if (idx >= 0)
            {
                orders.RemoveAt(idx);
            }
            using (var context = new OrderContext())
            {
                var order = context.Orders
                    .Include("Details")  // 加载关联明细
                    .FirstOrDefault(o => o.Id == orderId);

                if (order != null)
                {
                    // 级联删除会自动处理关联的OrderDetails
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        //查询所有订单
        public List<Order> QueryAll()
        {
            return orders;
        }

        //根据客户名查询
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.Customer.Name == customerName)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        //根据货物名查询
        public List<Order> QueryByProductName(string productName)
        {
            var query = orders.Where(
              o => o.Details.Any(d => d.Product.Name == productName))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();

            /** 其他方法
            var query2 = orders.Where(
              o => o.Details.Exists(d => d.Product.Name == productName))
                .OrderBy(o => o.TotalPrice);

            var query3 = orders.Where(
             o => o.Details.Where(d => d.Product.Name == productName).Count()>0)
               .OrderBy(o => o.TotalPrice);

            var query4 = orders.Where(
             o => HasProduct(o,productName)) //写一个HasProduct方法，来检查o中是否包含名为productName的货物
               .OrderBy(o => o.TotalPrice); 
            **/
        }

        //根据总价查询
        public List<Order> QueryByTotalPrice(float totalPrice)
        {
            var query = orders.Where(o => o.TotalPrice >= totalPrice)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }


        //对orders中的数据进行排序
        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        //根据传入的条件进行查询
        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders.Where(o => condition(o)).OrderBy(o => o.TotalPrice);
        }

    }
}
