using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Navid has a question", "Navid asked the next question: How can I change a private property?");

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Vote);
            Console.Read();
        }
    }

    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; private set; }
        public int Vote { get; set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            this.Vote++;
        }

        public void DownVote()
        {
            this.Vote--;
        }
    }
}
