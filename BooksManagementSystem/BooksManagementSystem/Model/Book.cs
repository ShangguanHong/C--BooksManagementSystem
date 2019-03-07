using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem.Model
{
    public class Book
    {
        private int id;
        private string isbn;
        private bool isBorrow;
        private string location;

        public Book() { }

        public Book(int id, string isbn, bool isBorrow, string location)
        {
            this.id = id;
            this.isbn = isbn;
            this.isBorrow = isBorrow;
            this.location = location;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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

        public bool IsBorrow
        {
            get
            {
                return isBorrow;
            }

            set
            {
                isBorrow = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
    }
}
