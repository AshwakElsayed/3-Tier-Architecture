using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class ProductPicture
    {
        public int Id { get; set; }
        [Required]
        public string URL { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
