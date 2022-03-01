using System;
using System.Collections.Generic;
using System.Linq;
using AxisUNO.Application.Services.Navigation;
using AxisUNO.Application.ViewModels.DashboardViewModels;
using AxisUNO.Application.ViewModels.MainViewModels;
using AxisUNO.Application.ViewModels.ProductsViewModels;
using AxisUNO.Presentation.Views.DashboardViews;
using AxisUNO.Presentation.Views.MainViews;
using AxisUNO.Presentation.Views.ProductsViews;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace AxisUNO.Services.Navigation;

internal class ViewsService : IViewsService
{
    private readonly Dictionary<string, Type> _pages = new();

    public ViewsService()
    {
        Configure<MainViewModel, MainView>();
        Configure<ProductsViewModel, ProductsView>();
        Configure<DashboardViewModel, DashboardView>();
    }

    public Type GetViewType(string key)
    {
        Type? viewType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out viewType))
            {
                throw new ArgumentException($"Page not found: {key}. Register the view in the constructor.");
            }
        }

        return viewType;
    }

    public void Configure<TViewModel, TView>()
        where TViewModel : ObservableObject
        where TView : Page
    {
        lock (_pages)
        {
            var key = typeof(TViewModel).FullName ?? string.Empty;

            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(TView);
            if (_pages.Any(page => page.Value == type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}