namespace MauiTest.Models;

internal class About
{
    public string Title => "hallo test";
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
}