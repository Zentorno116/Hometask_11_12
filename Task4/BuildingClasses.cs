using System;
using System.Collections.Generic;

namespace BuildingNamespace
{
    public class Building
    {
        private string buildingNumber;
        private int floors;
        private string address;

        internal Building(string buildingNumber, int floors, string address)
        {
            this.buildingNumber = buildingNumber;
            this.floors = floors;
            this.address = address;
        }

        public string BuildingNumber
        {
            get { return buildingNumber; }
        }

        public int Floors
        {
            get { return floors; }
        }

        public string Address
        {
            get { return address; }
        }
    }

    public class Creator
    {
        private static Dictionary<string, Building> buildings = new Dictionary<string, Building>();

        private Creator() { }

        public static string CreateBuild(string address, int floors)
        {
            var buildingNumber = Guid.NewGuid().ToString();
            var building = new Building(buildingNumber, floors, address);
            buildings.Add(buildingNumber, building);
            return buildingNumber;
        }

        public static void RemoveBuild(string buildingNumber)
        {
            buildings.Remove(buildingNumber);
        }

        public static Building GetBuilding(string buildingNumber)
        {
            return buildings[buildingNumber];
        }
    }
}
