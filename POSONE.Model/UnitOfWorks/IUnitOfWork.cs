using POSONE.Model.Entities;
using POSONE.Model.Repositories;

namespace POSONE.Model.UnitOfWorks
{
    public interface IUnitOfWork
    {
         IArticuloRepository Articulo {get;}
         IRepository<Categoria> Categoria{get;}
         IRepository<Tipo> Tipo{get;}
        IRepository<Marca> Marca{get;}
        
         IRepository<Isv> Isv{get;}
          IRepository<UnidadMedida> UnidadMedida{get;}


         int Complete();
    }
}