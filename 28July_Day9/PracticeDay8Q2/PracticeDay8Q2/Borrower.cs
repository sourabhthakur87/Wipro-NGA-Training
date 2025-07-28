using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay8Q2
{
    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public void BorrowBook(Book book)
        {
            if (!book.IsBorrowed)
            {
                book.Borrow();
                BorrowedBooks.Add(book);
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.Return();
                BorrowedBooks.Remove(book);
            }
        }
    }
}
