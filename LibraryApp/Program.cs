using LibraryApp;

var library = new Library();
library.AddBook(new Book { Id = 1, Title = "Война и мир", Author = "Толстой" });
library.AddBook(new Book { Id = 2, Title = "Преступление и наказание", Author = "Достоевский" });
library.AddBook(new Book { Id = 3, Title = "Мастер и Маргарита", Author = "Булгаков" });

library.BorrowBook(1);

library.BorrowBook(1);

library.ReturnBook(2);

try
{
    library.BorrowBook(999);
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.GetType().Name}");
}