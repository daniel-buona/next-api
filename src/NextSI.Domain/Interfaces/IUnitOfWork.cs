using System;
//using Microsoft.EntityFrameworkCore.Storage.RelationalTransaction;

namespace NextSI.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
