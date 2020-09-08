using System;
using System.Text.Json;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder pattern with Director");

            var houseBuilder = new HouseBuilder();
            var director = new ConstructionEngineer(houseBuilder);

            director.BuildHouseParisien();
            Console.WriteLine($"Construire maison à Paris : {JsonSerializer.Serialize(houseBuilder.Build())}");

            director.BuildHouseCampagnard();
            Console.WriteLine($"Construire maison à Provence : {JsonSerializer.Serialize(houseBuilder.Build())}");
        }
    }
}
