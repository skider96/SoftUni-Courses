namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantityFood = int.Parse(Console.ReadLine());

            int[] sequenceOfOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(sequenceOfOrders);

            Console.WriteLine(queue.Max());
            int counts = queue.Count;

            for (int i = 0; i < counts; i++)
            {
                if (!(quantityFood <= queue.Peek()))
                {
                    quantityFood -= queue.Dequeue();
                }
            }

            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
// It gets only 60% correct...