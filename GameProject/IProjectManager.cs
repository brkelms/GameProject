using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IProjectManager<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
