using System;
using POSONE.Model.Entities;
using POSONE.Model.Repositories;

namespace POSONE.Model.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly POS1DbContext _context;
        public UnitOfWork(POS1DbContext context)
        {
            _context = context;
             InicializeRepositories();
           
        }

        public UnitOfWork()
        {
            _context = new POS1DbContext();
             InicializeRepositories();
        }

        private void InicializeRepositories()
        {
            Articulo = new ArticuloRepository(_context);
            Categoria = new Repository<Categoria>(_context);
            Tipo = new Repository<Tipo>(_context);
            Marca = new Repository<Marca>(_context);
            UnidadMedida = new Repository<UnidadMedida>(_context);
            Isv = new Repository<Isv>(_context);
        
        }
     
        public IArticuloRepository Articulo {get;private set;}
        public IRepository<Categoria> Categoria {get;private set;}
        public IRepository<Tipo> Tipo {get;private set;}
        public IRepository<Marca> Marca {get;private set;}        
        public IRepository<Isv> Isv {get;private set;}
        public IRepository<UnidadMedida> UnidadMedida {get;private set;}

       public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}