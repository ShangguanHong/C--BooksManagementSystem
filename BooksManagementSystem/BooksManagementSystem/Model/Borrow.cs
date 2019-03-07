using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem.Model
{
    public class Borrow
    {
        private int id;
        private int userId;
        private int bookId;
        private DateTime? borrowDate;
        private DateTime? lastReturnDate;
        private DateTime? returnDate;
        private bool isReturn;

        public Borrow() { }

        public Borrow(int id, int userId, int bookId, DateTime? borrowDate, DateTime? lastReturnDate, DateTime? returnDate, bool isReturn)
        {
            this.id = id;
            this.userId = userId;
            this.bookId = bookId;
            this.borrowDate = borrowDate;
            this.lastReturnDate = lastReturnDate;
            this.returnDate = returnDate;
            this.isReturn = isReturn;
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

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public int BookId
        {
            get
            {
                return bookId;
            }

            set
            {
                bookId = value;
            }
        }

        public bool IsReturn
        {
            get
            {
                return isReturn;
            }

            set
            {
                isReturn = value;
            }
        }

        public DateTime? BorrowDate
        {
            get
            {
                return borrowDate;
            }

            set
            {
                borrowDate = value;
            }
        }

        public DateTime? LastReturnDate
        {
            get
            {
                return lastReturnDate;
            }

            set
            {
                lastReturnDate = value;
            }
        }

        public DateTime? ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }
    }
}
