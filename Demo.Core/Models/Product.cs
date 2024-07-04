using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public float Price { get; set; }
        public float TotalRating { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public List<CartProduct> CartProducts { get; set; }
        public List<Review> Reviews { get; set; }
        public List<ProductPicture> ProductPictures { get; set; }

    }
}
