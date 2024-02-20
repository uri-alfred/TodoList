using Microsoft.Extensions.Logging;
using TodoList.Pages;
using TodoList.Services;
using TodoList.ViewModels;

namespace TodoList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            // inyeccion de dependencias
            builder.Services.AddSingleton<FakeTaskService>();
            builder.Services.AddSingleton<RegistroTareaPage>();
            builder.Services.AddSingleton<RegistroTareaViewModel>();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialDesignIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
