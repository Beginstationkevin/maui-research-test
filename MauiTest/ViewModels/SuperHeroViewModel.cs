using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest.Models;
using MauiTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.ViewModels
{
    public partial class SuperHeroViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        IEnumerable<SuperHero> superHeroes;

        ISuperHeroService Service;

        public bool IsNotBusy => !IsBusy;

        public SuperHeroViewModel(ISuperHeroService superHeroService)
        {
            Title = "SuperHero";
            Service = superHeroService;
        }

        [RelayCommand]
        async Task GetSuperHeroes() 
        { 
            SuperHeroes = await Service.GetSuperHeroes();
        }
    }
}
