using MYARCH.DATA.GenericRepository;
using System;

namespace MYARCH.DATA.UnitofWork
{
    //veritabanıyla işlemler yaptıktan sonra ilişiği kesmek için IDisposable ı kullandık
    public interface IUnitofWork:IDisposable
    {
        //generic...

        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        /// <summary>
        /// Değişiklikleri Kaydet.
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
  
        /// <summary>
        /// Tracnsaction Başlat.
        /// </summary>
        void BeginTransaction();
        
        /// <summary>
        /// Kayıt Esnasında Bir sorrun olmazsa transaction durdur.
        /// </summary>
        void Commit();
        
        /// <summary>
        /// Kayıt esnasında bir seoun olursa değişkilikleri geri al
        /// </summary>
        void Rollback();
    }
}
