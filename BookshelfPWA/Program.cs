using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BookshelfPWA;
using BookshelfWWW;
using Microsoft.Extensions.Options;
using WeatherApp.Client.Services;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var settings = new AppSettings();
builder.Configuration.Bind(settings);
builder.Services.AddSingleton(settings);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IBookshelfService, BookshelfService>();


await builder.Build().RunAsync();
