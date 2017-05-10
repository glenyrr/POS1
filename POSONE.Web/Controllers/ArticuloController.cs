using Microsoft.AspNetCore.Mvc;
using POSONE.Model;
using POSONE.Model.Entities;
using POSONE.Model.UnitOfWorks;
using POSONE.Web.ViewModels;

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


        public IActionResult Create()
        {
            var articuloViewModel = new ArticuloViewModel();
            articuloViewModel.Categorias = uOW.Categoria.GetAll();
            articuloViewModel.Tipos = uOW.Tipo.GetAll();
            articuloViewModel.Marcas = uOW.Marca.GetAll();
            articuloViewModel.Isvs = uOW.Isv.GetAll();
            articuloViewModel.UnidadesMedida = uOW.UnidadMedida.GetAll();


            return View(articuloViewModel);
        }

        // Add a new Object via POST Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Articulo articulo)
        {
            //Checking if the data is valid
            if (ModelState.IsValid)
            {
                   uOW.Articulo.Add(articulo);
                   // Save Changes and return to index list
                   uOW.Complete();
                   return Redirect("Index"); 
            }
            return View(articulo);
        }

        public IActionResult Edit(string id)
        {
           if (string.IsNullOrEmpty(id))
           {
               return StatusCode(400);
           }

           var model = uOW.Articulo.Get(id);

           if (model == null)
           {
               return NotFound("No se encontro el Articulo");
           }

            return View(model);
        
        }


        public IActionResult Detail(string id)
        {
            var model = uOW.Articulo.Get(id);
            return View(model);
        }


        public IActionResult Delete(string id)
        {
           
            return Content( id + " Sorry!, We are Under Construction Here!");
        }
    }
}

