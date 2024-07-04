using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class PaymentCard
    {
        public int Id { get; set; }
        public long CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
