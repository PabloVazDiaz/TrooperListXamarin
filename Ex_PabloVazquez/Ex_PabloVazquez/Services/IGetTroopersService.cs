using Ex_PabloVazquez.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ex_PabloVazquez.Services
{
    interface IGetTroopersService
    {
        Task<List<Trooper>> GetAllTroopers();
    }
}
