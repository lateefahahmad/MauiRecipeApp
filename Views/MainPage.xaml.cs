using RecipeNotesApp.ViewModels;
using RecipeNotesApp.Models;

namespace RecipeNotesApp.Views;

public partial class MainPage : ContentPage
{
    MainPageViewModel _viewModel;

    public MainPage()
    {
        InitializeComponent();
        _viewModel = new MainPageViewModel();
        BindingContext = _viewModel;
    }

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Recipe recipe = (Recipe)e.Parameter;
        await _viewModel.OpenRecipeDetailView(recipe);
    }
}
