namespace FarmSim.Content.Country.DataAccess;
public class CropRecipeRepository : ICropRecipes
{
    async Task<BasicList<CropRecipe>> ICropRecipes.GetCropsAsync()
    {
        var list = await CropRecipeData.GetAsync();
        return await RecipeExtensions.MergeAsync(list, RecipeExtensions.ExtraCropRecipes);
    }
}