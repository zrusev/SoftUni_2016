﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Map_Districts
{
    class Map_Districts
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bound = long.Parse(Console.ReadLine());
            input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(c =>
                    {
                        var tokens = c.Split(':');
                        var cityCode = tokens[0];
                        var districtPopulation = long.Parse(tokens[1]);
                        return new {cityCode, districtPopulation};
                    }
                )
                .GroupBy(
                    c => c.cityCode,
                    c => c.districtPopulation,
                    (city, population) => new
                    {
                        CityCode = city, Populations = population.ToList()
                    }
                )
                .Where(x => x.Populations.Sum() >= bound)
                .OrderByDescending(x => x.Populations.Sum())
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.CityCode}: {string.Join(" ", x.Populations.OrderByDescending(p => p).Take(5))}"));
        }
    }
}
