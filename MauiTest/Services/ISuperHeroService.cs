using MauiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services
{
    public interface ISuperHeroService
    {
        Task<bool> AddSuperHero(string name, string firstName, string lastName, string place);
        Task<IEnumerable<SuperHero>> GetSuperHeroes();
        Task<SuperHero> GetSuperHero(int id);
        Task<bool> RemoveSuperHero(int id);
    }
}
