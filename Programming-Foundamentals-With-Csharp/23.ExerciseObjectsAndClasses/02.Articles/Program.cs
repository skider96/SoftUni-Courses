using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _02.Articles
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
                if (secondInput[0] == "Edit")
                {
                    myArticle.editContent(secondInput[1]);
                }
                else if (secondInput[0] == "ChangeAuthor")
                {
                    myArticle.ChangeAuthor(secondInput[1]);
                }
                else if (secondInput[0] == "Rename")
                {
                    myArticle.RenameNewTitle(secondInput[1]);
                }
            }

            Console.WriteLine(myArticle);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public void editContent(string editCcontent)
        {
            Content = editCcontent;
        }

        public void ChangeAuthor(string changedAuthor)
        {
            Author = changedAuthor;
        }

        public void  RenameNewTitle(string changedTitle)
        {
           Title = changedTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
