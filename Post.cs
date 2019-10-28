using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstNew
{
    public class Post
    {
        public Post(DateTime date, string title)
        {
            Date = date;
            Title = title;
        }
        public Post(int id, DateTime date, string title)
        {
            Date = date;
            Title = title;
            Id = id;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }

    }
}
