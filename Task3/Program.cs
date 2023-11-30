using BuildingNamespace;

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 10.3. Здания.");
        string buildingNumber = Creator.CreateBuild("66 Vyazov St", 4);
        Building building = Creator.GetBuilding(buildingNumber);

        Console.WriteLine($"Номер здания: {building.BuildingNumber}");
        Console.WriteLine($"Этажи: {building.Floors}");
        Console.WriteLine($"Адрес: {building.Address}");

        Console.ReadKey();
        Console.Clear();
    }
}
