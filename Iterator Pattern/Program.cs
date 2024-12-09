using Iterator_Pattern;
using Iterator_Pattern.Interfaces;
using Iterator_Pattern.Services;

Library library = new Library();
library.AddBook(new Book("Книга1", "Автор1", 2021));
library.AddBook(new Book("Книга2", "Автор2", 2022));

IReadableIterator iterator = library.GetIterator();
while (iterator.HasMoreBooks())
{
    Console.WriteLine(iterator.GetNextBook());
}