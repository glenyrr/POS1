using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using POSONE.Model.Models;

namespace POSONE.Model.Repositories
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {

        public ArticuloRepository(PosOneDbContext context) : base(context)
        {
            
        }
        IEnumerable<Articulo> IArticuloRepository.GetArticuloAllInclude(int pageIndex, int pageSize = 10)
        {
            return PlutoContext.Articulo
                   .OrderBy(o=> o.Descripcion)
                   .Skip((pageIndex -1)* pageSize)
                   .Take(pageSize)
                   .ToList(); 
        }

        IEnumerable<Articulo> IArticuloRepository.GetArticuloByCategory(string category)
        {
             return PlutoContext.Articulo.Where(q=> q.Categoria == category).OrderByDescending(c=> c.Precio).ToList();
        }

        IEnumerable<Articulo> IArticuloRepository.GetTopSellingArticulo(int count)
        {
            return PlutoContext.Articulo.OrderByDescending(c=> c.Precio).Take(count).ToList();
        }

        public PosOneDbContext PlutoContext
        {
            get {return Context as PosOneDbContext;} 
        }
    }
}