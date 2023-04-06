using Microsoft.AspNetCore.Mvc;
using PruebaViewComponentPartialView.Models;
using PruebaViewComponentPartialView.Repositories;

namespace PruebaViewComponentPartialView.Controllers
{
    public class ProductoController : Controller
    {
        private RepositoryProducto repo;

        public ProductoController(RepositoryProducto repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Producto> productos = this.repo.GetProductos();
            return View(productos);
        }

        public IActionResult Detalles(int idproducto)
        {
            Producto producto = this.repo.DetallesProducto(idproducto);
            return PartialView("_Detalles", producto);
        }
    }
}
