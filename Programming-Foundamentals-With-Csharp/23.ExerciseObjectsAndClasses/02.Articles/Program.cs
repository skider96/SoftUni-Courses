namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Article myArticle = new Article();


        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article editContent(string content)
        {
            return new Article { Content = Console.ReadLine() };
        }

        public Article ChangeAuthor(string author)
        {
            return new Article { Author = Console.ReadLine() };
        }

        public Article RenameNewTitle(string title)
        {
            return new Article { Title = Console.ReadLine() };
        }

        public override string ToString()
        {
            return "{title} - {content}: {author}";
        }
    }

}

/*
 *Edit (new content) – change the old content with the new one
   • ChangeAuthor (new author) – change the author
   • Rename (new title) – change the title of the article
   • Override the ToString method – print the article in the following format: 
   "{title} - {content}: {author}
 */