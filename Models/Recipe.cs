using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RecipeNotesApp.Models;


public partial class Recipe : ObservableObject
{
    [ObservableProperty]
    public string name;
    [ObservableProperty]
    public string cuisine;
    [ObservableProperty]
    public string thumbnailURL;
    [ObservableProperty]
    public List<string> ingredients = new List<string>();
    [ObservableProperty]
    public List<string> method = new List<string>();
    [ObservableProperty]
    public string prepTime;
    [ObservableProperty]
    public string cookTime;
    [ObservableProperty]
    public string servingAmount;
    [ObservableProperty]
    public string dietry;

    public Recipe()
    {
    }
}

