using AxisUNO.Application.ViewModels.ProductsViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;

namespace AxisUNO.Presentation.Views.ProductsViews;

public sealed partial class ProductsView : Page
{
    public ProductsView()
    {
        ViewModel = Ioc.Default.GetRequiredService<ProductsViewModel>();
        InitializeComponent();
    }

    public ProductsViewModel ViewModel { get; }
}