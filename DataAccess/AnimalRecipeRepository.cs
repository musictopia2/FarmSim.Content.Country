namespace FarmSim.Content.Country.DataAccess;
public class AnimalRecipeRepository : IAnimalRecipes
{
    async Task<BasicList<AnimalRecipe>> IAnimalRecipes.GetAnimalsAsync()
    {
        BasicList<AnimalRecipe> list = await AnimalRecipeData.GetAsync(); //when i am ready for something improved, will be here.
        var output = await RecipeExtensions.MergeAsync(list, RecipeExtensions.ExtraAnimalRecipes);
        return output;
    }
}