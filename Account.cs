using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstNew
{
    class Account
    {
        BlogContext context = new BlogContext();
        

        public void Register()
        {

            Console.Write("Date: ");

            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Title: ");

            string title = Console.ReadLine();

            Post post = new Post(date, title);

            SaveChanges(post);




        }

        public void SaveChanges(Post post)
        {
            context.Add(post);
            context.SaveChanges();
        }

        public void DisplayCustomers()
        {
            Console.Clear();

            List<Post> postList = context.Posts.ToList();

            foreach (var customer in postList)
            {
                Console.WriteLine($"{customer.Date} {customer.Title}");
            }

            Console.ReadLine();
        }
    }
}
