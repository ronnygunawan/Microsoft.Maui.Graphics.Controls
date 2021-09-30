using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Graphics.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace GraphicsControls.Sample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() => MauiApp
            .CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureGraphicsControls()
            .Build();
    }
}
