
using RecipeNotesApp.ViewModels;

namespace RecipeNotesApp.Views;

public partial class RecipeView : ContentPage
{
    private RecipeViewModel _viewModel;

    public RecipeView(RecipeViewModel vm)
    {
        InitializeComponent();
        _viewModel = vm;
        BindingContext = vm;
    }
}
