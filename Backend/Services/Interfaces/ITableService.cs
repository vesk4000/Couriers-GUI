using Couriers_GUI.Backend.Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services.Interfaces
{
    interface ITableService<T1, T2>
    {
        void Create(T1 e);

        void Edit(T1 e);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<T2> All();

        IEnumerable<T2> GetByContainingText(string containText);
    }
}
