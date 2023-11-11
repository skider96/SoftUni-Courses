namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();
            
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article myArticle = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] secondInput = Console.ReadLine().Split(": ");
               
            }

            Console.WriteLine(myArticle);
        }

    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
