using Microsoft.AspNetCore.Mvc;
using POSONE.Application.Services;
using POSONE.Model.Entities;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Web.Controllers
{
    public class CategoriaController: Controller
    {
        
        private IUnitOfWork uOW ;
        private AppService appService;
        public CategoriaController()
        {
            uOW = new UnitOfWork();
            appService = new AppService();
        }

        public IActionResult Index()
        {
            var model = uOW.Categoria.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
               var model = uOW.Categoria.Get(id);
               if (model ==null)
               {
                   return NotFound("Id no encontrado");
               }
               return View(model); 
        }

        public IActionResult Edit(int id)
        {
              var model = uOW.Categoria.Get(id);
               if (model ==null)
               {
                   return NotFound("Id no encontrado");
               }
               return View(model); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",categoria);
            }
            var categoriaEntity = uOW.Categoria.Get(categoria.Id);
            categoriaEntity.Nombre = categoria.Nombre;
            uOW.Complete();

            return RedirectToAction("Detail","Categoria", new {Id=categoria.Id});
        }

        

    }
}