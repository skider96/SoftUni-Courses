using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new(InputFromConsole());
            Queue<int> greyTiles = new(InputFromConsole());

            Dictionary<string, List<int>> necessaryArea = new()
            {
                { "Sink", new List<int> { 40, 0 } },
                { "Oven", new List<int> { 50, 0 } },
                { "Countertop", new List<int> { 60, 0 } },
                { "Wall", new List<int> { 70, 0 } }
            };

            int counter = 0;
            while (greyTiles.Count > 0 && whiteTiles.Count > 0)
            {
                if (greyTiles.Peek() == whiteTiles.Peek())
                {
                    int newTile = greyTiles.Peek() + whiteTiles.Peek();
                    if (necessaryArea.Any(exist => exist.Value.Contains(newTile)))
                    {
                        greyTiles.Dequeue();
                        whiteTiles.Pop();
                        foreach (var key in necessaryArea)
                        {
                            if (key.Value[0] == newTile)
                            {
                                key.Value[1]++;
                            }
                        }
                    }
                    else
                    {
                        if (!necessaryArea.ContainsKey("Floor"))
                        {
                            necessaryArea.Add("Floor", new List<int>(){ newTile, 0});
                            continue;
                        }

                        necessaryArea["Floor"][0] += newTile;
                        necessaryArea["Floor"][1]++;

                        greyTiles.Dequeue();
                        whiteTiles.Pop();
                    }
                    continue;
                }

                counter++;
                if ( counter > 0)
                {
                    int areaOfWhiteTile = whiteTiles.Pop() / 2;
                    whiteTiles.Push(areaOfWhiteTile);

                    int areaOfGreyTile = greyTiles.Dequeue();
                    greyTiles.Enqueue(areaOfGreyTile);
                }
            }

            Printing(whiteTiles, "White");
            Printing(greyTiles, "Grey");

            var sortedDictionary = necessaryArea.OrderBy(a => a.Key).ToDictionary(pair => pair.Key, pair => pair.Value)
                .OrderByDescending(pair => pair.Value[1]).ToDictionary(pair => pair.Key, pair => pair.Value);
            
            foreach (var location in sortedDictionary)
            {
                if (location.Value[1] == 0)
                {
                    continue;
                }
                Console.WriteLine($"{location.Key}: {location.Value[1]}");
            }
        }

        private static void Printing(IEnumerable<int> tiles, string tileType)
        {
            if (tiles.Any())
            {
                Console.WriteLine($"{tileType} tiles left: " + string.Join(", ", tiles));
            }
            else
            {
                Console.WriteLine($"{tileType} tiles left: none");
            }
        }

        public static IEnumerable<int> InputFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
    }
}