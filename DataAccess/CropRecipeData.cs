namespace FarmSim.Content.Country.DataAccess;
internal static class CropRecipeData
{
    public static Task<BasicList<CropRecipe>> GetAsync()
    {
        BasicList<CropRecipe> output = [];
        output.Add(new CropRecipe
        {
            Item = CountryItemList.Wheat,
            Duration = TimeSpan.FromSeconds(30),
            IsFast = true,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = CountryItemList.Corn,
            Duration = TimeSpan.FromMinutes(2),
            IsFast = false,
            HowMany = 2
        });
        output.Add(new CropRecipe
        {
            Item = CountryItemList.Carrot,
            Duration = TimeSpan.FromMinutes(4),
            IsFast = false,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = CountryItemList.Strawberry,
            Duration = TimeSpan.FromHours(1),
            IsFast = false,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = CountryItemList.Tomato,
            Duration = TimeSpan.FromMinutes(10),
            IsFast = false,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = CountryItemList.HoneyComb,
            Duration = TimeSpan.FromMinutes(45),
            IsFast = false,
            HowMany = 3
        });
        return Task.FromResult(output);
    }
}