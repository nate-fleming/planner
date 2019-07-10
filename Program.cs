using System;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 4,
                Width = 400,
                Depth = 400
            };

            FiveOneTwoEigth.Contsruct();

            FiveOneTwoEigth.Purchase("Bob Ross");

            Building TwoHundredTwelveth = new Building("200 12th Avenue")
            {
                Stories = 8,
                Width = 200,
                Depth = 800
            };

            TwoHundredTwelveth.Contsruct();

            TwoHundredTwelveth.Purchase("Tyne");

            // FiveOneTwoEigth.Show();

            City megalopolis = new City("megalopolis", "Jason", 1982);

            megalopolis.AddBuilding(FiveOneTwoEigth);
            megalopolis.AddBuilding(TwoHundredTwelveth);

            megalopolis.ShowBuildings();
        }
    }
}
