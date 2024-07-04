using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId {  get; set; }
        public List<Address> Addresses { get; set; }
        public List<PaymentCard> PaymentCards { get; set; }
        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
