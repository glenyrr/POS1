using Microsoft.AspNetCore.Mvc;
using POSONE.Model;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Web.Controllers
{
    public class ArticuloController:Controller
    {
        private IUnitOfWork uOW ;
        public ArticuloController()
        {
            uOW = new UnitOfWork();
        }
        public IActionResult Index()
        {
           
            var articulos = uOW.Articulo.GetTopSellingArticulo(20);
            return View(articulos);
        }

        public IActionResult Edit(string id)
        {
           
           var model = uOW.Articulo.Get(id);
            return View(model);
        
        }


        public IActionResult Detail(string id)
        {
            var model = uOW.Articulo.Get(id);
            return View(model);
        }


        public IActionResult Delete(string id)
        {
           
            return Content( id + "Sorry!, We are Under Construction Here!");
        }
    }
}

