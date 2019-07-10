using System;
using System.Collections.Generic;

namespace planner
{
    class City
    {
        public string _name;
        private string _mayor;
        private int _established;

        public List<Building> Buildings { get; set; }

        public City(string name, string mayor, int ye)
        {
            _name = name;
            _mayor = mayor;
            _established = ye;
            Buildings = new List<Building>();
        }

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public void ShowBuildings()
        {
            Console.WriteLine($"These are the buildings in {_name}");
            foreach (Building building in Buildings)
            {
                building.Show();
                Console.WriteLine("<------------------->");
            }
        }

    }
}