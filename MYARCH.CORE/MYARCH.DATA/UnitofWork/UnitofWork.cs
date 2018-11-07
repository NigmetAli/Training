using MYARCH.DATA.Context;
using MYARCH.DATA.GenericRepository;
using System;
using System.Data.Entity;

namespace MYARCH.DATA.UnitofWork
{
    //veritabanıyla işlemler yaptıktan sonra ilişiği kesmek için IDisposable ı kullandık
    public class UnitofWork : IUnitofWork
    {
        private readonly MyArchContext _context;
        private bool disposed = false;
        DbContextTransaction transaction;

        public UnitofWork(MyArchContext context)
        {
            Database.SetInitializer<MyArchContext>(null);

            if (context == null)
                throw new ArgumentException("Context is null");

            _context = context;
        }

      public  IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context);
        }

        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BeginTransaction()
        {
            transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
           transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
;