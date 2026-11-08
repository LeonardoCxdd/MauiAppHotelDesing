using Microsoft.Extensions.Logging;

namespace MauiAppHotelDesing
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
                    fonts.AddFont("Sora-Bold.ttf", "SoraBold");
                    fonts.AddFont("Sora-ExtraBold.ttf", "SoraExtraBold");
                    fonts.AddFont("Sora-ExtraLight.ttf", "SoraExtraLight");
                    fonts.AddFont("Sora-Light.ttf", "SoraLight");
                    fonts.AddFont("Sora-Medium.ttf", "SoraMedium");
                    fonts.AddFont("Sora-Regular.ttf", "SoraRegular");
                    fonts.AddFont("Sora-SemiBold.ttf", "SoraSemiBold");
                    fonts.AddFont("Sora-Thin.ttf", "SoraThin");
                    fonts.AddFont("Sora-VariableFont_wght.ttf", "SoraVariableFont_wght");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
