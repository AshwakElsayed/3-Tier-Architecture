using Demo.Core.Interfaces.Repositories;
using Demo.Core.Models;
using Demo.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Implementation
{
    internal class ProductRepo : GenericRepo<Product>, IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
