using System;

namespace RecipeNotesApp.Models;


public class Recipe
{
    public string name { get; set; }
    public string cuisine { get; set; }
    public string thumbnailURL { get; set; }
    public List<string> ingredients = new List<string>();
    public List<string> method = new List<string>();
    public string prepTime { get; set; }
    public string cookTime { get; set; }
    public string servingAmount { get; set; }
    public string dietry { get; set; }

    public Recipe()
    {
    }
}

