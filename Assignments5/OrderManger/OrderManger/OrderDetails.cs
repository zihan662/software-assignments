using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OrderManger
{
    public class OrderDetails:Order
    {
        Order o;
        public int count { get; set; }
        public int goodId { get; set; }
        public double goodprice { get; set; }
        public OrderDetails(Order o,int count,int goodId,double goodprice) : base(o)
        {
            this.count = count;
            this.goodId = goodId;
            this.goodprice = goodprice;
        }
        public override bool Equals(object? obj)
        {
            OrderDetails other = obj as OrderDetails;
            return other!=null && other.count == this.count &&
                other.goodId == this.goodId &&
                other.goodprice == this.goodprice&&
                other.o.Equals(this.o);
        }
        public override string ToString()
        {
            return o.ToString() + 
                $"商品编号：{goodId}  数量：{count}  单价：{goodprice}";
        }
    }
}
