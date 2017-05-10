using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using POSONE.Model.Entities;

namespace POSONE.Model.Repositories
{
    
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
         public ArticuloRepository(POS1DbContext context) : base(context)
        {
            
        }
        IEnumerable<Articulo> IArticuloRepository.GetArticuloAllInclude(int pageIndex, int pageSize )
        {
            return PlutoContext.Articulo
                   .OrderBy(o=> o.Descripcion)
                   .Skip((pageIndex -1)* pageSize)
                   .Take(pageSize)
                   .ToList(); 
        }

        IEnumerable<Articulo> IArticuloRepository.GetArticuloByCategory(int? categoryId)
        {
             return PlutoContext.Articulo.Where(q=> q.CategoriaId == categoryId).OrderByDescending(c=> c.DescripcionLarga).ToList();
        }

        IEnumerable<Articulo> IArticuloRepository.GetTopSellingArticulo(int count)
        {
            return PlutoContext.Articulo.OrderByDescending(c=> c.CostoPromedio).Take(count).ToList();
        }

        public POS1DbContext PlutoContext
        {
            get {return Context as POS1DbContext;} 
        }
     

    }
}