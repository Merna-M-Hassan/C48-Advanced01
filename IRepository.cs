using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced
{
    internal interface IRepository<T>
    {
        void Add(T item);

        T? GetById(int id);

        List<T> GetAll();

        void Delete(int id);
    }
}
