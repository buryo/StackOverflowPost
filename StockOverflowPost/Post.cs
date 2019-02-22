using System;

namespace StockOverflowPost
{
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
