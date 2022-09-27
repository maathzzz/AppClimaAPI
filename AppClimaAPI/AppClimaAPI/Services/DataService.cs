using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppClimaAPI.Model;

namespace AppClimaAPI.Services
{
    class DataService
    {

        public static async Task<Clima> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "d5bd97549255db7c953bbbf53f4e5b52";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;
            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            // continuar aqui (22)
        }
    }
}
