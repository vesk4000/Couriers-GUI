using Couriers_GUI.Backend.Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services.Interfaces
{
    interface ITableService<T>
    {
        void Create(T e);

        void Edit(T e);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<T> All();

        IEnumerable<T> GetByContainingText(string containText);
    }
}
