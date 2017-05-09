using System.Collections.Generic;
using POSONE.Model.Entities;

namespace POSONE.Model.Repositories
{
    public interface IArticuloRepository: IRepository<Articulo>
    {
         IEnumerable<Articulo> GetTopSellingArticulo(int count);
         IEnumerable<Articulo> GetArticuloByCategory(int? categoryId);
         IEnumerable<Articulo> GetArticuloAllInclude(int pageIndex, int pageSize);
    }
}