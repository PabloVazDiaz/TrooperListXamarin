using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Ex_PabloVazquez.Model;
using Newtonsoft.Json;

namespace Ex_PabloVazquez.Services
{
    class GetTropeersService : IGetTroopersService
    {
        public async Task<List<Trooper>> GetAllTroopers()
        {
            HttpClient httpClient = new HttpClient();
            var json= await httpClient.GetStringAsync("http://www.mocky.io/v2/5c5e8e97320000bd0c40b3b4 ");
            List<Trooper> list = JsonConvert.DeserializeObject<List<Trooper>>(json);
            return list;
        }
    }
}
