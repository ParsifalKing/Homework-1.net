namespace Homework_1;
using Dapper;
using Npgsql;

public class BookService
{
    private string _connectionString = "Server=localhost;Port=5432;Database=LibraryDb;User Id=postgres;Password=2007";


    public List<Book> GetBooks()
    {
        using var connection = new NpgsqlConnection(_connectionString);
        return connection.Query<Book>("select * from books").ToList();
    }

    public void AddBook(Book book)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Execute("insert into books (Title,Author,Category,Access) values(@Title,@Author,@Category,@Access) ", book);
    }

    public void UpdateBook(Book book)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Execute("update Books  set Title=@Title,Author=@Author,Category=@Category,Access=@Access  where Id=@Id ", book);
    }

    public void DeleteBook(int id)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Execute("delete from Books  where Id=@Id ", new { id = id });
    }

    public List<Book> SearchBookByTitle(string title)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        var result = connection.Query<Book>("select * from Books  where title=@title ", new { title = title }).ToList();
        return result;
    }

    public List<Book> SearchBookByAuthor(string author)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        var result = connection.Query<Book>("select * from Books  where author=@author ", new { author = author }).ToList();
        return result;
    }

    public List<Book> SearchBookByCategory(string category)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        var result = connection.Query<Book>("select * from Books  where category=@category ", new { category = category }).ToList();
        return result;
    }


    public void AccessOfBook(Book book)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Execute("update Books  set Access=@Access  where Id=@Id ", book);
    }





}
