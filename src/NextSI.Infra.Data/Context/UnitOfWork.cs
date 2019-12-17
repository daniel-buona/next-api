using Microsoft.EntityFrameworkCore.Storage;
using NextSI.Domain.Interfaces;

namespace NextSI.Infra.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NextSIContext _context;
        private IDbContextTransaction _dbTransaction;

        public UnitOfWork(NextSIContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _dbTransaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.SaveChanges();
            _dbTransaction.Commit();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }
    }
}
