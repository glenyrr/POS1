using Microsoft.AspNetCore.Mvc;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Web.Controllers
{
     public class MarcaController: Controller
    {
        private IUnitOfWork uOW ;

        public MarcaController()
        {
            uOW = new UnitOfWork();
        }

      
        public IActionResult Index()
        {
            var model = uOW.Marca.GetAll();
            return View(model);
        }
    }
}