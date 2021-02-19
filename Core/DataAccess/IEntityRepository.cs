using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint : generic kısıtlama
    //Şartlar = Referans tipi olmalı, IEntity türünde olmalı, newlenebilir olmalı.
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        // Expression verebilmemizi sağlar. Yani tüm veriyi çekerken filtreleme yapabiliriz. Filter=null demek ise filtreleme yapmadan da kullanılabilir.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        //Burada filtre zorunlu.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
