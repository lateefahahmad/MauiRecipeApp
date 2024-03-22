using CommunityToolkit.Mvvm.ComponentModel;
using RecipeNotesApp.Views;
using RecipeNotesApp.Models;

namespace RecipeNotesApp.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public List<Recipe> recipes = new List<Recipe>()
    {
        new Recipe()
        {
            name = "Lasagne",
            cuisine = "Italian",
            prepTime = "20 minutes",
            cookTime = "1 hour",
            dietry = "Vegan",
            thumbnailURL = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/slow_cooker_lasagne_57243_16x9.jpg",

        },

        new Recipe()
        {
            name = "Coconut Banana Pancakes",
            cuisine = "European",
            prepTime = "20 minutes",
            cookTime = "10 minutes",
            dietry = "Vegan",
            thumbnailURL = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/coconut_pancakes_with_38938_16x9.jpg",

        },

        new Recipe()
        {
            name = "Baba Ghanoush",
            cuisine = "Middle Eastern",
            prepTime = "30 minutes",
            cookTime = "1 hour",
            dietry = "Halal",
            thumbnailURL = "https://falasteenifoodie.com/wp-content/uploads/2023/02/baba-ghanoush-2.jpeg",
        }
    };

    public MainPageViewModel()
    {

    }

    public async Task OpenRecipeDetailView(Recipe recipe)
    {
        await Shell.Current.Navigation.PushAsync(new RecipeView(new RecipeViewModel(recipe)));
    }

    public void FilterButton_Clicked()
    {
        Console.WriteLine("Lateefah");
    }

}

