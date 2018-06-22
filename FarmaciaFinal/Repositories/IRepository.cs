﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaFinal.Repositories
{
    public interface IRepository<T>
    {
        List<T> Reader();
        T ReaderById(int id);

        void Create(T entity);

        void Delete(int id);

        void Update(T entity);
    }
}
