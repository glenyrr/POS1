using System.Collections.Generic;
using POSONE.Model.Models;

namespace POSONE.Model.Repositories
{
    public interface IArticuloRepository: IRepository<Articulo>
    {
         IEnumerable<Articulo> GetTopSellingArticulo(int count);
         IEnumerable<Articulo> GetArticuloByCategory(string category);
         IEnumerable<Articulo> GetArticuloAllInclude(int pageIndex, int pageSize);
    }
}