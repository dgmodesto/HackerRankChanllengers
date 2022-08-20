using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
        - Today, we will extend what we learned yestarday about Inheritance to Abstract Classes.
        - Because this is a very specific object oriented concept, submissions are limited to the few languages that use this construct.
        - Input
The Alchemist
Paulo Coelho
248
        - Output
Title: The Alchemist
Author: Paulo Coelho
Price: 248
     
     */

    public abstract class Book
    {
        protected string title;
        protected string author;

        protected Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public abstract void display();
    }

    public class AbstractClasses
    {

        public static void Initial(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }

    public class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price)
            :base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price.ToString());
        }
    }
}
