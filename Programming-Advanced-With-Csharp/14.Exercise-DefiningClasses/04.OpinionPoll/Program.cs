namespace OpinionPoll
{
    public class OpinionPoll
    {
        static void Main(string[] args)
        {
            // Using the Person class, write a program that reads from the console N lines of personal information and then prints all people, whose age is more than 30 years, sorted in alphabetical order.

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
            }


            //TODO
        }
    }
}
/*
3
Peter 12
Sam 31
Ivan 48
 */