using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   
    //CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ
    //Generic Constrete
    //class: referance type
    //IEntity: IEntity ve IEntity den implemente eden nesne de olabilir
    //new(): new'lenebilir olmalı

    public interface IEntityRepository<T> where T:class,IEntity,new()     {
        List<T> GetAll(Expression <Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
