using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using MudBlazor.Services;
using Predictor.Authentication;
using Predictor.Data;
using Predictor.Services.Infrastructures;
using Predictor.Services.Interfaces;
using Predictor.Services.Repositories;

namespace Predictor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddMudServices();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            builder.Services.AddSingleton<IUserAccess, MockAccountService>();
            builder.Services.AddScoped<MudThemeProvider>();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddScoped<ILocation, MockLoaction>();
            builder.Services.AddScoped<IStateService, StateService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}