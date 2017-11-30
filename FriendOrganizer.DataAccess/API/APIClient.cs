using FriendOrganizer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.DataAccess.API
{
    public class APIClient : IAPIClient
    {
        public HttpClient client = new HttpClient{BaseAddress = new Uri("https://www.metaweather.com/api/")};

        public async Task<Weather> RunAsync(DateTime dateTime)
        {
           // client.BaseAddress = new Uri("https://www.metaweather.com/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Weather weather = await GetWeatherAsync($"location/890869/{dateTime.Year}/{dateTime.Month}/{dateTime.Day}/");
            return weather;
        } 
        private async Task<Weather> GetWeatherAsync(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            var jasonString = await response.Content.ReadAsStringAsync();
            var weatherList = JsonConvert.DeserializeObject<List<Weather>>(jasonString);
            return weatherList[0];
        }
    }
}
