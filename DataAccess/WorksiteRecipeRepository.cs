namespace FarmSim.Content.Country.DataAccess;
public class WorksiteRecipeRepository : IWorksiteRecipes
{
    async Task<BasicList<WorksiteRecipe>> IWorksiteRecipes.GetWorksitesAsync()
    {
        var list = await WorksiteData.GetAsync();
        return await RecipeExtensions.MergeAsync(list, RecipeExtensions.ExtraWorksiteRecipes);
    }
}