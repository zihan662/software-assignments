using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{

    /**
     **/
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Index { get; set; } //序号
        [Required]
        public Product Product { get; set; }
        public String ProductName { get => Product != null ? this.Product.Name : ""; }

        public double UnitPrice { get => Product != null ? this.Product.Price : 0.0; }
        public int Quantity { get; set; }
        [NotMapped]
        public float TotalPrice
        {
            get => Product == null ? 0 : Product.Price * Quantity;
        }
        public int Id { get; set; }
        public Order Order { get; set; }

        public OrderDetail() { }

        public OrderDetail(int index,Product product, int quantity)
        {
            this.Index = index;
            this.Product = product;
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                   EqualityComparer<Product>.Default.Equals(Product, detail.Product);
        }

        public override int GetHashCode()
        {
            return 785010553 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }

        public override string ToString()
        {
            return $"OrderDetail:{Product},{Quantity}";
        }
    }
}
