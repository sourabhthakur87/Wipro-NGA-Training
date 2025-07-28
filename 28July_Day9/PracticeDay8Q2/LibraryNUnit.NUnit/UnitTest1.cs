using PracticeDay8Q2;
namespace LibraryNUnit.NUnit
    
{
    public class Tests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToList()
        {
            var book = new Book { Title = "Test Book", Author = "Author", ISBN = "123" };
            library.AddBook(book);
            Assert.Contains(book, library.Books);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToList()
        {
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "111" };
            library.RegisterBorrower(borrower);
            Assert.Contains(borrower, library.Borrowers);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "101" };
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("001", "101");

            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "101" };
            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("001", "101");

            library.ReturnBook("001", "101");

            Assert.IsFalse(book.IsBorrowed);
            Assert.IsFalse(borrower.BorrowedBooks.Contains(book));
        }

        [Test]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            library.AddBook(book);

            var books = library.ViewBooks();
            Assert.Contains(book, books);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "111" };
            library.RegisterBorrower(borrower);

            var borrowers = library.ViewBorrowers();
            Assert.Contains(borrower, borrowers);
        }
    }
}