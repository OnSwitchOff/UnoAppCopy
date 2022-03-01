using AxisUNO.Application.Services.Activation;
using AxisUNO.Configurations;
using AxisUNO.Prerequisite.Win32.WindowIconLoaders;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml;

namespace AxisUNO;

public sealed partial class App : Microsoft.UI.Xaml.Application
{
    public App()
    {
        InitializeComponent();
    }

    // Windows must be static, because of WinAPI resources allocation.
    public static Window MainWindow { get; private set; } = new() { Title = "Axis UNO" };

    protected override async void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);

        Ioc.Default.ConfigureServices(Startup.ConfigureServices());

        var activationService = Ioc.Default.GetRequiredService<IActivationService>();
        await activationService.ActivateAsync(args);

        InitializeWindow();
    }

    private static void InitializeWindow()
    {
        WindowIconLoader.LoadIcon(MainWindow, @"Assets\Icons\WindowIcon.ico");
    }
}