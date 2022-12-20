using MauiTest.Helpers;
using MauiTest.Models;
using MauiTest.Services;
using MauiTest.ViewModels;

namespace MauiTest.Views;

public partial class SuperHeroView : ContentPage
{
    public SuperHeroView(SuperHeroViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}