using Microsoft.EntityFrameworkCore;
using PruebaViewComponentPartialView.Models;

namespace PruebaViewComponentPartialView.Data
{
    public class ProductoContext: DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options)
            : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
