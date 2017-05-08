using Microsoft.AspNetCore.Mvc;
using POSONE.Model;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Web.Controllers
{
    public class ArticuloController:Controller
    {
        public IActionResult Index()
        {
            UnitOfWork uOW = new UnitOfWork();
            var articulos = uOW.Articulo.GetTopSellingArticulo(20);
            return View(articulos);
        }
    }
}

