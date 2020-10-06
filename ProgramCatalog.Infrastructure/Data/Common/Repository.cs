using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ProgramCatalog.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        protected DbContext Context {get; set;}

        public Repository(ApplicationDBContext context)
        {
            Context = context;
        }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return Context.Set<T>();
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public void Add<T>(T entity) where T : class
        {
            DbSet<T>().Add(entity);
        }

        public T GetById<T>(object id) where T : class
        {
            return DbSet<T>().Find(id);
        }

        public void Update<T>(T entity) where T : class
        {
            DbSet<T>().Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            return;
        }

        public void Delete<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
