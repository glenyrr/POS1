using Microsoft.AspNetCore.Mvc;
using POSONE.Application.Services;
using POSONE.Model;
using POSONE.Model.Entities;
using POSONE.Model.UnitOfWorks;
using POSONE.Web.ViewModels;

namespace POSONE.Web.Controllers
{
    public class ArticuloController:Controller
    {
        private IUnitOfWork uOW ;
        private AppService appService;
        public ArticuloController()
        {
            uOW = new UnitOfWork();
            appService = new AppService();
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
        public IActionResult Create(ArticuloViewModel articuloViewModel)
        {

            if (!ModelState.IsValid)
            {
                articuloViewModel.Categorias = uOW.Categoria.GetAll();
                articuloViewModel.Tipos = uOW.Tipo.GetAll();
                articuloViewModel.Marcas = uOW.Marca.GetAll();
                articuloViewModel.Isvs = uOW.Isv.GetAll();
                articuloViewModel.UnidadesMedida = uOW.UnidadMedida.GetAll();
                return View("Create",articuloViewModel);
            }

            //Mapping the ViewModel with the Entity
            var articulo = new Articulo{
                Id = articuloViewModel.Id,
                Descripcion = articuloViewModel.Descripcion,
                DescripcionLarga = articuloViewModel.DescripcionLarga,
                MarcaId = articuloViewModel.MarcaId,
                CategoriaId = articuloViewModel.CategoriaId,
                TipoId = articuloViewModel.TipoId,
                Umid = articuloViewModel.Umid,
                IsvId = articuloViewModel.IsvId,
                IncluyeImpuesto = articuloViewModel.IncluyeImpuesto,
                CostoPromedio = articuloViewModel.CostoPromedio,
                PrecioVenta = articuloViewModel.PrecioVenta,
                Activo = articuloViewModel.Activo
            };
                   
            uOW.Articulo.Add(articulo);
            // Save Changes and return to index list
            uOW.Complete();
            return Redirect("Index"); 
        }

        public IActionResult Edit(string id)
        {
           if (string.IsNullOrEmpty(id))
           {
               return StatusCode(400);
           }

           // Recuperando el articulo
           var articulo = uOW.Articulo.Get(id);

           if (articulo == null)
           {
               return NotFound("No se encontro el Articulo");
           }

           // Mapeando el articulo al ViewModel
            var articuloViewModel = new ArticuloViewModel
            {
                Id = articulo.Id,
                Descripcion = articulo.Descripcion,
                DescripcionLarga = articulo.DescripcionLarga,
                MarcaId = articulo.MarcaId,
                CategoriaId = articulo.CategoriaId,
                TipoId = articulo.TipoId,
                Umid = articulo.Umid,
                IsvId = articulo.IsvId,
                IncluyeImpuesto = articulo.IncluyeImpuesto,
                CostoPromedio = articulo.CostoPromedio,
                PrecioVenta = articulo.PrecioVenta,
                Activo = articulo.Activo,
                Categorias = uOW.Categoria.GetAll(),
                Tipos = uOW.Tipo.GetAll(),
                Marcas = uOW.Marca.GetAll(),
                Isvs = uOW.Isv.GetAll(),
                UnidadesMedida = uOW.UnidadMedida.GetAll()
            };


            return View(articuloViewModel);
        
        }

           // Add a new Object via POST Request
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Edit(ArticuloViewModel articuloViewModel) 
         {
             if (!ModelState.IsValid)
            {
               return View("Edit",articuloViewModel);
            }
            
            // Recuperar el articulo
            var articulo = uOW.Articulo.Get(articuloViewModel.Id);

            // Mapear los campos del ViewModel al Articulo
            articulo.Descripcion = articuloViewModel.Descripcion;
            articulo.DescripcionLarga = articuloViewModel.DescripcionLarga;
            articulo.MarcaId = articuloViewModel.MarcaId;
            articulo.CategoriaId = articuloViewModel.CategoriaId;
            articulo.TipoId = articuloViewModel.TipoId;
            articulo.Umid = articuloViewModel.Umid;
            articulo.IsvId = articuloViewModel.IsvId;
            articulo.IncluyeImpuesto = articuloViewModel.IncluyeImpuesto;
            articulo.CostoPromedio = articuloViewModel.CostoPromedio;
            articulo.PrecioVenta = articuloViewModel.PrecioVenta;
            articulo.Activo = articuloViewModel.Activo;
            
            // Save Changes and return to index list
            uOW.Complete();
            return RedirectToAction("Detail",new {Id = articulo.Id}); 
        }

        public IActionResult Detail(string id)
        {
            var model = appService.GetArticuloAllIncluded(id);
            return View(model);
        }


        public IActionResult Delete(string id)
        {
           
            return Content( id + " Sorry!, We are Under Construction Here!");
        }
    }
}

