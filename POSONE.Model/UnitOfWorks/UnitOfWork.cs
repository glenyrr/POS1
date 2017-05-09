using System;
using POSONE.Model.Entities;
using POSONE.Model.Repositories;

namespace POSONE.Model.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly POS1Context _context;
        public UnitOfWork(POS1Context context)
        {
            _context = context;
            Articulo = new ArticuloRepository(_context);
        }

        public UnitOfWork()
        {
            _context = new POS1Context();
            Articulo = new ArticuloRepository(_context);
        }
     
        public IArticuloRepository Articulo {get;private set;}

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