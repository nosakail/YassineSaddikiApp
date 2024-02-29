using Microsoft.Extensions.Logging;

namespace YassineSaddikiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Oswald-Bold.ttf", "Oswald");
                    fonts.AddFont("PlayfairDisplay-Bold.ttf", "PlayfairDisplayBold");
                    fonts.AddFont("PlayfairDisplay-Italic.ttf", "PlayfairDisplayItalic");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
