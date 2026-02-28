namespace FarmSim.Content.Country.DataAccess;
internal static class AnimalRecipeData
{
    public static Task<BasicList<AnimalRecipe>> GetAsync()
    {
        BasicList<AnimalRecipe> output = [];
        BasicList<AnimalProductionOption> options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(1),
            Input = 3,
            Output = new(CountryItemList.Milk, 1),
            Required = CountryItemList.Wheat
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(3),
            Input = 9,
            Output = new(CountryItemList.Milk, 3),
            Required = CountryItemList.Wheat
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(30),
            Input = 24,
            Output = new(CountryItemList.Milk, 8),
            Required = CountryItemList.Wheat
        });
        AnimalRecipe recipe = new()
        {
            Animal = CountryAnimalListClass.Cow,
            Options = options,
            IsFast = true
        };
        output.Add(recipe);
        options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(4),
            Input = 2,
            Output = new(CountryItemList.Eggs, 2),
            Required = CountryItemList.Corn
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(8),
            Input = 4,
            Output = new(CountryItemList.Eggs, 4),
            Required = CountryItemList.Corn
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(35),
            Input = 8,
            Output = new(CountryItemList.Eggs, 8),
            Required = CountryItemList.Corn
        });
        recipe = new()
        {
            Animal = CountryAnimalListClass.Chicken,
            Options = options,
            IsFast = true
        };
        

        output.Add(recipe);
        options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(3),
            Input = 2,
            Output = new(CountryItemList.GoatMilk, 2),
            Required = CountryItemList.Carrot
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(8),
            Input = 4,
            Output = new(CountryItemList.GoatMilk, 4),
            Required = CountryItemList.Carrot
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(30),
            Input = 8,
            Output = new(CountryItemList.GoatMilk, 8),
            Required = CountryItemList.Carrot
        });
        recipe = new()
        {
            Animal = CountryAnimalListClass.Goat,
            Options = options,
            IsFast = false
        };
        output.Add(recipe);

        options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(30),
            Input = 4,
            Output = new(CountryItemList.Wool, 3),
            Required = CountryItemList.Tomato
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromHours(1),
            Input = 8,
            Output = new(CountryItemList.Wool, 6),
            Required = CountryItemList.Tomato
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromHours(4),
            Input = 16,
            Output = new(CountryItemList.Wool, 12),
            Required = CountryItemList.Tomato
        });
        recipe = new()
        {
            Animal = CountryAnimalListClass.Sheep,
            Options = options,
            IsFast = false
        };
        output.Add(recipe);
        return Task.FromResult(output);
    }
}