using Template_MAUI.ViewModels;

namespace Template_MAUI.Views;

public partial class MainView : ContentPage
{
    MainViewModel viewModel;
    public MainView()
    {
        InitializeComponent();
        viewModel = new MainViewModel();
        BindingContext = viewModel;
    }
}