﻿using HarabaSourceGenerators.Common.Attributes;
using Microsoft.UI.Xaml;

namespace AxisUNO.Application.Services.ThemeSelector;

[Inject]
public partial class ThemeSelectorService : IThemeSelectorService
{
    private const string SettingsKey = "ApplicationTheme";

    private readonly Window _window;

    public ElementTheme Theme { get; private set; } = ElementTheme.Default;

    public async Task InitializeAsync()
    {
        Theme = await LoadThemeFromSettingsAsync();
        await Task.CompletedTask;
    }

    public Task SetRequestedThemeAsync()
    {
        if (_window.Content is FrameworkElement root)
        {
            root.RequestedTheme = Theme;
        }

        return Task.CompletedTask;
    }

    public async Task SetThemeAsync(ElementTheme theme)
    {
        Theme = theme;

        await SetRequestedThemeAsync();
        await SaveThemeInSettingsAsync(Theme);
    }

    private static Task SaveThemeInSettingsAsync(ElementTheme theme)
    {
        return Task.CompletedTask;
    }

    private static Task<ElementTheme> LoadThemeFromSettingsAsync()
    {
        return Task.FromResult(ElementTheme.Default);
    }
}