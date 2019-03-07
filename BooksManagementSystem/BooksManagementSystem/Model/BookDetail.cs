using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem.Model
{
    public class BookDetail
    {
        private string isbn;
        private string name;
        private string author;
        private string press;
        private double price;
        private int totalNum;
        private int leftNum;
        private string categoryId;

        public BookDetail() { }

        public BookDetail(string isbn, string name, string author, string press, double price, int totalNum, int leftNum, string categoryId)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.press = press;
            this.price = price;
            this.totalNum = totalNum;
            this.leftNum = leftNum;
            this.categoryId = categoryId;
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Press
        {
            get
            {
                return press;
            }

            set
            {
                press = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int TotalNum
        {
            get
            {
                return totalNum;
            }

            set
            {
                totalNum = value;
            }
        }

        public int LeftNum
        {
            get
            {
                return leftNum;
            }

            set
            {
                leftNum = value;
            }
        }

        public string CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }
    }
}
