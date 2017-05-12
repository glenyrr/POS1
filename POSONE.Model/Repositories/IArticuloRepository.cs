using System.Collections.Generic;
using POSONE.Model.Entities;

namespace POSONE.Model.Repositories
{
    public interface IArticuloRepository: IRepository<Articulo>
    {
         IEnumerable<Articulo> GetTopSellingArticulo(int count);
         IEnumerable<Articulo> GetArticuloByCategory(int? categoryId);
         IEnumerable<Articulo> GetArticulosByPage(int pageIndex, int pageSize);

         Articulo GetArticuloAllIncluded(string id);
    }
}