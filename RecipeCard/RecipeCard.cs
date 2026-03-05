using System;
using System.Collections.Generic;
using System.Text;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] ingredients;
    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        this.ingredients = ingredients; 
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name} ({Servings}인분)]");
        Console.WriteLine("재료:");
        foreach (Ingredient item in  ingredients)
        {
            Console.WriteLine($"-{item.Name}: {item.Amount}{item.Unit}"); 
        }
    }
    public RecipeCard ScapleRecipe(int newServings)
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            ingredients[i].Amount *= newServings/Servings;
        }
        Servings = newServings;
        return this;
    }
}