namespace FarmSim.Content.Country.DataAccess;
internal static class WorksiteData
{
    public static Task<BasicList<WorksiteRecipe>> GetAsync()
    {
        BasicList<WorksiteRecipe> output = [];
        WorksiteRecipe recipe = new()
        {
            StartText = "Go Foraging!",
            Location = CountryWorksiteListClass.GrandmasGlade,
            Duration = TimeSpan.FromMinutes(15),
            MaximumWorkers = 2,
            CanFocus = false //no need from here since does not take long.  plus no rare items.
        };
        recipe.Inputs.Add(CountryItemList.Biscuit, 1);
        WorksiteBaselineBenefit benefit = new()
        {
            Guarantee = true,
            Item = CountryItemList.Blackberry
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Chance = 0.4,
            Item = CountryItemList.Chives
        };
        recipe.BaselineBenefits.Add(benefit);
        output.Add(recipe);
        recipe = new()
        {
            StartText = "Go Fishing!",
            Location = CountryWorksiteListClass.Pond,
            Duration = TimeSpan.FromHours(8),
            MaximumWorkers = 4,
        };
        recipe.Inputs.Add(CountryItemList.Biscuit, 1);
        recipe.Inputs.Add(CountryItemList.FarmersSoup, 1);

        benefit = new()
        {
            Guarantee = true,
            Item = CountryItemList.Trout
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = CountryItemList.Bass,
            Chance = 0.11
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = CountryItemList.Mint,
            Chance = 0.13
        };
        recipe.BaselineBenefits.Add(benefit);
        output.Add(recipe);
        recipe = new()
        {
            StartText = "Go Exploring!",
            Location = CountryWorksiteListClass.Mines,
            Duration = TimeSpan.FromHours(2),
            MaximumWorkers = 6,
        };
        recipe.Inputs.Add(CountryItemList.GranolaBar, 2);
        recipe.Inputs.Add(CountryItemList.Blanket, 2);

        benefit = new()
        {
            Guarantee = true,
            Item = CountryItemList.Quartz,
            Quantity = 2
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = CountryItemList.Tin,
            Chance = 0.5
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = CountryItemList.Cooper,
            Chance = 0.07
        };
        recipe.BaselineBenefits.Add(benefit);
        output.Add(recipe);
        return Task.FromResult(output);
    }
}