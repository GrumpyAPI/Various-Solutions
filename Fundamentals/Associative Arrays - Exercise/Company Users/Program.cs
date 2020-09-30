using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                if (input[0] == "End")
                {
                    break;
                }

                string companyName = input[0];
                string employeeId = input[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                companies[companyName].Add(employeeId);
            }

            companies = companies
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var kvp in company.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
