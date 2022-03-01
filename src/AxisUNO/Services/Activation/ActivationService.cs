﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AxisUNO.Application.Services.Activation;
using AxisUNO.Application.Services.ThemeSelector;
using AxisUNO.Presentation.Views.MainViews;
using BuildingBlocks.Application.Services.Activation.Handlers;
using CommunityToolkit.Mvvm.DependencyInjection;
using HarabaSourceGenerators.Common.Attributes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace AxisUNO.Services.Activation;

[Inject]
public partial class ActivationService : IActivationService
{
    private readonly ActivationHandler<LaunchActivatedEventArgs> _defaultHandler;
    private readonly IEnumerable<IActivationHandler> _activationHandlers;
    private readonly IThemeSelectorService _themeSelectorService;

    private UIElement? _shell = null;

    public async Task ActivateAsync(LaunchActivatedEventArgs activationArgs)
    {
        // Initialize services that you need before app activation
        // take into account that the splash screen is shown while this code runs.
        await InitializeAsync();

        if (App.MainWindow.Content is null)
        {
            _shell = Ioc.Default.GetService<MainView>();
            App.MainWindow.Content = _shell ?? new Frame();
        }

        // Depending on activationArgs one of ActivationHandlers or DefaultActivationHandler
        // will navigate to the first page
        await HandleActivationAsync(activationArgs);

        // Ensure the current window is active
        App.MainWindow.Activate();

        // Tasks after activation
        await StartupAsync();
    }

    private async Task HandleActivationAsync(object activationArgs)
    {
        var activationHandler = _activationHandlers
                                            .FirstOrDefault(h => h.CanHandle(activationArgs));

        if (activationHandler is not null)
        {
            await activationHandler.HandleAsync(activationArgs);
        }

        if (_defaultHandler.CanHandle(activationArgs))
        {
            await _defaultHandler.HandleAsync(activationArgs);
        }
    }

    private async Task InitializeAsync()
    {
        await _themeSelectorService.InitializeAsync().ConfigureAwait(false);
        await Task.CompletedTask;
    }

    private async Task StartupAsync()
    {
        await _themeSelectorService.SetRequestedThemeAsync();
        await Task.CompletedTask;
    }
}