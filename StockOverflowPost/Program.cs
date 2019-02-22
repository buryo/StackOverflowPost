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
}
