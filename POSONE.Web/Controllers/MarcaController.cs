using Microsoft.AspNetCore.Mvc;
using POSONE.Model.Entities;
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

#region Create
        public IActionResult Create()
        {
            var model = new Marca();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Marca marca)
        {

            if(!ModelState.IsValid)
            {
                 return View("Create",marca);
            }

            var marcaEntity = new Marca{
                Id=marca.Id,
                Nombre=marca.Nombre
            };

            uOW.Marca.Add(marcaEntity);     

            uOW.Complete();       

            return Redirect("Index");
        }
    #endregion

#region Edit

    public IActionResult Edit(int id)
    {
      var  model = uOW.Marca.Get(id);

      // Checking if it found the Id

      if (model == null)
      {
          return BadRequest("El Id de la marca no fue encontrado");
      }
      return View(model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Marca marca)
    {
        if(!ModelState.IsValid)
        {
            return View("Edit","Marca");
        }

        var marcaEntity = uOW.Marca.Get(marca.Id);

        marcaEntity.Nombre = marca.Nombre;

        uOW.Complete();

        return RedirectToAction("Detail",new {Id = marca.Id}); 
    }

    #endregion



#region Detail

    public IActionResult Detail(int id)
    {
        var model = uOW.Marca.Get(id);

     if (model == null)
      {
          return BadRequest("El Id de la marca no fue encontrado");
      }

        return View(model);
    }

    #endregion




    }
}