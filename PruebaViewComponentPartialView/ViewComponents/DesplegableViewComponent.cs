using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using PruebaViewComponentPartialView.Models;
using PruebaViewComponentPartialView.Repositories;

namespace PruebaViewComponentPartialView.ViewComponents
{
    public class DesplegableViewComponent: ViewComponent
    {
        private RepositoryProducto repo;

        public DesplegableViewComponent(RepositoryProducto repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Producto> productos = this.repo.GetProductos();
            return View(productos);
        }
    }
}
