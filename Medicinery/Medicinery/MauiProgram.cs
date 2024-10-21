﻿
using Medicinery.Pages;
using Medicinery.Services;

namespace Medicinery
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<CategoryServices>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<HomePage>(); 

            return builder.Build();


        }
    }
}