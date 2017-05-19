using Microsoft.AspNetCore.Mvc;
using POSONE.Model.Entities;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Web.Controllers
{
    public class TipoController:Controller
    {
        private UnitOfWork uOW ;

        public TipoController()
        {
            uOW = new UnitOfWork();
        }

        public IActionResult Index()
        {
            var model = uOW.Tipo.GetAll();
            return View(model);
        }


        public IActionResult Create()
        {
            var model = new Tipo();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tipo tipo)
        {
            if (!ModelState.IsValid)
            {
                return View("Create",tipo);
            }

            var tipoEntity = new Tipo();
            tipoEntity.Nombre = tipo.Nombre;

            uOW.Tipo.Add(tipoEntity);

            uOW.Complete();

            return RedirectToAction("Index","Tipo");
        }

        
        public IActionResult Edit(int id)
        {
            var model = uOW.Tipo.Get(id);

             if (model == null)
            {
                return BadRequest("El Id del tipo de producto no fue encontrado");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tipo tipo)
        {

               if (!ModelState.IsValid)
                {
                    return View("Edit",tipo);
                }

              var tipoEntity = uOW.Tipo.Get(tipo.Id);

              tipoEntity.Nombre = tipo.Nombre;

              uOW.Complete();

            return RedirectToAction("Detail","Tipo",new {Id = tipo.Id});
        }

        public IActionResult Detail(int id)
        {
            var model = uOW.Tipo.Get(id);

            return View(model);
        }



    }
}