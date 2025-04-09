using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using System.Reflection.Emit;
namespace OrderLib
{
    // OrderContext.cs

    namespace OrderLib
    {
        [DbConfigurationType(typeof(MySqlEFConfiguration))]
        public class OrderContext : DbContext
        {
            
            public OrderContext() : base("OrderDatabase")
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<OrderContext>());
            }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderDetail> OrderDetails { get; set; }

        }
    }
}
