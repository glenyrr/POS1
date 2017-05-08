using System;
using POSONE.Model.Models;
using POSONE.Model.Repositories;

namespace POSONE.Model.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly PosOneDbContext _context;
        public UnitOfWork(PosOneDbContext context)
        {
            _context = context;
            Articulo = new ArticuloRepository(_context);
        }

        public UnitOfWork()
        {
            _context = new PosOneDbContext();
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