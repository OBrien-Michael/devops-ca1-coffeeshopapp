using CoffeeShopApp.Services;
using CoffeeShopApp.View;
using CoffeeShopApp.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace CoffeeShopApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<ItemService>();

            builder.Services.AddSingleton<MenuPage>();
	        builder.Services.AddSingleton<MenuViewModel>();

            builder.Services.AddSingleton<ItemDescriptionPage>();
            builder.Services.AddSingleton<ItemDescriptionViewModel>();

            builder.Services.AddSingleton<CheckoutPage>();
            builder.Services.AddSingleton<CheckoutPageViewModel>();
            


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
