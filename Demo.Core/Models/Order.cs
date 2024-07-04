using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public int PaymentCardId { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
