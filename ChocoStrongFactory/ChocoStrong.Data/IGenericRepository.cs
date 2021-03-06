﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace ChocoStrong.Data
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();

        T Find(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Detach(T entity);
    }
}
