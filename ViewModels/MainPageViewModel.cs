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
            Name = "Lasagne",
            Cuisine = "Italian",
            PrepTime = "20 minutes",
            CookTime = "1 hour",
            Dietry = "Vegan",
            ThumbnailURL = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/slow_cooker_lasagne_57243_16x9.jpg",
            Ingredients = new List<string>()
            {
                "Lasagne sheets",
                "Pesto",
                "Cheese",
                "Olives",
                "Basil",
                "Oregano",
            },

              Method = new List<string>()
            {
                "1. Preheat the oven to 160C/140C Fan/Gas 3",
                "2. For the ragu, heat a large frying pan until hot and add the oil. Cook the mince until browned all over. Remove from the heat and transfer to a plate.",
                "3. Add the onion, celery (if using) and garlic to the pan and cook until softened. Return the meat to the pan and stir in the flour. Add the stock and bring to the boil. Add the redcurrant jelly (or sugar), tomato purée and thyme, then stir well.",
                "4. Stir in the tinned tomatoes. Bring to the boil again, cover and simmer in the oven for 1–½ hours, or until the beef is tender.",
                "5. For the white sauce, melt the butter in a saucepan. Add the flour and cook over the heat for one minute. Gradually whisk in the hot milk, whisking until thickened. Add the Dijon mustard and parmesan cheese and season well with salt and pepper.",
                "6. For the lasagne, put one third of the meat sauce in the base of a 2.3 litre/4 pint shallow ovenproof dish. Spoon one third of the white sauce on top. Season with salt and pepper. Arrange one layer of lasagne sheets on top.",
                "7. Spoon half of the remaining meat sauce on top and then half of the white sauce. Season with salt and pepper. Put another layer of lasagne sheets on top, then the remaining meat sauce and remaining white sauce. Sprinkle over the cheddar.",
                "8. Leave for 6 hours before cooking so that the pasta can start to soften.",
                "9. Preheat the oven to 200C/180C Fan/Gas 6.",
                "10. Cook in the middle of the oven for about 45 minutes – or until golden brown on top, bubbling around the edges and the pasta is soft.",
            }

        },

        new Recipe()
        {
            Name = "Coconut Banana Pancakes",
            Cuisine = "European",
            PrepTime = "20 minutes",
            CookTime = "10 minutes",
            Dietry = "Vegan",
            ThumbnailURL = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/coconut_pancakes_with_38938_16x9.jpg",

            Ingredients = new List<string>()
            {
                "Lasagne sheets",
                "Pesto",
                "Cheese",
                "Olives",
                "Basil",
                "Oregano",
            },

              Method = new List<string>()
            {
                "Lasagne sheets",
                "Pesto",
                "Cheese",
                "Olives",
                "Basil",
                "Oregano",
            }
        },

        new Recipe()
        {
            Name = "Baba Ghanoush",
            Cuisine = "Middle Eastern",
            PrepTime = "30 minutes",
            CookTime = "1 hour",
            Dietry = "Halal",
            ThumbnailURL = "https://falasteenifoodie.com/wp-content/uploads/2023/02/baba-ghanoush-2.jpeg",

            Ingredients = new List<string>()
            {
                "Lasagne sheets",
                "Pesto",
                "Cheese",
                "Olives",
                "Basil",
                "Oregano",
            },

              Method = new List<string>()
            {
                "Lasagne sheets",
                "Pesto",
                "Cheese",
                "Olives",
                "Basil",
                "Oregano",
            }
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

    public async Task OpenRecipeManagerView()
    {
        await Shell.Current.Navigation.PushAsync(new RecipeManagerView());
    }


}

