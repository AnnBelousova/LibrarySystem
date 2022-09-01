using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_01419012_Project1
{
    class Book
    {
        int ISBN;
        string Title, AuthorName, Category, Status, Publisher, DatePublish;

        public Book(int ISBN, string Title, string AuthorName, string Category, string Status, string Publisher, string DatePublish)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.AuthorName = AuthorName;
            this.Status = Status;
            this.Category = Category;
            this.Publisher = Publisher;
            this.DatePublish = DatePublish;
        }
        public Book()
        {
        }

        public override string ToString()
        {
            return "ISBN: " + ISBN + ", " + "Title: " + Title + ", " + "Author: " + AuthorName + ", "  +"\nCatagory: " + Category + ", "  + "Status: " + Status + ", " + "Publisher: " + Publisher + ", " + "Date of Publish: " + DatePublish;
        }
    }
}
