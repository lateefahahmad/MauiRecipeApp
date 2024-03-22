using System;
using CommunityToolkit.Mvvm.ComponentModel;
using RecipeNotesApp.Models;
namespace RecipeNotesApp.ViewModels;

public partial class RecipeViewModel : ObservableObject
{
    [ObservableProperty]
    public Recipe recipe = new();

    public RecipeViewModel(Recipe recipe)
    {
        this.recipe = recipe;
    }
}

