using POSONE.Application.DTOs;
using POSONE.Model.UnitOfWorks;

namespace POSONE.Application.Services
{
    public class AppService
    {
         private IUnitOfWork uOW ;
        public AppService()
        {
                uOW = new UnitOfWork();
        }

        public ArticuloDTO GetArticuloAllIncluded(string id)
        {
                var articulo = uOW.Articulo.GetArticuloAllIncluded(id);
                var articuloDTO = new ArticuloDTO{
                    Id = articulo.Id,
                    Descripcion = articulo.Descripcion,
                    DescripcionLarga = articulo.DescripcionLarga,
                    Marca = articulo.Marca.Nombre,
                    Categoria = articulo.Categoria.Nombre,
                    Tipo = articulo.Tipo.Nombre,
                    Um = articulo.Um.Codigo,
                    Isv = articulo.Isv.Nombre,
                    IncluyeImpuesto = articulo.IncluyeImpuesto,
                    CostoPromedio = articulo.CostoPromedio,
                    PrecioVenta = articulo.PrecioVenta,
                    Activo = articulo.Activo                    
                };

                return articuloDTO;
        }
    }
}