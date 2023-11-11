namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           List<Article> myArticleList = new List<Article>();
            
            for (int i = 0; i < n; i++)
            {
                string[] inputBreaking = Console.ReadLine().Split(', ');
                string title = inputBreaking[0];
                string content = inputBreaking[1];
                string author = inputBreaking[2];
                
                myArticleList.Add(new Article(title, content, author));
            }
            // Console.WriteLine(myArticleList);

            foreach (Article article in myArticleList)
            {
                   System.Console.WriteLine(article);               
            }
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