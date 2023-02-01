using ProyectoProgreso3.MVVM.Models;
using ProyectoProgreso3.Repositories;
using Syncfusion.Maui.Core.Hosting;

namespace ProyectoProgreso3;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Black.ttf", "Fuerte");
                fonts.AddFont("LibreFranklin-Regular.ttf", "Regular");
            });

		builder.Services.AddSingleton<BaseRepository<MVTransacciones>>();
		return builder.Build();
	}
}
