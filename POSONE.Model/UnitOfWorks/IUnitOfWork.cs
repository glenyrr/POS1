using POSONE.Model.Repositories;

namespace POSONE.Model.UnitOfWorks
{
    public interface IUnitOfWork
    {
         IArticuloRepository Articulo {get;}
         int Complete();
    }
}