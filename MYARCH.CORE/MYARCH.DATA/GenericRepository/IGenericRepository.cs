using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYARCH.DATA.GenericRepository
{
    //burada gönderdiğim TEntity bir sınıf mı ? 
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //context.Post.where,FirstOrDefault....vs;
        /// <summary>
        /// Sordu işlemleri için GetAll() metodunu kullanıyoruz
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// id ye göre veri çekmek için Find() metodu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Find(int id);

        /// <summary>
        /// Gönderilen Entity ye göre kayıt işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Gönderilen Entity ye göre güncelleme işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Gönderilen Entity ye göre silme işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

    }
}
