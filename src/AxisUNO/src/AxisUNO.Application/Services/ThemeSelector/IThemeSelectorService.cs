using Microsoft.UI.Xaml;

namespace AxisUNO.Application.Services.ThemeSelector;

public interface IThemeSelectorService
{
    ElementTheme Theme { get; }

    Task InitializeAsync();

    Task SetThemeAsync(ElementTheme theme);

    Task SetRequestedThemeAsync();
}