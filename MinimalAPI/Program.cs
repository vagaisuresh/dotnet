var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var books = new List<Book> {
    new Book { Id = 1, Title = "Wings of Fire: An Autobiography", Author = "APJ" },
    new Book { Id = 2, Title = "Ignited Minds: Unleashing the Power Within India", Author = "APJ" },
    new Book { Id = 3, Title = "My Journey : Transforming Dreams into Actions", Author = "APJ" },
    new Book { Id = 4, Title = "Turning Points: A Journey Through Challenges", Author = "APJ" },
    new Book { Id = 5, Title = "My Life: An Illustrated Biography: An Illustrated Autobiography", Author = "APJ" }
};

app.MapGet("/books", () =>
{
    return books;
});

app.MapGet("/books/{id}", (int id) =>
{
    var book = books.Find(a => a.Id == id);

    if (book is null)
        return Results.NotFound("Requested book was not found.");
    
    return Results.Ok(book);
});

app.MapPost("/books", (Book book) =>
{
    books.Add(book);
    return books;
});

app.MapPut("/books/{id}", (int id, Book updatedBook) =>
{
    var book = books.Find(a => a.Id == id);

    if (book is null)
        return Results.NotFound("Requested book was not found.");

    book.Title = updatedBook.Title;
    book.Author = updatedBook.Author;

    return Results.Ok(book);
});

app.MapDelete("/books/{id}", (int id) =>
{
    var book = books.Find(a => a.Id == id);

    if (book is null)
        return Results.NotFound("Requested book was not found.");

    books.Remove(book);

    return Results.NoContent();
});

app.Run();

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
}