﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface IRepository<T>//Generic Repostroy oluiturduk. Geri kalanlar buradan türetiliyor
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
