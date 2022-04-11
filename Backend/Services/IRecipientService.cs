using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface IRecipientService
    {
        void Create(string name);

        void Edit(int id, string name);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Recipient> All();
    }
}
