using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_County
{
    class Program
    {
        static void Main(string[] args)
        {
            var continents = new Dictionary<string, List<string>>();    // Continent -> country
            var countries = new Dictionary<string, List<string>>();     // Coountry -> city

            var totalCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCommands; i++)
            {
                var commandParts = Console.ReadLine().Split();

                var continent = commandParts[0];
                var country = commandParts[1];
                var city = commandParts[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new List<string>();
                }

                var countriesInContinent = continents[continent];
                if (!countriesInContinent.Contains(country))
                {
                    countriesInContinent.Add(country);
                }

                if (!countries.ContainsKey(country))
                {
                    countries[country] = new List<string>();
                }

                var citiesInCountry = countries[country];
                if (!citiesInCountry.Contains(city))
                {
                    citiesInCountry.Add(city);
                }
            }

            foreach (var continentKvp in continents)
            {
                var continent = continentKvp.Key;
                var countriesInContinent = continentKvp.Value;

                Console.WriteLine($"{continent}:");

                foreach (var country in countriesInContinent)
                {
                    var cities = countries[country];

                    Console.WriteLine($" {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
