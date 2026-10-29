using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public class Library
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void BorrowBook(int id)
    {
        var book = FindBook(id);
        // БАГ 1: нет проверки на null -> NullReferenceException
        // БАГ 2: нет проверки IsAvailable -> можно выдать уже выданную
        book.IsAvailable = false;
        Console.WriteLine($"Книга '{book.Title}' выдана.");
    }

    public void ReturnBook(int id)
    {
        var book = FindBook(id);
        // БАГ 3: нет проверки на null и на то, что книга была выдана
        book.IsAvailable = true;
        Console.WriteLine($"Книга '{book.Title}' возвращена.");
    }

    public Book? FindBook(int id)
    {
        // БАГ 4: используем First() вместо FirstOrDefault() -> падает при отсутствии
        return _books.First(b => b.Id == id);
    }
}
}
