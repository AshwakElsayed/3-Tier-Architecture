using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Governate Governate { get; set; }
        public int GovernateId { get; set; }
    }
}
