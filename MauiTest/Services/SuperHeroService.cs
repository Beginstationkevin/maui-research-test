//using Bumptech.Glide.Load.Model.Stream;
using MauiTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiTest.Services
{
    internal class SuperHeroService : ISuperHeroService
    {
        string BaseUrl = "http://10.0.2.2:5273";
        HttpClient Client;
        public SuperHeroService() 
        {
            try {
                Client = new HttpClient { BaseAddress = new Uri(BaseUrl) };
            } catch { 

            }
        }

        public async Task<IEnumerable<SuperHero>> GetSuperHeroes() {
            var json = await Client.GetStringAsync("api/superhero");
            JsonContainer test = JsonConvert.DeserializeObject<JsonContainer>(json);
            return test.data;
        }

        public async Task<bool> AddSuperHero(string name, string firstName, string lastName, string place)
        {
            SuperHero superHero = new SuperHero
            {
                name = name,
                firstName = firstName,
                lastName = lastName,
                place = place
            };

            string json = JsonConvert.SerializeObject(superHero);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("api/superhero", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }

        public async Task<SuperHero> GetSuperHero(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveSuperHero(int id)
        {
            var response = await Client.DeleteAsync($"api/superhero/{id}");
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }
    }
}
