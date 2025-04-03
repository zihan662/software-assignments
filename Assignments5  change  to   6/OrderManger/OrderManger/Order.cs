﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderManger
{

    /**
     **/
    public class Order : IComparable<Order>
    {
        public List<OrderDetail> details = new List<OrderDetail>();
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreateTime { get; set; }

        public float TotalPrice
        {
            get => Details.Sum(d => d.TotalPrice);
        }

        public List<OrderDetail> Details => details;

        public Order()
        {
            CreateTime = DateTime.Now;
        }

        public Order(int orderId, Customer customer, DateTime creatTime)
        {
            Id = orderId;
            Customer = customer;
            CreateTime = creatTime;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (Details.Contains(orderDetail))
            {
                throw new ApplicationException($"The product ({orderDetail.Product.Name}) already exists in order {Id}");
            }
            Details.Add(orderDetail);
        }

        public int CompareTo(Order other)
        {
            return (other == null) ? 1 : Id - other.Id;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public void RemoveDetails(int num)
        {
            Details.RemoveAt(num);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"orderId:{Id}, customer:({Customer})");
            Details.ForEach(detail => result.Append("\n\t" + detail));
            return result.ToString();
        }

    }
}
