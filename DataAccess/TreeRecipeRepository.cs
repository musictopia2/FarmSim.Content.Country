namespace FarmSim.Content.Country.DataAccess;
public class TreeRecipeRepository : ITreeRecipes
{
    async Task<BasicList<TreeRecipe>> ITreeRecipes.GetTreesAsync()
    {
        var list = await TreeRecipeData.GetAsync();
        return await RecipeExtensions.MergeAsync(list, RecipeExtensions.ExtraTreeRecipes);
    }
}