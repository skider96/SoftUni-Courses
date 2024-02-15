
namespace _08.MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> allArmor = new(InputFromConsole());
            Stack<int> soldiersFullStrength = new(InputFromConsole());

            int killedMonsters = 0;

            while (allArmor.Any() && soldiersFullStrength.Any())
            {
                if (allArmor.Peek() <= soldiersFullStrength.Peek())
                {
                    int lastArmor = allArmor.Dequeue();
                    killedMonsters++;
                    if (!allArmor.Any())
                    {
                        Console.WriteLine("All monsters have been killed!");
                    }
                    if (soldiersFullStrength.Any() && lastArmor > 0)
                    {
                        int decreasedStrikeImpact = soldiersFullStrength.Pop() - lastArmor;
                        if (decreasedStrikeImpact > 0 && soldiersFullStrength.Any())
                        {
                            int nextStrikeElement = soldiersFullStrength.Pop() + decreasedStrikeImpact;
                            soldiersFullStrength.Push(nextStrikeElement);
                        }
                        continue;
                    }

                    if (soldiersFullStrength.Count == 1)
                    {
                        int lastStrike = soldiersFullStrength.Pop();
                        if (lastArmor > 0)
                        {
                            soldiersFullStrength.Push(lastStrike - lastArmor);
                        }
                        else
                        {
                            soldiersFullStrength.Push(lastStrike);
                        }
                    }
                }
                else
                {
                    int lastStrike = soldiersFullStrength.Pop();
                    if (!soldiersFullStrength.Any())
                    {
                        Console.WriteLine("The soldier has been defeated.");
                    }
                    if (allArmor.Any())
                    {
                        int lastArmor = allArmor.Dequeue() - lastStrike;
                        allArmor.Enqueue(lastArmor);
                    }
                }
            }

            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }

        public static IEnumerable<int> InputFromConsole()
        {
            return Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
    }
}
//Solved, but Judge gave me 62%...