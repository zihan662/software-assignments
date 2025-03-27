using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManger
{
    public class Order
    {
        public int id {  get; set; }
        public string goodName {  get; set; }
        public string customer {  get; set; }
        public double price {  get; set; }
        public Order(int id, string goodName, string customer, double price)
        {
            this.id = id;
            this.goodName = goodName;
            this.customer = customer;
            this.price = price;
        }
        public Order(Order o)
        {
            this.id = o.id; 
            this.goodName = o.goodName;
            this.customer = o.customer;
            this.price = o.price;
        }
        public override bool Equals(object? obj)
        {
            Order o = obj as Order;
            return o!=null && o.id == this.id &&
                o.goodName == this.goodName &&
                o.customer == this.customer &&
                o.price == this.price;
        }
        public override string ToString()
        {
            return $"订单号：{id}  商品名称：{goodName}  " +
                $"客户名：{customer}  总金额：{price}  ";
        }
    }
}
