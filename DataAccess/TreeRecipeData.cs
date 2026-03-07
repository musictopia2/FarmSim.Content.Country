namespace FarmSim.Content.Country.DataAccess;
public static class TreeRecipeData
{
    public static BasicList<TreeRecipe> Get()
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
        return output;
    }
    public static Task<BasicList<TreeRecipe>> GetAsync()
    {
        return Task.FromResult(Get());
    }
}