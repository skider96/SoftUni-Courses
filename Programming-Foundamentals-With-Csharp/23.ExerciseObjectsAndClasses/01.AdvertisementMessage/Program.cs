namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int randomPhraseIndex = RandomNumberGenerator(ad.phrase);
            int randomAuthorIndex = RandomNumberGenerator(ad.author);
            int randomCityIndex = RandomNumberGenerator(ad.city);
            int randomEventIndex = RandomNumberGenerator(ad.Event);

            Console.WriteLine($"{ad.phrase[randomPhraseIndex]} {ad.Event[randomEventIndex]} {ad.author[randomAuthorIndex]} – {ad.city[randomCityIndex]}.");
        }

        private static int RandomNumberGenerator(List<string> theColection)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, theColection.Count);
            return randomNumber;
        }

        class ad
        {
            public static List<string> phrase = new List<string>() {  "Excellent product." ,
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product."};
            public static List<string> author = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            public static List<string> city = new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"

            };
            public static List<string> Event = new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"

            };

        }
    }
}
