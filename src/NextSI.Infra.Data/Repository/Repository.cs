using System;
using System.Linq;
using NextSI.Domain.Interfaces;
using NextSI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using NextSI.Domain.Core.Models;

namespace NextSI.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly NextSIContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(NextSIContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            // TODO: Salvar a data de inclusão
            (obj as BaseEntity).InsertHora = DateTime.Now;
            (obj as BaseEntity).Excluido = 'N';
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            // TODO: Salvar a data de Alteração
            (obj as BaseEntity).UpdateHora = DateTime.Now;
            DbSet.Update(obj);
        }

        public virtual void Remove(int id)
        {
            // TODO: Salvar a data de exclusão
            var obj = DbSet.Find(id);
            (obj as BaseEntity).DeleteHora = DateTime.Now;
            (obj as BaseEntity).Excluido = 'S';
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
