using Microsoft.UI.Xaml.Controls;

namespace AxisUNO.Application.Services.Navigation;

public interface INavigationViewService
{
    IList<object> MenuItems { get; }

    object SettingsItem { get; }

    void Initialize(NavigationView navigationView);

    void UnregisterEvents();

    NavigationViewItem? GetSelectedItem(Type pageType);
}