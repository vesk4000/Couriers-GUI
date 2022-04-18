﻿using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface ICourierService
    {
        void Create(string name, string phoneNumber);

        void Edit(int id, string name, string phoneNumber);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<CourierDetailsServiceModel> All();

        IEnumerable<CourierDetailsServiceModel> GetByContainingText(string containText);
    }
}
