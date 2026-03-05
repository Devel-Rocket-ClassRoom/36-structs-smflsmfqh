using System;

Ingredient[] tomatoPasta = new Ingredient[4];
tomatoPasta[0] = new Ingredient("스파게티면", 200, "g");
tomatoPasta[1] = new Ingredient("토마토소스", 150, "ml");
tomatoPasta[2] = new Ingredient("양파", 1, "개");
tomatoPasta[3] = new Ingredient("마늘", 3, "쪽");

RecipeCard recipe  = new RecipeCard("토마토 파스타", 2, tomatoPasta);
Console.WriteLine("=== 원본 레시피 ===");
recipe.PrintRecipe();
Console.WriteLine();
recipe.ScapleRecipe(4);
Console.WriteLine("=== 4인분으로 변환 ===");
recipe.PrintRecipe();
