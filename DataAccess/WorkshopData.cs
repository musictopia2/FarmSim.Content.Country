namespace FarmSim.Content.Country.DataAccess;
internal static class WorkshopData
{
    public static Task<BasicList<WorkshopRecipe>> GetAsync()
    {
        BasicList<WorkshopRecipe> output = [];

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Flour, CountryWorkshopList.Windmill,
            TimeSpan.FromSeconds(20), //thought it was 30 but was 20.
            i => { i[CountryItemList.Wheat] = 2; });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Sugar, CountryWorkshopList.Windmill,
            TimeSpan.FromMinutes(2),
            i => { i[CountryItemList.Corn] = 2; });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Biscuit, CountryWorkshopList.PastryOven,
            TimeSpan.FromSeconds(20),
            i =>
            {
                i[CountryItemList.Flour] = 1;
                i[CountryItemList.Milk] = 1;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.ApplePie, CountryWorkshopList.PastryOven,
            TimeSpan.FromMinutes(1),
            i =>
            {
                i[CountryItemList.Flour] = 2;
                i[CountryItemList.Apple] = 4;
                i[CountryItemList.Milk] = 1;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.CarrotCake, CountryWorkshopList.PastryOven,
            TimeSpan.FromMinutes(15),
            i =>
            {
                i[CountryItemList.Carrot] = 2;
                i[CountryItemList.Flour] = 4;
                i[CountryItemList.Eggs] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.BlackberryTart, CountryWorkshopList.PastryOven,
            TimeSpan.FromMinutes(2),
            i =>
            {
                i[CountryItemList.Blackberry] = 1;
                i[CountryItemList.Sugar] = 2;
                i[CountryItemList.Eggs] = 4;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.StrawberryShortCake, CountryWorkshopList.PastryOven,
            TimeSpan.FromHours(1),
            i =>
            {
                i[CountryItemList.Strawberry] = 4;
                i[CountryItemList.Flour] = 5;
                i[CountryItemList.Butter] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Butter, CountryWorkshopList.Dairy,
            TimeSpan.FromMinutes(5),
            i => { i[CountryItemList.Milk] = 3; });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.HerbButter, CountryWorkshopList.Dairy,
            TimeSpan.FromMinutes(5),
            i =>
            {
                i[CountryItemList.Butter] = 1;
                i[CountryItemList.Chives] = 1;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.PeachYogurt, CountryWorkshopList.Dairy,
           TimeSpan.FromMinutes(3),
           i =>
           {
               i[CountryItemList.Peach] = 2;
               i[CountryItemList.GoatMilk] = 1;
           });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.FarmersSoup, CountryWorkshopList.StovetopOven,
            TimeSpan.FromMinutes(3.5),
            i =>
            {
                i[CountryItemList.GoatMilk] = 4;
                i[CountryItemList.Carrot] = 5;
                i[CountryItemList.Tomato] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.GranolaBar, CountryWorkshopList.StovetopOven,
            TimeSpan.FromMinutes(7),
            i =>
            {
                i[CountryItemList.HoneyComb] = 1;
                i[CountryItemList.Wheat] = 5;
                i[CountryItemList.Strawberry] = 4;
            });
        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Socks, CountryWorkshopList.Loom,
            TimeSpan.FromHours(2),
            i => { i[CountryItemList.Wool] = 4; });
        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Trousers, CountryWorkshopList.Loom,
            TimeSpan.FromMinutes(20),
            i => { i[CountryItemList.Wool] = 6; });

        WorkshopRecipe.AddWorkshopRecipe(output, CountryItemList.Blanket, CountryWorkshopList.Loom,
            TimeSpan.FromMinutes(10),
            i => { i[CountryItemList.Wool] = 3; });

        return Task.FromResult(output);
    }
}