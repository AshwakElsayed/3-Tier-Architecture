using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Governate> Governates { get; set; }

    }
}
