namespace FarmSim.Content.Country.DataAccess;
internal static class TreeRecipeData
{
    public static Task<BasicList<TreeRecipe>> GetAsync()
    {
        BasicList<TreeRecipe> output = [];
        TreeRecipe tree = new()
        {
            TreeName = CountryTreeListClass.Apple,
            Item = CountryItemList.Apple,
            ProductionTimeForEach = TimeSpan.FromSeconds(10),
            IsFast = true
        };
        output.Add(tree);
        tree = new()
        {
            TreeName = CountryTreeListClass.Peach,
            Item = CountryItemList.Peach,
            ProductionTimeForEach = TimeSpan.FromHours(1),
            IsFast = false
        };
        output.Add(tree);
        return Task.FromResult(output);
    }
}