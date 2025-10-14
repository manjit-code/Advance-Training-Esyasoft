using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Book
    {
        public string bookId, title, author;
        public bool isIssued;

        public Book(string bookId, string title, string author, bool isIssued)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.isIssued = isIssued;
        }

        public void IssueBook()
        {
            if (isIssued)
            {
                Console.WriteLine("Book is already issued.");
                return;
            }
            Console.WriteLine("Book issued.");
            isIssued = true;
        }

        public void ReturnBook()
        {
            isIssued = true;
            Console.WriteLine("Thanks for returning the book !");
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Book Details:\nBook ID:{bookId}\nBook Title:{title}\nBook Author:{author}\nBook Available:{!isIssued}");
        }
    }
}
