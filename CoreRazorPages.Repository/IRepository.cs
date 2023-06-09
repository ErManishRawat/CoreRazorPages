﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Repository
{
    public  interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> GetAll(string v);
        T? GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();


    }
}
