using PruebaViewComponentPartialView.Data;
using PruebaViewComponentPartialView.Models;

namespace PruebaViewComponentPartialView.Repositories
{
    public class RepositoryProducto
    {
        private ProductoContext context;

        public RepositoryProducto(ProductoContext context)
        {
            this.context = context;
        }

        public List<Producto> GetProductos()
        {
            return this.context.Productos.ToList();
        }

        public Producto DetallesProducto(int idProducto)
        {
            return this.context.Productos.FirstOrDefault(x => x.IdInfoArte == idProducto);
        }
    }
}
